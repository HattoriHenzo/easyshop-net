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

namespace App.EasyShop.FormFournisseur
{
    public partial class FormDisplayFournisseurs : Form
    {
        FournisseurBO currentFournisseur = null;

        private FournisseurBLL fournisseurBLL;

        public FournisseurBO CurrentFournisseur
        {
            get { return currentFournisseur; }
            set { currentFournisseur = value; }
        }

        FournisseurBOListView listeFournisseur = null;

        public FournisseurBOListView ListeFournisseur
        {
            get { return listeFournisseur; }
            set { listeFournisseur = value; }
        }

        public FormDisplayFournisseurs()
        {
            fournisseurBLL = new FournisseurBLL();
            InitializeComponent();
        }      

        public DataGridView GridFournisseur
        {
            get { return this.gridFournisseur; }
            set { this.gridFournisseur = value; }
        }

        private void cmdQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDisplayFournisseurs_Load(object sender, EventArgs e)
        {
            this.currentFournisseur = new FournisseurBO();
            this.listeFournisseur = new FournisseurBOListView();

            this.listeFournisseur = fournisseurBLL.GetFournisseurs();
            this.fournisseurBOBindingSource.DataSource = this.listeFournisseur;
            this.gridFournisseur.DataSource = this.fournisseurBOBindingSource;
        }       

        private void cmdNouveau_Click(object sender, EventArgs e)
        {
            FormNewEditFournisseur formFourn = new FormNewEditFournisseur();
            formFourn.Text = "Nouveau fournisseur";
            formFourn.Modif = false;
            formFourn.Owner = this;            
            formFourn.ShowDialog();
        }

        private void cmdModifier_Click(object sender, EventArgs e)
        {
            if (this.gridFournisseur.RowCount != 0)
            {
                FormNewEditFournisseur formFourn = new FormNewEditFournisseur();
                formFourn.Text = "Modifier fournisseur";
                formFourn.Modif = true;
                formFourn.Owner = this;
                formFourn.ShowDialog();
            }
        }

        private void gridFournisseur_SelectionChanged(object sender, EventArgs e)
        {
            if (this.gridFournisseur.RowCount != 0)
            {
                this.currentFournisseur = (FournisseurBO)this.gridFournisseur.CurrentRow.DataBoundItem;
            }
        }

        private void cmdSupprimer_Click(object sender, EventArgs e)
        {
            if (this.gridFournisseur.RowCount != 0)
            {
                if (AppMessage.Question("Voulez vous supprimer ce fournisseur ?") != DialogResult.No)
                {
                    try
                    {
                        if (fournisseurBLL.Delete(this.currentFournisseur) != 0)
                        {
                            this.listeFournisseur.Remove(this.currentFournisseur);
                            this.gridFournisseur.Refresh();
                            AppMessage.Success("La supperssion s'est effectuée avec succès !");
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
}
