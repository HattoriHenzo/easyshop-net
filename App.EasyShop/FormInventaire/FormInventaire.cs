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

namespace App.EasyShop.FormInventaire
{
    public partial class FormInventaire : Form
    {       
        //Détermine si un inventaire est effectué ou pas
        bool invValide = false;       

        DateInventaireBOListView listeDateInv = null;

        InventaireBOListView listeInv = null;

        DateInventaireBO currentDateInv = null;

        InventaireBO currentInv = null;

        int nbArticle = 0;

        private InventaireBLL inventaireBLL;
        private DateInventaireBLL dateInventaireBLL;
        private ArticleBLL articleBLL;

        public FormInventaire()
        {
            inventaireBLL = new InventaireBLL();
            dateInventaireBLL = new DateInventaireBLL();
            articleBLL = new ArticleBLL();
            InitializeComponent();
        }

        private void FormInventaire_Load(object sender, EventArgs e)
        {
            this.listeDateInv = new DateInventaireBOListView();
            this.listeInv = new InventaireBOListView();
            this.currentDateInv = new DateInventaireBO();
            this.currentInv = new InventaireBO();          

            //On rempli la liste des dates d'inventaire
            this.listeDateInv = dateInventaireBLL.GetDatesInventaires();
            this.dateInventaireBOBindingSource.DataSource = this.listeDateInv;
            this.gridInventaire.DataSource = this.dateInventaireBOBindingSource;

            //On rempli la liste des inventaires
            this.inventaireBOBindingSource.DataSource = this.listeInv;
            this.gridArticleInventaire.DataSource = this.inventaireBOBindingSource;

            //Remplissage du combobox
            this.cbxArticle.DataSource = articleBLL.GetArticles(string.Empty);
            this.cbxArticle.ValueMember = "IdArt";
            this.cbxArticle.DisplayMember = "LibelleArt";

            this.nbArticle = articleBLL.GetArticles(string.Empty).Count;

            this.txtArticleRestant.Value = this.nbArticle.ToString();

        }

        private void cmdQuitter_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

        
        private void cmdValider_Click(object sender, EventArgs e)
        {
            if (AppMessage.Question("Voulez vous ajouter cette date d'inventaire ?") != DialogResult.No)
            {
                try
                {
                    DateInventaireBO d = new DateInventaireBO();

                    d.ObservationInv = this.txtObservation.Text;
                    d.DateInv = DateTime.Parse(this.dtpDateInventaire.Value.ToLongDateString());
                    d.HeureInv = DateTime.Now.ToShortTimeString();                    

                    if(dateInventaireBLL.Insert(d) != 0)
                    {
                        d.IdDateInv = dateInventaireBLL.GetMaxId();
                        this.listeDateInv.Add(d);
                        AppMessage.Success("L'insertion s'est effectuée avec succès !");
                    }
                }
                catch (AppException appEx)
                {
                    AppMessage.Error(appEx.Message);                    
                }
            }
        }

        private void gridInventaire_SelectionChanged(object sender, EventArgs e)
        {
            if (this.gridInventaire.RowCount != 0)
            {
                this.currentDateInv = (DateInventaireBO)this.gridInventaire.CurrentRow.DataBoundItem;

                this.dtpDateInventaire.Value = this.currentDateInv.DateInv;
                this.txtObservation.Text = this.currentDateInv.ObservationInv;

                //Affichage des articles associés
                this.listeInv = inventaireBLL.GetInventaireByDateId(this.currentDateInv.IdDateInv);
                this.inventaireBOBindingSource.DataSource = this.listeInv;
                this.gridArticleInventaire.DataSource = this.inventaireBOBindingSource;

                if (this.currentDateInv.ValideInv == true)
                {                    
                    this.cmValiderArt.Enabled = false;
                    this.cmdModifierArt.Enabled = false;
                    this.cmdSupprimerArt.Enabled = false;
                }
                else
                {
                    this.cmValiderArt.Enabled = true;
                    this.cmdModifierArt.Enabled = true;
                    this.cmdSupprimerArt.Enabled = true;
                }
            }
            
        }

        private void cmdSupprimer_Click(object sender, EventArgs e)
        {
            if (this.gridInventaire.RowCount != 0)
            {
                if (AppMessage.Question("Voulez vous effectuer la suppression ?") != DialogResult.No)
                {                    
                    if (dateInventaireBLL.Delete(this.currentDateInv) != 0)
                    {                        
                        this.listeDateInv.Remove(this.currentDateInv);                        

                        AppMessage.Success("La suppression s'est effectuée avec succès !");
                    }
                }
            }
        }
       
        private void cmValiderArt_Click(object sender, EventArgs e)
        {
            if (this.cbxArticle.SelectedItem != null)
            {
                if (this.gridInventaire.RowCount != 0)
                {
                    if (AppMessage.Question("Voulez vous ajouter cet article à la liste ?") != DialogResult.No)
                    {
                        try
                        {
                            InventaireBO inv = new InventaireBO();

                            inv.IdArt = ((ArticleBO)this.cbxArticle.SelectedItem).IdArt;
                            inv.IdDateInv = this.currentDateInv.IdDateInv;
                            inv.LibelleArt = ((ArticleBO)this.cbxArticle.SelectedItem).LibelleArt;
                            inv.QtePhysInv = int.Parse(this.txtQteCompte.Value);
                            inv.QteStockInv = articleBLL.GetArticleById(inv.IdArt).QteStockArt;
                            inv.EcartInv = 0;
                            inv.ObservationInv = string.Empty;

                            if (inventaireBLL.Insert(inv) != 0)
                            {
                                inv.IdInv = inventaireBLL.GetMaxId();
                                this.listeInv.Add(inv);
                                //Si au moins une insertion est faite,
                                //l'inventaire est considéré comme valide
                                this.invValide = true;
                                this.nbArticle -= 1;
                                this.txtArticleRestant.Value = this.nbArticle.ToString();
                                AppMessage.Success("L'insertion s'est effectuée avec succès !");

                                if (this.nbArticle == 0)
                                {
                                    if (AppMessage.Question("Tous les articles ont été inventoriés. Voulez vous quitter le formulaire ?") != DialogResult.No)
                                    {
                                        this.Close();
                                    }
                                }
                            }
                        }
                        catch (AppException appEx)
                        {
                            AppMessage.Error(appEx.Message);
                        }
                    }
                }            
            }            
        }

        private void gridArticleInventaire_SelectionChanged(object sender, EventArgs e)
        {
            if (this.gridArticleInventaire.RowCount != 0)
            {
                this.currentInv = (InventaireBO)this.gridArticleInventaire.CurrentRow.DataBoundItem;

                this.cbxArticle.Text = this.currentInv.LibelleArt;
                this.txtQteCompte.Value = this.currentInv.QtePhysInv.ToString();

                //Ajustement des boutons
                if (this.currentDateInv.ValideInv != true)
                {
                    this.EnableButtons();
                }
                else
                {
                    this.DisableButtons();                    
                }
            }
        }

        private void cmdModifierArt_Click(object sender, EventArgs e)
        {
            if (this.gridArticleInventaire.RowCount != 0)
            {
                if (AppMessage.Question("Voulez vous effectuer la modification ?") != DialogResult.No)
                {
                    InventaireBO oldInv = new InventaireBO();

                    oldInv.IdInv = this.currentInv.IdInv;
                    oldInv.QtePhysInv = int.Parse(this.txtQteCompte.Value);

                    if (inventaireBLL.UpdateQtePhysique(oldInv) != 0)
                    {
                        this.currentInv.QtePhysInv = oldInv.QtePhysInv;
                        this.gridArticleInventaire.Refresh();
                        AppMessage.Success("La modification s'est effectuée avec succès !");
                    }
                }
            }
        }

        private void cmdSupprimerArt_Click(object sender, EventArgs e)
        {
            if (this.gridInventaire.RowCount != 0)
            {
                if (AppMessage.Question("Voulez vous effectuer la suppression ?") != DialogResult.No)
                {
                    if (inventaireBLL.Delete(this.currentInv) != 0)
                    {
                        this.listeInv.Remove(this.currentInv);
                        AppMessage.Success("La suppression s'est effectuée avec succès !");
                    }
                }
            }
        }

        private void cmdDebloquer_Click(object sender, EventArgs e)
        {
            this.EnableButtons();                  
        }

        private void cbxArticle_SelectedValueChanged(object sender, EventArgs e)
        {
            this.txtQteCompte.Value = "0";
        }

        private void FormInventaire_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.invValide != false)
            {
                AppMessage.Warning("Cet inventaire sera considéré comme validé !");
                dateInventaireBLL.UpdateValide(this.currentDateInv);
            }
            else
            {
                if (AppMessage.Question("Voulez vous quitter le formulaire d'inventaire ?") != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }

        private void EnableButtons()
        {
            this.cmValiderArt.Enabled = true;
            this.cmdModifierArt.Enabled = true;
            this.cmdSupprimerArt.Enabled = true;
        }

        private void DisableButtons()
        {
            this.cmValiderArt.Enabled = false;
            this.cmdModifierArt.Enabled = false;
            this.cmdSupprimerArt.Enabled = false;
        }
    }
}
