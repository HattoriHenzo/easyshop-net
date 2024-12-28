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


namespace App.EasyShop.FormCommande
{
    public partial class FormNewEditArticleCommande : Form
    {
        /// <summary>
        /// Indique si on est dans un cas d'ajout ou de modification
        /// </summary>
        bool modif = false;

        private FournisseurBLL fournisseurBLL;
        private CommanderBLL commanderBLL;
        private ArticleBLL articleBLL;
        private CommandeBLL commandeBLL;

        public bool Modif
        {
            get { return modif; }
            set { modif = value; }
        }

        public FormNewEditArticleCommande()
        {
            fournisseurBLL = new FournisseurBLL();
            commanderBLL = new CommanderBLL();
            articleBLL = new ArticleBLL();
            commandeBLL = new CommandeBLL();
            InitializeComponent();
        }

        private void cmdQuitter_Click(object sender, EventArgs e)
        {
            //Fermeture de la fenetre
            this.Close();
        }

        private void FormEditCommande_Load(object sender, EventArgs e)
        {
            this.txtNumCommande.Text = ((FormDisplayCommande)this.Owner).CurrentCommande.NumComText;

            this.cbxArticle.DataSource = articleBLL.GetArticles(string.Empty);
            this.cbxArticle.ValueMember = "IdArt";
            this.cbxArticle.DisplayMember = "LibelleArt";

            this.cbxFournisseur.DataSource = fournisseurBLL.GetFournisseurs();
            this.cbxFournisseur.ValueMember = "IdFour";
            this.cbxFournisseur.DisplayMember = "RaisonSocialeFour";

            if (this.modif == true)
            {
                this.cbxArticle.Text = ((FormDisplayCommande)this.Owner).CurrentCommander.LibelleArt;
                this.txtQuantite.Value = ((FormDisplayCommande)this.Owner).CurrentCommander.QteCom.ToString();
                this.txtPrixUnitaire.Value = ((FormDisplayCommande)this.Owner).CurrentCommander.PrixCom.ToString();
                this.cbxFournisseur.Text = ((FormDisplayCommande)this.Owner).CurrentCommander.RaisonSocialeFour;
            }            
        }       

        private void cmdValider_Click(object sender, EventArgs e)
        {
                  
        }

        private void cmdSupprimer_Click(object sender, EventArgs e)
        {
           
        }

        private void gridDetailsCommande_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void cmdModifierCommande_Click(object sender, EventArgs e)
        {
            if (this.modif == false)
            {
                if (AppMessage.Question("Voulez vous ajouter cette commande ?") != DialogResult.No)
                {
                    try
                    {
                        CommanderBO c = new CommanderBO();

                        c.QteCom = int.Parse(this.txtQuantite.Value);
                        c.PrixCom = int.Parse(this.txtPrixUnitaire.Value);
                        c.Total = (c.QteCom * c.PrixCom);
                        c.IdArt = ((ArticleBO)this.cbxArticle.SelectedItem).IdArt;
                        c.LibelleArt = ((ArticleBO)this.cbxArticle.SelectedItem).LibelleArt;
                        c.IdCom = ((FormDisplayCommande)this.Owner).CurrentCommande.IdCom;
                        c.IdFour = ((FournisseurBO)this.cbxFournisseur.SelectedItem).IdFour;
                        c.RaisonSocialeFour = ((FournisseurBO)this.cbxFournisseur.SelectedItem).RaisonSocialeFour;

                        if (commanderBLL.Insert(c) != 0)
                        {
                            c.IdComder = commanderBLL.GetMaxId();
                            //Actualise la liste des details de la commande
                            ((FormDisplayCommande)this.Owner).ListeDetailCommande.Add(c);
                            ((FormDisplayCommande)this.Owner).TxtTotalCommande.Value = commandeBLL.GetTotalCommande(((FormDisplayCommande)this.Owner).ListeDetailCommande).ToString();

                            //Actualisation du DatagridView
                            ((FormDisplayCommande)this.Owner).GridDetailCommande.Refresh();

                            AppMessage.Success("L'insertion s'est effectuée avec succès !");
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
            else
            {
                if (AppMessage.Question("Voulez vous modifier cette commande ?") != DialogResult.No)
                {
                    try
                    {
                        CommanderBO cOld = new CommanderBO();

                        cOld.IdComder = ((FormDisplayCommande)this.Owner).CurrentCommander.IdComder;
                        cOld.QteCom = int.Parse(this.txtQuantite.Value);
                        cOld.PrixCom = int.Parse(this.txtPrixUnitaire.Value);
                        cOld.Total = (cOld.QteCom * cOld.PrixCom);
                        cOld.IdArt = ((ArticleBO)this.cbxArticle.SelectedItem).IdArt;
                        cOld.LibelleArt = ((ArticleBO)this.cbxArticle.SelectedItem).LibelleArt;
                        cOld.IdCom = ((FormDisplayCommande)this.Owner).CurrentCommande.IdCom;
                        cOld.IdFour = ((FournisseurBO)this.cbxFournisseur.SelectedItem).IdFour;
                        cOld.RaisonSocialeFour = ((FournisseurBO)this.cbxFournisseur.SelectedItem).RaisonSocialeFour;

                        if (commanderBLL.Update(cOld) != 0)
                        {
                            ((FormDisplayCommande)this.Owner).CurrentCommander.QteCom = cOld.QteCom;
                            ((FormDisplayCommande)this.Owner).CurrentCommander.PrixCom = cOld.PrixCom;
                            ((FormDisplayCommande)this.Owner).CurrentCommander.Total = cOld.Total;
                            ((FormDisplayCommande)this.Owner).CurrentCommander.IdArt = cOld.IdArt;
                            ((FormDisplayCommande)this.Owner).CurrentCommander.LibelleArt = cOld.LibelleArt;
                            ((FormDisplayCommande)this.Owner).CurrentCommander.IdCom = cOld.IdCom;
                            ((FormDisplayCommande)this.Owner).CurrentCommander.IdFour = cOld.IdFour;
                            ((FormDisplayCommande)this.Owner).CurrentCommander.RaisonSocialeFour = cOld.RaisonSocialeFour;

                            ((FormDisplayCommande)this.Owner).GridDetailCommande.Refresh();
                            ((FormDisplayCommande)this.Owner).TxtTotalCommande.Value = commandeBLL.GetTotalCommande(((FormDisplayCommande)this.Owner).ListeDetailCommande).ToString();
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

        private void cbxArticle_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.cbxArticle.Items.Count != 0)
            {
                if (((ArticleBO)this.cbxArticle.SelectedItem) != null)
                {
                    this.txtPrixUnitaire.Value = ((ArticleBO)this.cbxArticle.SelectedItem).PrixAchatArt.ToString();
                }                
            }
        }

        private void cbxArticle_Click(object sender, EventArgs e)
        {
           
        }

        private void cmdNouveauArticle_Click(object sender, EventArgs e)
        {
           
        }

        private void cmdNouveauFournisseur_Click(object sender, EventArgs e)
        {
           
        }

        private void cmdModifier_Click(object sender, EventArgs e)
        {
          
        }
    }
}
