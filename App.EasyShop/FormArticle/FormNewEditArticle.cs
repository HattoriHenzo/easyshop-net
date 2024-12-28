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


namespace App.EasyShop.FormArticle
{
    public partial class FormNewEditArticle : Form
    {
        private bool editMode;

        private CategorieBLL categorieBLL;
        private ArticleBLL articleBLL;
        private EntreeSortieBLL entreeSortieBLL;

        public bool EditMode
        {
            get { return editMode; }
            set { editMode = value; }
        }

        private UtilBO currentUser = null;

        public FormNewEditArticle()
        {
            this.categorieBLL = new CategorieBLL();
            this.articleBLL = new ArticleBLL();
            this.entreeSortieBLL = new EntreeSortieBLL();
            InitializeComponent();
        }

        private void FormNewArticle_Load(object sender, EventArgs e)
        {
            this.cbxCategorie.DataSource = this.categorieBLL.GetCategories();
            this.cbxCategorie.ValueMember = "IdCat";
            this.cbxCategorie.DisplayMember = "LibelleCat";

            this.currentUser = new UtilBO();
            this.InitUser();

            if (this.currentUser.TypeUtil == 2)
            {
                this.DisabledTextBox();
            }
            else
            {
                this.EnabledTextBox();
            }

            if(editMode == false)
            {
                //Cas d'un ajout d'un nouvelle article
                this.Text = "Ajouter un article";
                this.grpTitre.Text = "Nouvel article";
            }
            else
            {
                //Cas de modification d'un article
                this.Text = "Modifier un article";
                this.grpTitre.Text = "Modification article";
                this.txtQteStock.ReadOnly = true;

                //Récupération des données à modifier      
                this.txtArticle.Text = ((FormDisplayArticles)this.Owner).CurrentArticle.LibelleArt;
                this.cbxCategorie.Text = ((FormDisplayArticles)this.Owner).CurrentArticle.Categorie.LibelleCat;
                this.txtPrixAchat.Value = ((FormDisplayArticles)this.Owner).CurrentArticle.PrixAchatArt.ToString();
                this.txtPrixVente.Value = ((FormDisplayArticles)this.Owner).CurrentArticle.PrixVenteArt.ToString();
                this.txtPrixEnDemiGros.Value = ((FormDisplayArticles)this.Owner).CurrentArticle.PrixEnDemiGros.ToString();
                this.txtPrixEnGros.Value = ((FormDisplayArticles)this.Owner).CurrentArticle.PrixEnGros.ToString();
                this.txtQteEnGros.Value = ((FormDisplayArticles)this.Owner).CurrentArticle.QteEnGros.ToString();
                //this.txtCoutSortie.Value = ((FormDisplayArticles)this.Owner).CurrentArticle.CoutSortie.ToString();
                this.txtSeuil.Value = ((FormDisplayArticles)this.Owner).CurrentArticle.SeuilArt.ToString();
                this.txtQteStock.Value = ((FormDisplayArticles)this.Owner).CurrentArticle.QteStockArt.ToString();
            }
        }

        private void cmdQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdNewCategorie_Click(object sender, EventArgs e)
        {
            FormParametre.FormParametres formCat = new App.EasyShop.FormParametre.FormParametres();
            formCat.Owner = this;
            formCat.ShowDialog();

            //Actualisation du combobox
            this.cbxCategorie.DataSource = this.categorieBLL.GetCategories();
        }

        private void cmdAjouter_Click(object sender, EventArgs e)
        {
            #region Insertion d'un article

            if(editMode == false)
            {
                if (AppMessage.Question("Voulez vous insérer cet article ?") == DialogResult.Yes)
                {
                    try
                    {
                        ArticleBO newArticle = new ArticleBO();

                        newArticle.LibelleArt = this.txtArticle.Text;
                        newArticle.Categorie.IdCat = (int)this.cbxCategorie.SelectedValue;
                        newArticle.Categorie.LibelleCat = this.cbxCategorie.Text;
                        newArticle.PrixAchatArt = int.Parse(this.txtPrixAchat.Value);
                        newArticle.PrixVenteArt = int.Parse(this.txtPrixVente.Value);
                        newArticle.PrixEnDemiGros = int.Parse(this.txtPrixEnDemiGros.Value);
                        newArticle.PrixEnGros = int.Parse(this.txtPrixEnGros.Value);
                        newArticle.QteEnGros = int.Parse(this.txtQteEnGros.Value);
                        newArticle.SeuilArt = int.Parse(this.txtSeuil.Value);
                        newArticle.QteStockArt = int.Parse(this.txtQteStock.Value);
                        //Récupération de l'utilisateur
                        this.InitUser();
                        newArticle.IdUser = this.currentUser.IdUtil;
                        newArticle.DateEnreg = DateTime.Today;
                        newArticle.CodeValidite = 1;

                        if (this.articleBLL.Insert(newArticle) != 0)
                        {
                            //Insertion implicite d'une entrée dans la base de données
                            EntreeSortieBO newES = new EntreeSortieBO();
                            newES.QteES = int.Parse(this.txtQteStock.Value);
                            newES.DateES = DateTime.Today;
                            newES.HeureES = DateTime.Now.ToShortTimeString();
                            newES.TypeES = "entree";
                            newES.MotifS = string.Empty;
                            newES.ObservationES = string.Empty;

                            //Récupération de l'utilisateur
                            this.InitUser();

                            newES.IdUser = this.currentUser.IdUtil;
                            newES.IdArt = this.articleBLL.GetMaxId();

                            //Insertion de l'entrée sortie
                            entreeSortieBLL.Insert(newES);
                            newArticle.IdArt = articleBLL.GetMaxId();
                            AppMessage.Success("L'insertion s'est effectuée avec succès !");                                                                                 

                            if (this.Owner.GetType() == typeof(FormDisplayArticles))
                            {
                                ((FormArticle.FormDisplayArticles)this.Owner).ListArticle.Add(newArticle);
                                //On vide les champs
                                this.EmptyFields();
                                this.txtArticle.Focus();

                                //Recuperation de l'article insere
                                //((FormArticle.FormDisplayArticles)this.Owner).InsertedArticle = newArticle.LibelleArt;

                                if (((FormArticle.FormDisplayArticles)this.Owner).GridArticle.RowCount == 0)
                                {
                                    ((FormArticle.FormDisplayArticles)this.Owner).SearchArticles(newArticle.LibelleArt,"");
                                }

                                this.Close();

                            }
                            //Cas ou on insert un article a partir du formulaire E/S
                            else
                            {
                                ((FormEntreesSorties.FormEntreeSortie)this.Owner).InsertedArticle = this.txtArticle.Text;

                                //Fermeture du formulaire
                                this.Close();
                            }
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
                if (AppMessage.Question("Voulez vous modifier cet article ?") == DialogResult.Yes)
                {
                    try
                    {
                        ArticleBO oldArticle = new ArticleBO(); ;
                        oldArticle.IdArt = ((FormDisplayArticles)this.Owner).CurrentArticle.IdArt;
                        //On modifie l'article courant
                        oldArticle.LibelleArt = this.txtArticle.Text;
                        oldArticle.Categorie = (CategorieBO)this.cbxCategorie.SelectedItem;
                        oldArticle.PrixAchatArt = int.Parse(this.txtPrixAchat.Value);
                        oldArticle.PrixVenteArt = int.Parse(this.txtPrixVente.Value);
                        oldArticle.PrixEnDemiGros = int.Parse(this.txtPrixEnDemiGros .Value);
                        oldArticle.PrixEnGros = int.Parse(this.txtPrixEnGros.Value);
                        oldArticle.QteEnGros = int.Parse(this.txtQteEnGros.Value);
                        oldArticle.SeuilArt = int.Parse(this.txtSeuil.Value);
                        oldArticle.QteStockArt = int.Parse(this.txtQteStock.Value);

                        if (articleBLL.Update(oldArticle) != 0)
                        {
                            AppMessage.Success("La modification s'est effectuée avec succès !");

                            ((FormDisplayArticles)this.Owner).CurrentArticle.LibelleArt = oldArticle.LibelleArt;
                            ((FormDisplayArticles)this.Owner).CurrentArticle.Categorie = oldArticle.Categorie;
                            ((FormDisplayArticles)this.Owner).CurrentArticle.PrixAchatArt = oldArticle.PrixAchatArt;
                            ((FormDisplayArticles)this.Owner).CurrentArticle.PrixVenteArt = oldArticle.PrixVenteArt;
                            ((FormDisplayArticles)this.Owner).CurrentArticle.PrixEnDemiGros = oldArticle.PrixEnDemiGros;
                            ((FormDisplayArticles)this.Owner).CurrentArticle.PrixEnGros = oldArticle.PrixEnGros;
                            ((FormDisplayArticles)this.Owner).CurrentArticle.QteEnGros = oldArticle.QteEnGros;
                            ((FormDisplayArticles)this.Owner).CurrentArticle.CoutSortie = oldArticle.CoutSortie;
                            ((FormDisplayArticles)this.Owner).CurrentArticle.SeuilArt = oldArticle.SeuilArt;
                            ((FormDisplayArticles)this.Owner).CurrentArticle.QteStockArt = oldArticle.QteStockArt;

                            ((FormDisplayArticles)this.Owner).GridArticle.Refresh();
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
            
            #endregion
        }

        /// <summary>
        /// On vide les champs après insertion
        /// </summary>
        private void EmptyFields()
        {
            this.txtArticle.Text = "";

            this.txtPrixAchat.Text = "0";
            this.txtPrixAchat.Value = "0";

            this.txtPrixVente.Text = "0";
            this.txtPrixVente.Value = "0";

            this.txtPrixEnGros.Text = "0";
            this.txtPrixEnGros.Value = "0";

            this.txtPrixEnDemiGros.Text = "0";
            this.txtPrixEnDemiGros.Value = "0";

            this.txtQteEnGros.Text = "0";
            this.txtQteEnGros.Value = "0";                        

            this.txtSeuil.Text = "0";
            this.txtSeuil.Value = "0";

            this.txtQteStock.Text = "0";
            this.txtQteStock.Value = "0";
        }

        private void InitUser()
        {
            //Affectation des utilisateurs
            if (this.Owner.GetType() == typeof(FormDisplayArticles))
            {
                this.currentUser = ((FormMain)((FormArticle.FormDisplayArticles)this.Owner).Owner).CurrentUtil;
            }
            else
            {
                this.currentUser = ((FormMain)((FormEntreesSorties.FormEntreeSortie)this.Owner).Owner).CurrentUtil;
            }           
        }

        private void EnabledTextBox()
        {
            this.txtPrixAchat.Text = "0";
            this.txtPrixAchat.Enabled = true;
            this.txtPrixVente.Enabled = true;
        }

        private void DisabledTextBox()
        {
            this.txtPrixAchat.Text = "0";
            this.txtPrixAchat.Enabled = false;
            this.txtPrixVente.Enabled = false;
        }

        private void txtQteStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSeuil_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQteEnGros_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrixEnGros_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
