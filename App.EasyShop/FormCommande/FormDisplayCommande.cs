using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using App.Reporting;
using App.BusinessObject;
using App.BusinessLogic;
using App.Tools;


namespace App.EasyShop.FormCommande
{
    public partial class FormDisplayCommande : Form
    {

        CommanderBO currentCommander = null;

        private CommandeBLL commandeBLL;
        private CommanderBLL commanderBLL;

        public CommanderBO CurrentCommander
        {
            get { return currentCommander; }
            set { currentCommander = value; }
        }

        CommandeBO currentCommande = null;

        /// <summary>
        /// Objet de type commande
        /// </summary>
        public CommandeBO CurrentCommande
        {
            get { return currentCommande; }
            set { currentCommande = value; }
        }

        CommandeBOListView listeCommande = null;

        /// <summary>
        /// Liste de commandes
        /// </summary>
        public CommandeBOListView ListeCommande
        {
            get { return listeCommande; }
            set { listeCommande = value; }
        }

        /// <summary>
        /// Liste des détails de la commande
        /// </summary>
        private CommanderBOListView listeDetailCommande;

        public CommanderBOListView ListeDetailCommande
        {
            get { return listeDetailCommande; }
            set { listeDetailCommande = value; }
        }

        public DataGridView GridCommande
        {
            get { return this.gridCommande; }
            set { this.gridCommande = value; }
        }

        public DataGridView GridDetailCommande
        {
            get { return this.gridDetailCommande; }
            set { this.gridDetailCommande = value; }
        }

        public AppNumericTextBox TxtTotalCommande
        {
            get { return this.txtTotalCommande; }
            set { this.txtTotalCommande = value; }
        }

        public FormDisplayCommande()
        {
            commandeBLL = new CommandeBLL();
            commanderBLL = new CommanderBLL();
            InitializeComponent();
        }

        private void cmdQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdNouveau_Click(object sender, EventArgs e)
        {
            FormNewEditCommande formCommande = new FormNewEditCommande();
            formCommande.Modif = false;
            formCommande.Text = "Nouvelle Commande";
            formCommande.Owner = this;
            formCommande.ShowDialog();
        }

        private void FormDisplayCommande_Load(object sender, EventArgs e)
        {           
            this.currentCommande = new CommandeBO();
            this.listeCommande = new CommandeBOListView();
            this.listeCommande = commandeBLL.GetCommandes();
            this.commandeBOBindingSource.DataSource = this.listeCommande;
            this.gridCommande.DataSource = this.commandeBOBindingSource;           

            this.currentCommander = new CommanderBO();
            this.listeDetailCommande = new CommanderBOListView();
            //this.listeDetailCommande = CommanderBLL.Instance.
            
        }       

        private void gridCommande_SelectionChanged(object sender, EventArgs e)
        {
           
        }        

        private void cmdModifier_Click(object sender, EventArgs e)
        {
            if (this.gridCommande.RowCount != 0)
            {
                FormNewEditCommande formCommande = new FormNewEditCommande();
                formCommande.Modif = true;
                formCommande.Text = "Modifier Commande";
                formCommande.Owner = this;
                formCommande.ShowDialog();
            }
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            if (this.gridCommande.RowCount != 0)
            {
                if (AppMessage.Question("Voulez vous annuler cette commande ?") != DialogResult.No)
                {
                    if (commandeBLL.UpdateAnnuler(this.currentCommande) != 0)
                    {
                        this.currentCommande.AnnulerCom = true;
                        this.gridCommande.Refresh();
                        AppMessage.Success("La commande est maintenant annulée !");
                    }                                         
                }                
            }
        }
       
        private void cbxFiltreCommande_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmdLivraison_Click(object sender, EventArgs e)
        {
            if (this.gridCommande.RowCount != 0)
            {
                FormLivraison.FormLivraison formLiv = new App.EasyShop.FormLivraison.FormLivraison();
                formLiv.Owner = this;
                formLiv.ShowDialog();
            }
        }

        private void cmdImprimer_Click(object sender, EventArgs e)
        {
            if (this.gridDetailCommande.RowCount > 0)
            {
                if (AppMessage.Question("Voulez vous imprimer le détail de la commande ?") == DialogResult.Yes)
                {
                    FormShowCommande showCommande = new FormShowCommande();

                    showCommande.Owner = this;
                    showCommande.IdCom = this.currentCommande.IdCom;                    
                    showCommande.ShowDialog();
                }
            }
        }

        private void gridCommande_SelectionChanged_1(object sender, EventArgs e)
        {
            if (this.gridCommande.RowCount != 0)
            {
                //Récupération de la commande en cours
                this.currentCommande = (CommandeBO)this.gridCommande.CurrentRow.DataBoundItem;

                //Remplissage du détail des commandes
                this.listeDetailCommande = commanderBLL.GetCommanderByCommandeId(this.currentCommande.IdCom);
                this.commanderBOBindingSource.DataSource = this.listeDetailCommande;
                this.gridDetailCommande.DataSource = this.commanderBOBindingSource;                

                //Affichage du total de la commande
                this.txtTotalCommande.Value = commandeBLL.GetTotalCommande(this.listeDetailCommande).ToString();

                if (this.currentCommande.AnnulerCom == true)
                {
                    this.DisableButtonsDetail();
                }
                else
                {
                    this.EnableButtonsDetail();
                }
            }
        }

        private void cmdNouveauDetailCom_Click(object sender, EventArgs e)
        {
            if (this.gridCommande.RowCount != 0)
            {
                //Initialisation du detail des commandes
                this.listeDetailCommande = commanderBLL.GetCommanderByCommandeId(this.currentCommande.IdCom);
                this.commanderBOBindingSource.DataSource = this.listeDetailCommande;

                FormNewEditArticleCommande formArtCom = new FormNewEditArticleCommande();
                formArtCom.Modif = false;
                formArtCom.Text = "Nouvel article";
                formArtCom.Owner = this;
                formArtCom.ShowDialog();               
            }
            
        }

        private void cmdModifierDetailCom_Click(object sender, EventArgs e)
        {
            if (this.gridDetailCommande.RowCount != 0)
            {
                FormNewEditArticleCommande formArtCom = new FormNewEditArticleCommande();
                formArtCom.Modif = true;
                formArtCom.Text = "Modifier article";
                formArtCom.Owner = this;
                formArtCom.ShowDialog();                
            }
        }

        private void cmdSupprimerDetailCom_Click(object sender, EventArgs e)
        {
            if (this.gridDetailCommande.RowCount != 0)
            {
                if (AppMessage.Question("Voulez vous effectuer la suppression ?") != DialogResult.No)
                {
                    if (commanderBLL.Delete(this.currentCommander) != 0)
                    {
                        this.listeDetailCommande.Remove(this.currentCommander);
                        this.gridDetailCommande.Refresh();
                        AppMessage.Success("La suppression s'est effectuée avec succès !");

                        this.txtTotalCommande.Value = commandeBLL.GetTotalCommande(this.listeDetailCommande).ToString();
                    }
                }
            }
        }

        private void gridDetailCommande_SelectionChanged(object sender, EventArgs e)
        {
            if (this.gridDetailCommande.RowCount != 0)
            {
                this.currentCommander = (CommanderBO)this.gridDetailCommande.CurrentRow.DataBoundItem;
            }
        }


        private void EnableButtonsDetail()
        {
            this.cmdNouveauDetailCom.Enabled = true;
            this.cmdModifierDetailCom.Enabled = true;
            this.cmdSupprimerDetailCom.Enabled = true;
        }

        private void DisableButtonsDetail()
        {
            this.cmdNouveauDetailCom.Enabled = false;
            this.cmdModifierDetailCom.Enabled = false;
            this.cmdSupprimerDetailCom.Enabled = false;
        }

        private void gridDetailCommande_DoubleClick(object sender, EventArgs e)
        {
            if (this.gridDetailCommande.RowCount != 0)
            {
                FormNewEditArticleCommande formArtCom = new FormNewEditArticleCommande();
                formArtCom.Modif = true;
                formArtCom.Text = "Modifier article";
                formArtCom.Owner = this;
                formArtCom.ShowDialog();
            }
        }

        private void FormDisplayCommande_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(AppMessage.Question("Voulez vous quitter le formulaire ?") != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
        
    }
}
