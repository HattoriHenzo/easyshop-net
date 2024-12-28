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

namespace App.EasyShop.FormParametre
{
    public partial class FormParametres : Form
    {             
        //Objet de type categorie
        CategorieBO currentCategorie = null;

        private CategorieBLL categorieBLL;

        public TabControl InnerTabControl
        {
            get { return this.tabControlParametres; }
        }

        //Objet de type CategorieBOListview
        CategorieBOListView listeCategorie = null;

        public FormParametres()
        {
            categorieBLL = new CategorieBLL();
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
            this.chkValide.Checked = true;
        }

        private void cmdAjouterCategorie_Click(object sender, EventArgs e)
        {                       
            //Ajout d'une catégorie
            if (AppMessage.Question("Voulez vous ajouter cette catégorie ?") == DialogResult.Yes)
            {
                try
                {
                    CategorieBO newCategorie = new CategorieBO();
                    newCategorie.LibelleCat = this.txtCategorie.Text;
                    newCategorie.ValideCat = this.chkValide.Checked;

                    if (categorieBLL.Insert(newCategorie) != 0)
                    {
                        newCategorie.IdCat = categorieBLL.GetMaxId();
                        this.listeCategorie.Add(newCategorie);
                        AppMessage.Success("L'insertion s'est effectuée avec succès !");
                        this.gridCategorie.Refresh();
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
       

        private void tabCategorie_Enter(object sender, EventArgs e)
        {           
        }

        private void FormParametres_Load(object sender, EventArgs e)
        {
            this.currentCategorie = new CategorieBO();
            this.listeCategorie = new CategorieBOListView();

            this.listeCategorie = categorieBLL.GetCategories();
            this.categorieBOBindingSource.DataSource = this.listeCategorie;
            this.gridCategorie.DataSource = this.categorieBOBindingSource;

            this.chkValide.Checked = true;
        }

        private void cmdModifierCategorie_Click(object sender, EventArgs e)
        {
            if (this.gridCategorie.RowCount != 0)
            {
                //Modifie une catégorie
                if (AppMessage.Question("Voulez vous effectuer cette modificattion ?") == DialogResult.Yes)
                {
                    try
                    {
                        CategorieBO oldCategorie = new CategorieBO();
                        oldCategorie.IdCat = this.currentCategorie.IdCat;
                        oldCategorie.LibelleCat = this.txtCategorie.Text;
                        oldCategorie.ValideCat = this.chkValide.Checked;

                        if (categorieBLL.Update(oldCategorie) != 0)
                        {
                            AppMessage.Success("La modification s'est effectuée avec succès !");
                            this.currentCategorie.LibelleCat = this.txtCategorie.Text;
                            this.currentCategorie.ValideCat = this.chkValide.Checked;

                            this.gridCategorie.Refresh();
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

        private void cmdSupprimerCategorie_Click(object sender, EventArgs e)
        {
            if (this.gridCategorie.RowCount != 0)
            {
                //Suppression d'une catégorie
                if (AppMessage.Question("Voulez vous effectuer cette suppression ?") == DialogResult.Yes)
                {                                       
                    if (categorieBLL.UpdateValide(this.currentCategorie) != 0)
                    {
                        AppMessage.Success("La suppression s'est effectuée avec succès !");
                        this.currentCategorie.ValideCat = false;
                        this.gridCategorie.Refresh();                       
                    }
                }
            }            
        }

        private void gridCategorie_SelectionChanged(object sender, EventArgs e)
        {
            if (this.gridCategorie.RowCount != 0)
            {
                this.currentCategorie = (CategorieBO)this.gridCategorie.CurrentRow.DataBoundItem;

                this.txtCategorie.Text = this.currentCategorie.LibelleCat;
                this.chkValide.Checked = this.currentCategorie.ValideCat;
            }
        }
                             
        
    }
}
