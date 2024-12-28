using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BusinessLogicLayerLib;
using DataAccessLayerLib;
using ToolsLib;

namespace GestionBoutique.FormParametre
{
    public partial class FormParametres : Form
    {              
        GestionBoutiqueDataSet.CategorieRow currentCategorie = null;

        public TabControl InnerTabControl
        {
            get { return this.tabControlParametres; }
        }

        public FormParametres()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Fonction qui vide le textbox
        /// </summary>
        private void cmdNouveau_Click(object sender, EventArgs e)
        {
           
        }
        
       
        private void cmdQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }                             

        private void cmdNouveauCategorie_Click(object sender, EventArgs e)
        {
            this.txtCategorie.Text = "";
        }

        private void cmdAjouterCategorie_Click(object sender, EventArgs e)
        {
            if (AppMessage.Question("Voulez vous effectuer cette insertion ?") == DialogResult.Yes)
            {
                try
                {
                    if (CategorieBLL.Instance.Insert(this.txtCategorie.Text, this.chkValide.Checked) != 0)
                    {
                        this.gridCategorie.DataSource = CategorieBLL.Instance.GetCategories();
                        this.txtCategorie.Text = "";
                        this.chkValide.Checked = false;
                        this.gridCategorie.Columns[0].Visible = false;

                        this.txtCategorie.Focus();

                        AppMessage.Success("L'insertion s'est effectuée avec succès !");
                    }
                }
                catch (AppException appEx)
                {
                    AppMessage.Error(appEx.Message);
                }
            }
        }

        private void gridCategorie_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int currentID = (int)this.gridCategorie.CurrentRow.Cells[0].Value;
                this.currentCategorie = CategorieBLL.Instance.GetCategories().FindByIdCat(currentID);
                this.txtCategorie.Text = this.currentCategorie.Catégories;
                this.chkValide.Checked = this.currentCategorie.Valide;
            }
            catch
            {
            }
        }

        private void tabCategorie_Enter(object sender, EventArgs e)
        {
            //Remplissage du datagridview
            this.gridCategorie.DataSource = CategorieBLL.Instance.GetCategories();
            this.gridCategorie.Columns[0].Visible = false;
        }

        private void FormParametres_Load(object sender, EventArgs e)
        {

        }

        private void cmdModifierCategorie_Click(object sender, EventArgs e)
        {
            this.currentCategorie.Catégories = this.txtCategorie.Text;

            if (AppMessage.Question("Voulez vous effectuer cette modification ?") == DialogResult.Yes)
            {
                try
                {
                    if (CategorieBLL.Instance.Update(this.currentCategorie.IdCat, this.currentCategorie.Catégories, this.chkValide.Checked) != 0)
                    {                        
                        this.gridCategorie.CurrentRow.Cells[1].Value = this.currentCategorie.Catégories;
                        this.gridCategorie.CurrentRow.Cells[2].Value = this.chkValide.Checked;
                        AppMessage.Success("La modification s'est effectuée avec succès !");
                    }
                }
                catch (AppException appEx)
                {
                    AppMessage.Error(appEx.Message);
                }
            }
        }

        private void cmdSupprimerCategorie_Click(object sender, EventArgs e)
        {
            if (AppMessage.Question("Voulez vous effectuer cette suppression ?") == DialogResult.Yes)
            {
                try
                {
                    if (CategorieBLL.Instance.UpdateValide(this.chkValide.Checked, this.currentCategorie.IdCat) != 0)
                    {
                        this.gridCategorie.DataSource = CategorieBLL.Instance.GetCategories();
                        this.txtCategorie.Text = "";
                        this.chkValide.Checked = false;
                        AppMessage.Success("La suppression s'est effectuée avec succès !");
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
