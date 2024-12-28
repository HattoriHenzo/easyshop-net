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

namespace App.EasyShop.FormEntreesSorties
{
    public partial class FormEntreeSortie : Form
    {
        UtilBO entreeUtil = null, sortieUtil = null;

        EntreeSortieBO entreeES = null, sortieES = null;

        EntreeSortieBOListView entreeListe = null, sortieListe = null;

        private ArticleBLL articleBLL;
        private EntreeSortieBLL entreeSortieBLL;
        private UtilBLL utilBLL;

        public string InsertedArticle
        {
            get;
            set;
        }        

        public FormEntreeSortie()
        {
            articleBLL = new ArticleBLL();
            entreeSortieBLL = new EntreeSortieBLL();
            utilBLL = new UtilBLL();
            InitializeComponent();            
        }

        private void cmdQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdNouveau_Click(object sender, EventArgs e)
        {
            FormArticle.FormNewEditArticle formNewArticle = new App.EasyShop.FormArticle.FormNewEditArticle();
            formNewArticle.Owner = this;
            formNewArticle.ShowDialog();


            //Remplissage des entrees
            this.cbxArticle.DataSource = articleBLL.GetArticles(string.Empty);
            this.cbxArticle.ValueMember = "IdArt";
            this.cbxArticle.DisplayMember = "LibelleArt";

            if (this.InsertedArticle != string.Empty)
            {                                
                this.cbxArticle.Text = this.InsertedArticle;
                int idArt = ((ArticleBO)this.cbxArticle.SelectedItem).IdArt;
                this.entreeListe = entreeSortieBLL.GetEntreeSortieByArticleId(idArt, "entree", string.Empty);
                this.entreeSortieBOBindingSource.DataSource = this.entreeListe;
                this.gridEntree.DataSource = this.entreeSortieBOBindingSource;
            }

            //Remplissage des sorties
            this.cbxArticleSortie.DataSource = articleBLL.GetArticles(string.Empty);
            this.cbxArticleSortie.ValueMember = "IdArt";
            this.cbxArticleSortie.DisplayMember = "LibelleArt";

            if (this.InsertedArticle != string.Empty)
            {
                this.cbxArticleSortie.Text = this.InsertedArticle;
                int idArt = ((ArticleBO)this.cbxArticleSortie.SelectedItem).IdArt;
                this.sortieListe = entreeSortieBLL.GetEntreeSortieByArticleId(idArt, "sortie", string.Empty);
                this.entreeSortieBOBindingSource1.DataSource = this.sortieListe;
                this.gridSortie.DataSource = this.entreeSortieBOBindingSource1;
            }     
        }

        private void FormEntreeSortie_Load(object sender, EventArgs e)
        {

            this.InitComboBox();

            this.InitLocalVariables();

            this.InitCurrentUser();

            this.InitGridview();            

            InsertedArticle = string.Empty;

            // We init the combobox 
            /*this.cbxMotif.Items.Clear();
            foreach(string s in Enum.GetValues(typeof(Motifs))) 
            {
                this.cbxMotif.Items.Add(s);
            }*/

            this.cbxMotif.DataSource = Enum.GetValues(typeof(Motifs));
        }

        private void DisplayES()
        {
            
        }

        private void cmdValiderEntree_Click(object sender, EventArgs e)
        {
            if (this.cbxArticle.SelectedItem != null)
            {
                if (AppMessage.Question("Voulez effectuer cette insertion ?") == DialogResult.Yes)
                {
                    try
                    {
                        EntreeSortieBO es = new EntreeSortieBO();

                        es.QteES = int.Parse(this.txtQte.Value);
                        es.DateES = DateTime.Parse(this.dtpEntree.Value.ToShortDateString());
                        es.HeureES = DateTime.Now.ToShortTimeString();
                        es.TypeES = "entree";
                        es.MotifS = string.Empty;
                        es.ObservationES = this.txtObsEntree.Text;
                        es.IdUser = this.entreeUtil.IdUtil;
                        es.IdArt = ((ArticleBO)this.cbxArticle.SelectedItem).IdArt;
                        es.DatePeremption = DateTime.Parse(this.dtpperemption.Value.ToShortDateString());
                        es.DelaiAlerte = int.Parse(this.txtDelaiAlerte.Value);

                        if (entreeSortieBLL.Insert(es) != 0)
                        {
                            es.IdES = entreeSortieBLL.GetMaxId();

                            //Actualisation de la quantité de l'article dont une entrée est ajoutée
                            if (articleBLL.UpdateQuantite(es.QteES, es.IdArt) != 0)
                            {
                                AppMessage.Success("L'insertion s'est effectuée avec succès !");
                                this.entreeListe.Add(es);

                                //Actualisation de la quantité dans le gridview
                                if (this.Owner.GetType() == typeof(FormArticle.FormDisplayArticles))
                                {                                    
                                    ((FormArticle.FormDisplayArticles)this.Owner).CurrentArticle.QteStockArt = articleBLL.GetArticleById(((ArticleBO)this.cbxArticle.SelectedItem).IdArt).QteStockArt;
                                    ((FormArticle.FormDisplayArticles)this.Owner).GridArticle.Refresh();
                                }
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
        }
        
        
        private void gridEntree_SelectionChanged(object sender, EventArgs e)
        {
            if (this.gridEntree.RowCount != 0)
            {
                this.entreeES = (EntreeSortieBO)this.gridEntree.CurrentRow.DataBoundItem;

                this.txtQte.Value = this.entreeES.QteES.ToString();
                this.dtpEntree.Value = this.entreeES.DateES;
                this.txtObsEntree.Text = this.entreeES.ObservationES;
                this.dtpperemption.Value = this.entreeES.DatePeremption;
                this.txtDelaiAlerte.Value = this.entreeES.DelaiAlerte.ToString();

                //Récupération de l'utilisateur
                var currUser = from u in utilBLL.GetUsersValide(true)
                               where u.IdUtil == this.entreeES.IdUser
                               select u;

                foreach (var u in currUser)
                {
                    this.txtUser.Text = u.NomUtil + " " + u.PrenomUtil;
                }
            }           
        }

        private void cmdSupprimer_Click(object sender, EventArgs e)
        {
            if (AppMessage.Question("Voulez vous effectuer cette suppression ?") != DialogResult.No)
            {
                EntreeSortieBO delES = this.entreeES;

                if (entreeSortieBLL.Delete(delES) != 0)
                {
                    //Actualisation de la quantité
                    articleBLL.UpdateQuantite((-1)*delES.QteES, delES.IdArt);

                    AppMessage.Success("La suppression s'est effectuée avec succès !");
                    entreeListe.Remove(delES);

                    //Actualisation de la quantité dans le gridview
                    if (this.Owner.GetType() == typeof(FormArticle.FormDisplayArticles))
                    {
                        ((FormArticle.FormDisplayArticles)this.Owner).CurrentArticle.QteStockArt = articleBLL.GetArticleById(((ArticleBO)this.cbxArticle.SelectedItem).IdArt).QteStockArt;
                        ((FormArticle.FormDisplayArticles)this.Owner).GridArticle.Refresh();
                    }
                }
            }
        }

        private void cmdModifierEntree_Click(object sender, EventArgs e)
        {
            if (AppMessage.Question("Voulez vous effectuer cette modification ?") == DialogResult.Yes)
            {
                try
                {
                    EntreeSortieBO oldES = new EntreeSortieBO();

                    oldES.IdES = this.entreeES.IdES;
                    oldES.QteES = int.Parse(this.txtQte.Value);
                    oldES.DateES = this.dtpEntree.Value;
                    oldES.HeureES = DateTime.Now.ToShortTimeString();
                    oldES.TypeES = "entree";
                    oldES.MotifS = string.Empty;
                    oldES.ObservationES = this.txtObsEntree.Text;
                    oldES.IdUser = this.entreeES.IdUser;
                    oldES.IdArt = ((ArticleBO)this.cbxArticle.SelectedItem).IdArt;
                    oldES.DatePeremption = this.dtpperemption.Value;
                    oldES.DelaiAlerte = int.Parse(this.txtDelaiAlerte.Value);

                    if (entreeSortieBLL.Update(oldES) != 0)
                    {
                        //Mise à jour implicite de la quantité de l'article concerné                        
                        int tmp = int.Parse(this.txtQte.Value) - this.entreeES.QteES;

                        if (int.Parse(this.txtQte.Value) > this.entreeES.QteES)
                        {
                            articleBLL.UpdateQuantite(tmp, oldES.IdArt);
                        }

                        if (int.Parse(this.txtQte.Value) < this.entreeES.QteES)
                        {
                            articleBLL.UpdateQuantite(tmp, oldES.IdArt);
                        }

                        AppMessage.Success("La modification s'est effectuée avec succès !");

                        this.entreeES.QteES = int.Parse(this.txtQte.Value);
                        this.entreeES.DateES = this.dtpEntree.Value;
                        this.entreeES.HeureES = DateTime.Now.ToShortTimeString();
                        this.entreeES.TypeES = "entree";
                        this.entreeES.MotifS = string.Empty;
                        this.entreeES.ObservationES = this.txtObsEntree.Text;
                        this.entreeES.IdUser = this.entreeES.IdUser;
                        this.entreeES.DatePeremption = this.dtpperemption.Value;
                        this.entreeES.DelaiAlerte = int.Parse(this.txtDelaiAlerte.Value);
                        this.entreeES.IdArt = ((ArticleBO)this.cbxArticle.SelectedItem).IdArt;

                        this.gridEntree.Refresh();

                        //Actualisation de la quantité dans le gridview
                        if (this.Owner.GetType() == typeof(FormArticle.FormDisplayArticles))
                        {
                            ((FormArticle.FormDisplayArticles)this.Owner).CurrentArticle.QteStockArt = articleBLL.GetArticleById(((ArticleBO)this.cbxArticle.SelectedItem).IdArt).QteStockArt;
                            ((FormArticle.FormDisplayArticles)this.Owner).GridArticle.Refresh();
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

        private void cmdValiderSortie_Click(object sender, EventArgs e)
        {
            if (this.cbxArticleSortie.SelectedItem != null)
            {
                if (AppMessage.Question("Voulez effectuer cette insertion ?") == DialogResult.Yes)
                {
                    try
                    {
                        EntreeSortieBO es = new EntreeSortieBO();

                        es.QteES = int.Parse(this.txtQteSortie.Value);
                        es.DateES = DateTime.Parse(this.dtpSortie.Value.ToShortDateString());
                        es.HeureES = DateTime.Now.ToShortTimeString();
                        es.TypeES = "sortie";
                        es.MotifS = this.cbxMotif.Text;
                        es.ObservationES = this.txtObsSortie.Text;
                        es.IdUser = this.sortieUtil.IdUtil;
                        es.IdArt = ((ArticleBO)this.cbxArticleSortie.SelectedItem).IdArt;

                        if (entreeSortieBLL.Insert(es) != 0)
                        {
                            es.IdES = entreeSortieBLL.GetMaxId();

                            //Actualisation de la quantité de l'article dont une entrée est ajoutée
                            if (articleBLL.UpdateQuantite((-1) * es.QteES, es.IdArt) != 0)
                            {
                                AppMessage.Success("L'insertion s'est effectuée avec succès !");
                                this.sortieListe.Add(es);

                                //Actualisation de la quantité dans le gridview
                                if (this.Owner.GetType() == typeof(FormArticle.FormDisplayArticles))
                                {
                                    ((FormArticle.FormDisplayArticles)this.Owner).CurrentArticle.QteStockArt = articleBLL.GetArticleById(((ArticleBO)this.cbxArticleSortie.SelectedItem).IdArt).QteStockArt;
                                    ((FormArticle.FormDisplayArticles)this.Owner).GridArticle.Refresh();
                                }
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
        }

        private void gridSortie_SelectionChanged(object sender, EventArgs e)
        {
            if (this.gridSortie.RowCount != 0)
            {
                this.sortieES = (EntreeSortieBO)this.gridSortie.CurrentRow.DataBoundItem;

                this.txtQteSortie.Value = this.sortieES.QteES.ToString();
                this.dtpSortie.Value = this.sortieES.DateES;
                this.txtObsSortie.Text = this.sortieES.ObservationES;

                //Récupération de l'utilisateur
                var currUser = from u in utilBLL.GetUsersValide(true)
                               where u.IdUtil == this.sortieES.IdUser
                               select u;

                foreach (var u in currUser)
                {
                    this.txtUserSortie.Text = u.NomUtil + " " + u.PrenomUtil;
                }

                
            }
        }

        private void cmdSupprimerSortie_Click(object sender, EventArgs e)
        {
            if (AppMessage.Question("Voulez vous effectuer cette suppression ?") != DialogResult.No)
            {
                EntreeSortieBO delES = this.sortieES;

                if (entreeSortieBLL.Delete(delES) != 0)
                {
                    //Actualisation de la quantité
                    articleBLL.UpdateQuantite(int.Parse(this.txtQteSortie.Value), delES.IdArt);

                    AppMessage.Success("La suppression s'est effectuée avec succès !");
                    this.sortieListe.Remove(delES);

                    //Actualisation de la quantité dans le gridview
                    if (this.Owner.GetType() == typeof(FormArticle.FormDisplayArticles))
                    {
                        ((FormArticle.FormDisplayArticles)this.Owner).CurrentArticle.QteStockArt = articleBLL.GetArticleById(((ArticleBO)this.cbxArticle.SelectedItem).IdArt).QteStockArt;
                        ((FormArticle.FormDisplayArticles)this.Owner).GridArticle.Refresh();
                    }
                }
            }
        }

        private void cmdModifierSortie_Click(object sender, EventArgs e)
        {
            if (AppMessage.Question("Voulez vous effectuer cette modification ?") == DialogResult.Yes)
            {
                try
                {
                    EntreeSortieBO oldES = new EntreeSortieBO();

                    oldES.IdES = this.sortieES.IdES;
                    oldES.QteES = int.Parse(this.txtQteSortie.Value);
                    oldES.DateES = this.dtpSortie.Value;
                    oldES.HeureES = DateTime.Now.ToShortTimeString();
                    oldES.TypeES = "sortie";
                    oldES.MotifS = this.cbxMotif.Text;
                    oldES.ObservationES = this.txtObsSortie.Text;
                    oldES.IdUser = this.sortieES.IdUser;
                    oldES.IdArt = ((ArticleBO)this.cbxArticleSortie.SelectedItem).IdArt;

                    if (entreeSortieBLL.Update(oldES) != 0)
                    {
                        //Mise à jour implicite de la quantité de l'article concerné                        
                        int tmp = int.Parse(this.txtQteSortie.Value) - this.sortieES.QteES;

                        if (int.Parse(this.txtQteSortie.Value) > this.sortieES.QteES)
                        {
                            articleBLL.UpdateQuantite((-1)*tmp, oldES.IdArt);
                        }

                        if (int.Parse(this.txtQteSortie.Value) < this.sortieES.QteES)
                        {
                            articleBLL.UpdateQuantite((-1)*tmp, oldES.IdArt);
                        }

                        this.sortieES.QteES = int.Parse(this.txtQteSortie.Value);
                        this.sortieES.DateES = this.dtpSortie.Value;
                        this.sortieES.HeureES = DateTime.Now.ToShortTimeString();
                        this.sortieES.TypeES = "sortie";
                        this.sortieES.MotifS = this.cbxMotif.Text;
                        this.sortieES.ObservationES = this.txtObsSortie.Text;
                        this.sortieES.IdUser = this.sortieES.IdUser;
                        this.sortieES.IdArt = ((ArticleBO)this.cbxArticleSortie.SelectedItem).IdArt;

                        this.gridSortie.Refresh();

                        AppMessage.Success("La modification s'est effectuée avec succès !");

                        //Actualisation de la quantité dans le gridview
                        if (this.Owner.GetType() == typeof(FormArticle.FormDisplayArticles))
                        {
                            ((FormArticle.FormDisplayArticles)this.Owner).CurrentArticle.QteStockArt = articleBLL.GetArticleById(((ArticleBO)this.cbxArticleSortie.SelectedItem).IdArt).QteStockArt;
                            ((FormArticle.FormDisplayArticles)this.Owner).GridArticle.Refresh();
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

        private void cbxArticle_SelectedValueChanged(object sender, EventArgs e)
        {

            if (this.cbxArticle.Items.Count != 0)
            {
                //On affiche la liste des entrées/sorties associées à l'article
                int idArt = ((ArticleBO)this.cbxArticle.SelectedItem).IdArt; 
                this.entreeListe = entreeSortieBLL.GetEntreeSortieByArticleId(idArt, "entree", string.Empty);
                this.entreeSortieBOBindingSource.DataSource = this.entreeListe;
                this.gridEntree.DataSource = this.entreeSortieBOBindingSource; 
            }

            if (this.gridEntree.RowCount == 0)
            {
                this.txtQte.Value = "0";
                this.txtObsEntree.Text = string.Empty;
            }
           
        }

        private void cbxArticleSortie_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.cbxArticleSortie.Items.Count != 0)
            {
                //On affiche la liste des entrées/sorties associées à l'article
                int idArt = ((ArticleBO)this.cbxArticleSortie.SelectedItem).IdArt;
                this.sortieListe = entreeSortieBLL.GetEntreeSortieByArticleId(idArt, "sortie", "vente");

                this.entreeSortieBOBindingSource1.DataSource = this.sortieListe;

                this.gridSortie.DataSource = this.entreeSortieBOBindingSource1;
            }

            if (this.gridSortie.RowCount == 0)
            {
                this.txtQteSortie.Value = "0";
                this.txtObsSortie.Text = string.Empty;
            }
        }

        private void txtNouveauSortie_Click(object sender, EventArgs e)
        {
            FormArticle.FormNewEditArticle formNewArticle = new App.EasyShop.FormArticle.FormNewEditArticle();
            formNewArticle.Owner = this;
            formNewArticle.ShowDialog();


            //Remplissage des sorties
            this.cbxArticleSortie.DataSource = articleBLL.GetArticles(string.Empty);
            this.cbxArticleSortie.ValueMember = "IdArt";
            this.cbxArticleSortie.DisplayMember = "LibelleArt";

            if (this.InsertedArticle != string.Empty)
            {
                this.cbxArticleSortie.Text = this.InsertedArticle;
                int idArt = ((ArticleBO)this.cbxArticleSortie.SelectedItem).IdArt;
                this.sortieListe = entreeSortieBLL.GetEntreeSortieByArticleId(idArt, "sortie", string.Empty);
                this.entreeSortieBOBindingSource1.DataSource = this.sortieListe;
                this.gridSortie.DataSource = this.entreeSortieBOBindingSource1;
            }

            //Remplissage des entrees
            this.cbxArticle.DataSource = articleBLL.GetArticles(string.Empty);
            this.cbxArticle.ValueMember = "IdArt";
            this.cbxArticle.DisplayMember = "LibelleArt";

            if (this.InsertedArticle != string.Empty)
            {
                this.cbxArticle.Text = this.InsertedArticle;
                int idArt = ((ArticleBO)this.cbxArticle.SelectedItem).IdArt;
                this.entreeListe = entreeSortieBLL.GetEntreeSortieByArticleId(idArt, "entree", string.Empty);
                this.entreeSortieBOBindingSource.DataSource = this.entreeListe;
                this.gridEntree.DataSource = this.entreeSortieBOBindingSource;
            }
        }

        private void txtQte_TextChanged(object sender, EventArgs e)
        {

        }        

        private void InitComboBox()
        {
            if (this.Owner.GetType() == typeof(FormMain))
            {               
                //On affiche les entrée/sorties de tous les articles
                this.cbxArticle.DataSource = articleBLL.GetArticles(string.Empty);
                this.cbxArticle.ValueMember = "IdArt";
                this.cbxArticle.DisplayMember = "LibelleArt";               

                //On affiche les entrée/sorties de tous les articles
                this.cbxArticleSortie.DataSource = articleBLL.GetArticles(string.Empty);
                this.cbxArticleSortie.ValueMember = "IdArt";
                this.cbxArticleSortie.DisplayMember = "LibelleArt";
            }

            if (this.Owner.GetType() == typeof(FormArticle.FormDisplayArticles))
            {
                //On affiche les entrée/sorties de tous les articles
                this.cbxArticle.DataSource = articleBLL.GetArticles(((FormArticle.FormDisplayArticles)this.Owner).CurrentArticle.LibelleArt);
                this.cbxArticle.ValueMember = "IdArt";
                this.cbxArticle.DisplayMember = "LibelleArt";

                this.cbxArticle.Enabled = false;
                this.cmdNouveau.Enabled = false;

                //On affiche les entrée/sorties de tous les articles
                this.cbxArticleSortie.DataSource = articleBLL.GetArticles(((FormArticle.FormDisplayArticles)this.Owner).CurrentArticle.LibelleArt);
                this.cbxArticleSortie.ValueMember = "IdArt";
                this.cbxArticleSortie.DisplayMember = "LibelleArt";

                this.cbxArticleSortie.Enabled = false;
                this.cmdNouveauSortie.Enabled = false;
            }
        }

        private void InitCurrentUser()
        {
            //Affectation des utilisateurs
            if (this.Owner.GetType() == typeof(FormMain))
            {
                this.entreeUtil = ((FormMain)this.Owner).CurrentUtil;
                this.sortieUtil = ((FormMain)this.Owner).CurrentUtil;
            }
            else
            {
                this.entreeUtil = ((FormMain)((FormArticle.FormDisplayArticles)this.Owner).Owner).CurrentUtil;
                this.sortieUtil = ((FormMain)((FormArticle.FormDisplayArticles)this.Owner).Owner).CurrentUtil;
            }
        }

        private void InitLocalVariables()
        {
            this.entreeUtil = new UtilBO();
            this.sortieUtil = new UtilBO();

            this.entreeES = new EntreeSortieBO();
            this.sortieES = new EntreeSortieBO();

            this.entreeListe = new EntreeSortieBOListView();
            this.sortieListe = new EntreeSortieBOListView();

        }

        private void InitGridview()
        {
            //On affiche la liste des entrées/sorties associées à l'article       
            if (this.cbxArticle.Items.Count != 0)
            {
                this.entreeListe = entreeSortieBLL.GetEntreeSortieByArticleId(((ArticleBO)this.cbxArticle.SelectedItem).IdArt, "entree", string.Empty);

                this.entreeSortieBOBindingSource.DataSource = this.entreeListe;

                this.gridEntree.DataSource = this.entreeSortieBOBindingSource;
            }            
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void gridEntree_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InitGridviewSortie()
        {
            //On affiche la liste des entrées/sorties associées à l'article     
            if (this.cbxArticleSortie.Items.Count != 0)
            {
                this.sortieListe = entreeSortieBLL.GetEntreeSortieByArticleId(((ArticleBO)this.cbxArticleSortie.SelectedItem).IdArt, "sortie", "vente");

                this.entreeSortieBOBindingSource1.DataSource = this.sortieListe;

                this.gridSortie.DataSource = this.entreeSortieBOBindingSource1;
                //this.gridSortie.Columns[0].Visible = false;
            }            
        }

        private void tabEntreeSortie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabEntreeSortie.SelectedIndex == 1)
            {
                this.InitGridviewSortie();                
                this.cbxMotif.DataSource = Enum.GetValues(typeof(Motifs));
            }
        }

        private void entreeSortieBOBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
