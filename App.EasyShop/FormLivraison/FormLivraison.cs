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

namespace App.EasyShop.FormLivraison
{
    public partial class FormLivraison : Form
    {
        LivraisonBOListView listeLivraison = null;

        LivraisonBO currentLivraison = null;

        CommanderBOListView listeCommande = null;

        CommanderBO currentCommande = null;

        ArticleLivreBOListView listeArticleLivre = null;

        ArticleLivreBO currentArticleLivre = null;

        private EntreeSortieBLL entreeSortieBLL;
        private LivraisonBLL livraisonBLL;
        private CommanderBLL commanderBLL;
        private ArticleLivreBLL articleLivreBLL;
        private ArticleBLL articleBLL;

        public FormLivraison()
        {
            entreeSortieBLL = new EntreeSortieBLL();
            livraisonBLL = new LivraisonBLL();
            commanderBLL = new CommanderBLL();
            articleLivreBLL = new ArticleLivreBLL();
            articleBLL = new ArticleBLL();
            InitializeComponent();
        }

        private void txtQteLivre_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void FormLivraison_Load(object sender, EventArgs e)
        {
            this.txtCommande.Text = ((FormCommande.FormDisplayCommande)this.Owner).CurrentCommande.NumComText;            

            //Innitialisation des variables
            this.listeLivraison = new LivraisonBOListView();
            this.listeCommande = new CommanderBOListView();
            this.listeArticleLivre = new ArticleLivreBOListView();

            this.currentArticleLivre = new ArticleLivreBO();
            this.currentCommande = new CommanderBO();
            this.currentLivraison = new LivraisonBO();

            //On rempi la liste des livraisons
            this.listeLivraison = livraisonBLL.GetLivraisonsByCommandeId(((FormCommande.FormDisplayCommande)this.Owner).CurrentCommande.IdCom);
            this.livraisonBOBindingSource.DataSource = this.listeLivraison;
            this.gridLivraison.DataSource = this.livraisonBOBindingSource;

        }
                                  
        
        private void cmdQuitter_Click(object sender, EventArgs e)
        {            
            this.Close();
        }
       
        private void cmdNouvLivraison_Click(object sender, EventArgs e)
        {
                   
        }        

        private void cmdNouveau_Click(object sender, EventArgs e)
        {
            if (AppMessage.Question("Voulez vous valider cette livraison ?") != DialogResult.No)
            {
                try
                {                    
                    LivraisonBO l = new LivraisonBO();
                    l.DateLiv = DateTime.Parse(this.dtpLivraison.Value.ToShortDateString());
                    l.HeureLiv = DateTime.Now.ToShortTimeString();
                    l.NumFactLiv = this.txtFacBord.Text;
                    l.NumBLLiv = string.Empty;
                    l.IdCom = ((FormCommande.FormDisplayCommande)this.Owner).CurrentCommande.IdCom;

                    if (livraisonBLL.Insert(l) != 0)
                    {
                        this.currentLivraison.IdLiv = livraisonBLL.GetMaxId();
                        this.listeLivraison.Add(l);
                        AppMessage.Success("L'insertion s'est effectuée avec succès !");
                    }                    
                }
                catch (AppException appEx)
                {
                    AppMessage.Error(appEx.Message);
                }
            }

        }

        

        private void gridLivraison_SelectionChanged(object sender, EventArgs e)
        {
            if (this.gridLivraison.RowCount != 0)
            {
                this.currentLivraison = (LivraisonBO)this.gridLivraison.CurrentRow.DataBoundItem;

                this.dtpLivraison.Value = this.currentLivraison.DateLiv;
                this.txtFacBord.Text = this.currentLivraison.NumFactLiv;

                //Affiche le détail de la commadne associée
                this.listeCommande = commanderBLL.GetCommanderByCommandeId(this.currentLivraison.IdCom);
                this.commanderBOBindingSource.DataSource = this.listeCommande;
                this.gridDetailsCommandes.DataSource = this.commanderBOBindingSource;

                //Affiche le détail de la livraison
                this.listeArticleLivre = articleLivreBLL.GetArticleLivresByLivraisonId(this.currentLivraison.IdLiv);
                this.articleLivreBOBindingSource.DataSource = this.listeArticleLivre;
                this.gridDetailsLivraisons.DataSource = this.articleLivreBOBindingSource;
            }
        }

        private void gridDetailsCommandes_SelectionChanged(object sender, EventArgs e)
        {
            if (this.gridDetailsCommandes.RowCount != 0)
            {
                this.currentCommande = (CommanderBO)this.gridDetailsCommandes.CurrentRow.DataBoundItem;
            }
        }

        private void cmdValider_Click(object sender, EventArgs e)
        {
            
        }

        private void HideDetailLivColumns()
        {
           
        }

        private void cmdSupprimer_Click(object sender, EventArgs e)
        {
             
        }
        
        private void cmdSuppr_Click(object sender, EventArgs e)
        {
             
        }

        private void cmdModif_Click(object sender, EventArgs e)
        {
           
        }

        private void gridDetailsLivraisons_SelectionChanged(object sender, EventArgs e)
        {
             
        }

        private void cmdModifierLiv_Click(object sender, EventArgs e)
        {
            
        }

        private void FormLivraison_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (AppMessage.Question("Voulez vous quitter le formulaire ?") != DialogResult.Yes)
            {
                //On ferme le formulaire
                e.Cancel = true;
            }
        }

        private void cmdDebloquer_Click(object sender, EventArgs e)
        {
            //this.EnableButtons();
        }

        private void cmdModifier_Click(object sender, EventArgs e)
        {
            if (this.gridLivraison.RowCount != 0)
            {
                if (AppMessage.Question("Voulez vous effectuer la modification ?") != DialogResult.No)
                {
                    try
                    {
                        LivraisonBO lOld = new LivraisonBO();

                        lOld.IdLiv = this.currentLivraison.IdLiv;
                        lOld.DateLiv = DateTime.Parse(this.dtpLivraison.Value.ToShortDateString());
                        lOld.HeureLiv = DateTime.Now.ToShortTimeString();
                        lOld.NumFactLiv = this.txtFacBord.Text;
                        lOld.NumBLLiv = string.Empty;
                        lOld.IdCom = ((FormCommande.FormDisplayCommande)this.Owner).CurrentCommande.IdCom;


                        if (livraisonBLL.Update(lOld) != 0)
                        {
                            this.currentLivraison.DateLiv = lOld.DateLiv;
                            this.currentLivraison.HeureLiv = lOld.HeureLiv;
                            this.currentLivraison.NumFactLiv = lOld.NumFactLiv;
                            this.currentLivraison.IdCom = lOld.IdCom;

                            this.gridLivraison.Refresh();
                            AppMessage.Success("La modification s'est effectuée avec succès !");
                        }
                    }
                    catch (AppException appEx)
                    {
                        AppMessage.Error(appEx.Message);
                    }
                }
            }
        }

        private void txtAjoulerLiv_Click(object sender, EventArgs e)
        {
            if (this.gridLivraison.RowCount != 0)
            {
                if (AppMessage.Question("Voulez vous effectuer la livraison de cet article ?") != DialogResult.No)
                {
                    try
                    {
                        ArticleLivreBO a = new ArticleLivreBO();

                        a.LibelleArt = this.currentCommande.LibelleArt;
                        a.QteArtLiv = int.Parse(this.txtQteLivre.Value);
                        a.PrixLiv = this.currentCommande.PrixCom;
                        a.IdArt = this.currentCommande.IdArt;
                        a.IdLiv = this.currentLivraison.IdLiv;

                        if (articleLivreBLL.Insert(a, this.currentCommande) != 0)
                        {
                            a.IdArtLiv = articleLivreBLL.GetMaxId();
                            this.listeArticleLivre.Add(a);
                            AppMessage.Success("L'insertion de l'article s'est effectuée avec succès !");

                            //Une livraison validée implique une entrée -> on actualise la table !Entrée/Sortie
                            EntreeSortieBO es = new EntreeSortieBO();

                            es.QteES = a.QteArtLiv;
                            es.DateES = DateTime.Parse(this.currentLivraison.DateLiv.ToShortDateString());
                            es.HeureES = DateTime.Now.ToShortTimeString();
                            es.TypeES = "entree";
                            es.MotifS = string.Empty;
                            es.ObservationES = "Livraison du : " + this.currentLivraison.DateLiv.ToShortDateString();
                            es.IdUser = ((FormMain)((this.Owner).Owner)).CurrentUtil.IdUtil;
                            es.IdArt = a.IdArt;

                            if (entreeSortieBLL.Insert(es) != 0)
                            {
                                //Actualise la quantité dans la table article
                                articleBLL.UpdateQuantite(es.QteES, es.IdArt);
                            }
                        }
                    }
                    catch (AppException appEx)
                    {
                        AppMessage.Error(appEx.Message);
                    }
                }
            }
            else
            {
                AppMessage.Error("Veuillez saisir une date de livraison !");
            }
        }               
    }
}
