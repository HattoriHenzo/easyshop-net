using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using App.BusinessObject;
using App.BusinessLogic;
using App.Tools;

namespace App.EasyShop.FormStatistiques
{
    public partial class FormNewEditArchiveVente : Form
    {
        bool editMode = false;

        private ArticleBLL articleBLL;
        private ArchiveVenteBLL archiveVenteBLL;

        public bool EditMode
        {
            get { return editMode; }
            set { editMode = value; }
        }

        public FormNewEditArchiveVente()
        {
            articleBLL = new ArticleBLL();
            archiveVenteBLL = new ArchiveVenteBLL();
            InitializeComponent();
        }

        private void cmdFermer_Click(object sender, EventArgs e)
        {
            //Fermeture du formulaire
            this.Close();
        }

        private void FormNewEditArchiveVente_Load(object sender, EventArgs e)
        {
            this.txtPrixVente.Focus();            

            this.cbxArticles.DataSource = articleBLL.GetArticles(string.Empty);
            this.cbxArticles.ValueMember = "IdArt";
            this.cbxArticles.DisplayMember = "LibelleArt";

            //Cas d'un ajout
            if (this.editMode == false)
            {
                this.Text = "Ajout d'une vente";
                this.cbxTypeVente.SelectedIndex = 0;
                this.cbxRemisePourcentage.SelectedIndex = 0;
            }
            //Cas d'une modification
            else
            {
                this.Text = "Modification d'une vente";
                this.dtpDateVente.Value = ((FormStatistiques.FormStats)this.Owner).CurrentArchVente.DateVente;
                this.cbxArticles.Text = ((FormStatistiques.FormStats)this.Owner).CurrentArchVente.LibelleArt;
                this.cbxTypeVente.Text = ((FormStatistiques.FormStats)this.Owner).CurrentArchVente.TypeVente;
                this.cbxRemisePourcentage.Text = ((FormStatistiques.FormStats)this.Owner).CurrentArchVente.RemisePourcentage.ToString();
                this.txtRemiseMontant.Value = ((FormStatistiques.FormStats)this.Owner).CurrentArchVente.RemiseMontant.ToString();
                this.txtPrixAchat.Value = ((FormStatistiques.FormStats)this.Owner).CurrentArchVente.PrixAchat.ToString();
                this.txtPrixVente.Value = ((FormStatistiques.FormStats)this.Owner).CurrentArchVente.PrixVente.ToString();
                this.txtQteVente.Value = ((FormStatistiques.FormStats)this.Owner).CurrentArchVente.QteVente.ToString();                
            }
        }

        private void cbxArticles_SelectedValueChanged(object sender, EventArgs e)
        {            
            //Affectation de la catégorie
            this.txtCategorie.Text = ((ArticleBO)this.cbxArticles.SelectedItem).Categorie.LibelleCat;
            
            //Affectation du prix en fonction du type de vente
            int prix = 0;
            if(this.cbxTypeVente.Text.Equals("DETAIL"))
            {
                prix = ((ArticleBO)this.cbxArticles.SelectedItem).PrixVenteArt;
            }
            else
            {
                prix = ((ArticleBO)this.cbxArticles.SelectedItem).PrixEnGros;
            }
            this.txtPrixVente.Text = prix.ToString();

            //On recupere le prix d'achat
            if (this.editMode == false)
            {
                this.txtPrixAchat.Value = ((ArticleBO)this.cbxArticles.SelectedItem).PrixAchatArt.ToString();
            }
        }

        private void cmdModifier_Click(object sender, EventArgs e)
        {
            int resteStock = int.Parse(this.txtQteVente.Value) - ((FormStatistiques.FormStats)this.Owner).CurrentArchVente.QteVente;
            if (resteStock > ((ArticleBO)this.cbxArticles.SelectedItem).QteStockArt)
            {
                AppMessage.Error("Veuillez saisir une quantité inférieure ou égale a la quantité en stock !");
            }
            else
            {
                //Cas d'un ajout
                if (this.editMode == false)
                {
                    if (AppMessage.Question("Voulez vous ajouter cette vente ?") != DialogResult.No)
                    {
                        try
                        {
                            ArchiveVenteBO a = new ArchiveVenteBO();

                            a.DateVente = DateTime.Parse(this.dtpDateVente.Value.ToShortDateString());
                            a.HeureVente = DateTime.Now.ToShortTimeString();
                            a.NumeroVente = (((FormStatistiques.FormStats)this.Owner)).CurrentVente.NumeroVente;
                            a.IdArt = ((ArticleBO)this.cbxArticles.SelectedItem).IdArt;
                            a.LibelleArt = ((ArticleBO)this.cbxArticles.SelectedItem).LibelleArt;
                            a.LibelleCat = ((ArticleBO)this.cbxArticles.SelectedItem).Categorie.LibelleCat;
                            a.TypeVente = this.cbxTypeVente.Text;
                            a.PrixAchat = int.Parse(this.txtPrixAchat.Value);
                            a.PrixVente = int.Parse(this.txtPrixVente.Value);
                            a.QteVente = int.Parse(this.txtQteVente.Value);
                            a.RemisePourcentage = int.Parse(this.cbxRemisePourcentage.Text);
                            a.RemiseMontant = int.Parse(this.txtRemiseMontant.Value);
                            a.TotalVente = archiveVenteBLL.GetMontantTotal(a) - (archiveVenteBLL.GetRemisePourcentage(a) - a.RemiseMontant);
                            a.IdUser = ((FormMain)((FormStatistiques.FormStats)this.Owner).Owner).CurrentUtil.IdUtil;

                            if (archiveVenteBLL.Insert(a) != 0)
                            {
                                a.IdArch = archiveVenteBLL.GetMaxId();

                                ((FormStatistiques.FormStats)this.Owner).ListeArchVente.Add(a);

                                //Actualisation de la quantité total vendue
                                ((FormStatistiques.FormStats)this.Owner).TxtTotalVente.Value = archiveVenteBLL.GetTotalVente(((FormStatistiques.FormStats)this.Owner).ListeArchVente).ToString();

                                AppMessage.Success("L'insertion s'est effectuée avec succès !");

                                //Actualisation de la quantité en stock
                                articleBLL.UpdateQuantite((-1) * a.QteVente, a.IdArt);

                                //Actualisation de la quantité total vendue
                                ((FormStatistiques.FormStats)this.Owner).TxtTotalVente.Value = archiveVenteBLL.GetTotalVente(((FormStatistiques.FormStats)this.Owner).ListeArchVente).ToString();
                            }
                        }
                        catch (AppValidationException appValEx)
                        {
                            AppMessage.Error(appValEx.Message);
                        }
                        catch (AppException appEx)
                        {
                            AppMessage.Error(appEx.Message);
                        }
                    }
                }
                //Cas d'une modification
                else
                {
                    if (AppMessage.Question("Voulez vous modifier cette vente ?") != DialogResult.No)
                    {
                        try
                        {
                            ArchiveVenteBO oa = new ArchiveVenteBO();

                            oa.IdArch = ((FormStatistiques.FormStats)this.Owner).CurrentArchVente.IdArch;
                            oa.DateVente = DateTime.Parse(this.dtpDateVente.Value.ToShortDateString());
                            oa.HeureVente = DateTime.Today.ToShortTimeString();
                            oa.IdArt = ((ArticleBO)this.cbxArticles.SelectedItem).IdArt;
                            oa.LibelleArt = ((ArticleBO)this.cbxArticles.SelectedItem).LibelleArt;
                            oa.LibelleCat = ((ArticleBO)this.cbxArticles.SelectedItem).Categorie.LibelleCat;
                            oa.TypeVente = this.cbxTypeVente.Text;
                            oa.PrixAchat = int.Parse(this.txtPrixAchat.Value);
                            oa.PrixVente = int.Parse(this.txtPrixVente.Value);
                            oa.QteVente = int.Parse(this.txtQteVente.Value);
                            oa.RemisePourcentage = int.Parse(this.cbxRemisePourcentage.Text);
                            oa.RemiseMontant = int.Parse(this.txtRemiseMontant.Value);
                            oa.TotalVente = archiveVenteBLL.GetMontantTotal(oa) - (archiveVenteBLL.GetRemisePourcentage(oa) - oa.RemiseMontant);
                            oa.IdUser = ((FormMain)((FormStatistiques.FormStats)this.Owner).Owner).CurrentUtil.IdUtil;

                            if (archiveVenteBLL.Update(oa) != 0)
                            {

                                //Actualisation de la quantité en stock
                                int tmp = oa.QteVente - ((FormStatistiques.FormStats)this.Owner).CurrentArchVente.QteVente;

                                if (oa.QteVente > ((FormStatistiques.FormStats)this.Owner).CurrentArchVente.QteVente)
                                {
                                    articleBLL.UpdateQuantite((-1) * tmp, oa.IdArt);
                                }

                                if (oa.QteVente < ((FormStatistiques.FormStats)this.Owner).CurrentArchVente.QteVente)
                                {
                                    articleBLL.UpdateQuantite((-1) * tmp, oa.IdArt);
                                }

                                //Actualisation dans la grille de données
                                ((FormStatistiques.FormStats)this.Owner).CurrentArchVente.DateVente = oa.DateVente;
                                ((FormStatistiques.FormStats)this.Owner).CurrentArchVente.HeureVente = oa.HeureVente;
                                ((FormStatistiques.FormStats)this.Owner).CurrentArchVente.IdArt = oa.IdArt;
                                ((FormStatistiques.FormStats)this.Owner).CurrentArchVente.LibelleArt = oa.LibelleArt;
                                ((FormStatistiques.FormStats)this.Owner).CurrentArchVente.LibelleCat = oa.LibelleCat;
                                ((FormStatistiques.FormStats)this.Owner).CurrentArchVente.PrixAchat = oa.PrixAchat;
                                ((FormStatistiques.FormStats)this.Owner).CurrentArchVente.PrixVente = oa.PrixVente;
                                ((FormStatistiques.FormStats)this.Owner).CurrentArchVente.QteVente = oa.QteVente;
                                ((FormStatistiques.FormStats)this.Owner).CurrentArchVente.TypeVente = oa.TypeVente;
                                ((FormStatistiques.FormStats)this.Owner).CurrentArchVente.RemisePourcentage = oa.RemisePourcentage;
                                ((FormStatistiques.FormStats)this.Owner).CurrentArchVente.RemiseMontant = oa.RemiseMontant;
                                ((FormStatistiques.FormStats)this.Owner).CurrentArchVente.QteVente = oa.QteVente;
                                ((FormStatistiques.FormStats)this.Owner).CurrentArchVente.TotalVente = oa.TotalVente;
                                ((FormStatistiques.FormStats)this.Owner).CurrentArchVente.IdUser = oa.IdUser;

                                //Actualisation du formulaire
                                ((FormStatistiques.FormStats)this.Owner).GridArchVente.Refresh();

                                //Actualisation de la quantité total vendue
                                ((FormStatistiques.FormStats)this.Owner).TxtTotalVente.Value = archiveVenteBLL.GetTotalVente(((FormStatistiques.FormStats)this.Owner).ListeArchVente).ToString();

                                AppMessage.Success("La modification s'est effectuée avec succès !");

                                this.Close();
                            }
                        }
                        catch (AppValidationException appValEx)
                        {
                            AppMessage.Error(appValEx.Message);
                        }
                        catch (AppException appEx)
                        {
                            AppMessage.Error(appEx.Message);
                        }
                    }
                }
            }            
        }

        private void cbxTypeVente_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (this.cbxTypeVente.Text)
            {
                case "DETAIL":
                    this.txtPrixVente.Value = ((ArticleBO)this.cbxArticles.SelectedItem).PrixVenteArt.ToString();
                    break;

                case "DEMI GROS":
                    this.txtPrixVente.Value = ((ArticleBO)this.cbxArticles.SelectedItem).PrixEnDemiGros.ToString();
                    break;

                case "GROS":
                    this.txtPrixVente.Value = ((ArticleBO)this.cbxArticles.SelectedItem).PrixEnGros.ToString();
                    break;
            }            
        }
        
    }
}
