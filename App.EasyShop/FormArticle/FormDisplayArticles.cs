using System;
using System.Drawing;
using System.Windows.Forms;

using App.Reporting;
using App.BusinessObject;
using App.BusinessLogic;
using App.Tools;

namespace App.EasyShop.FormArticle
{
    public partial class FormDisplayArticles : Form
    {
        private CategorieBLL categorieBLL;
        private ArticleBLL articleBLL;
        private EntreeSortieBLL entreeSortieBLL;

        public string InsertedArticle
        {
            get;
            set;
        }

        EntreeSortieBOListView entreeListe = null;

        //Objet de type AricleBO
        private ArticleBO currentArticle = null;

        public ArticleBO CurrentArticle
        {
            get { return currentArticle; }
            set { currentArticle = value; }
        }

        //Objet de type ArticleBOListView
        private ArticleBOListView listArticle = null;
        //Objet de type ArticleBOListView pour filtrage
        private ArticleBOListView listArticleFiltre = null;

        public ArticleBOListView ListArticle
        {
            get { return listArticle; }
            set { listArticle = value; }
        }

        public FormDisplayArticles()
        {
            categorieBLL = new CategorieBLL();
            articleBLL = new ArticleBLL();
            entreeSortieBLL = new EntreeSortieBLL();
            InitializeComponent();
        }               
        public DataGridView GridArticle
        {
            get { return this.gridArticle; }
            set { this.gridArticle = value; }
        }

        private void cmdNouveau_Click(object sender, EventArgs e)
        {
            /*
            // On limite le nombre d'articles à 10 pour la version DEMO
            if (ArticleBLL.Instance.GetArticles(String.Empty).Count == 10)
            {
                AppMessage.Warning("Le nombre d'articles est limité à 10 pour la version Démo. \nPour la version complète, contacter Easy-Tech au 93 88 68 18/98 84 60 60."
                     + " \nMerci pour la confiance que vous nous accordez.");
                return;
            }*/

            FormNewEditArticle formNewArticle = new FormNewEditArticle();
            formNewArticle.Owner = this;
            formNewArticle.ShowDialog();                 

            //Affichage du nombre d'articles
            this.txtNombreArticle.Text = this.gridArticle.RowCount.ToString();
        }

        private void cmdRecherche_Click(object sender, EventArgs e)
        {
            this.SearchArticles(this.txtRecherche.Text,cbxoptions.Text);
        }       

        private void cmdQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDisplayArticles_Load(object sender, EventArgs e)
        {
            this.currentArticle = new ArticleBO();

            this.listArticle = new ArticleBOListView();

            //Initialisation du combobox
            this.cbxCategorie.DataSource = categorieBLL.GetCategories();
            this.cbxCategorie.ValueMember = "IdCat";
            this.cbxCategorie.DisplayMember = "LibelleCat";

            //Affichage du nombre d'articles
            this.txtNombreArticle.Text = "0";

            //Réaffichage de l'interface
            if (((FormMain)this.Owner).CurrentUtil.TypeUtil == 2)
            {
                //this.DisableButtons();
                this.contextMenuStrip.Enabled = false;
                //On cache la colonne affichant le prix d'achat de l'article
                this.gridArticle.Columns[2].Visible = false;
            }
            else
            {
                //this.EnableButtons();
                this.contextMenuStrip.Enabled = true;
                this.gridArticle.Columns[2].Visible = true;
            }
            
        }

        private void gridArticle_SelectionChanged(object sender, EventArgs e)
        {
            if (this.gridArticle.RowCount != 0)
            {
                this.currentArticle = (ArticleBO)this.gridArticle.CurrentRow.DataBoundItem;

                int artEtat = articleBLL.IsAvailable(this.currentArticle.IdArt);

                switch (artEtat)
                {
                    //Cas ou l'article est disponible en stock
                    case 1:

                        this.txtEtatArticle.BackColor = Color.GreenYellow;
                        this.txtEtatArticle.Text = "Article disponible";

                    break;

                    //Cas ou l'article est en dessa du seuil
                    case 2:

                        this.txtEtatArticle.BackColor = Color.Orange;
                        this.txtEtatArticle.Text = "Article en dessous du seuil";

                    break;

                    //Cas ou l'article en rupture de stock
                    case 3:

                        this.txtEtatArticle.BackColor = Color.Red;
                        this.txtEtatArticle.Text = "Article non disponible";

                    break;
                }
            }

            txtperemption.Text = "";
            this.txtperemption.BackColor = Color.White;
                if (this.etatPeremptionArticle(this.currentArticle.IdArt))
                {
                    this.txtperemption.BackColor = Color.Red;
                    txtperemption.Text = "En cours de peremption";
                } 
        }

        private Boolean etatPeremptionArticle(int idArt)
        {
            Boolean etatPeremption;
            etatPeremption = false;
            this.entreeListe = entreeSortieBLL.GetEntreeSortieByArticleId(idArt, "entree", string.Empty);
            foreach (EntreeSortieBO es in this.entreeListe)
            {
                if (entreeSortieBLL.EstPerime(es.IdES, es.IdArt, Convert.ToDateTime(es.DateES), Convert.ToDateTime(DateTime.Now)))
                {
                    etatPeremption = true; 
                }
            }
            return etatPeremption;
        }

        private void cmdModifier_Click(object sender, EventArgs e)
        {
            if (this.gridArticle.RowCount != 0)
            {
                FormArticle.FormNewEditArticle formArticle = new FormNewEditArticle();
                formArticle.Owner = this;
                formArticle.EditMode = true;
                formArticle.ShowDialog();                
            }
        }

        private void cmdSupprimer_Click(object sender, EventArgs e)
        {
            // On effectue la suppression de l'article
            if (this.gridArticle.RowCount != 0)
            {
                if (AppMessage.Question("Voulez vous supprimer l'article " + currentArticle.LibelleArt + " ?") == DialogResult.Yes)
                {
                    articleBLL.Delete(currentArticle.IdArt);
                }
            }
        }

        private void cmdSorties_Click(object sender, EventArgs e)
        {
            this.ShowEntreeSortie();
        }               

        private void cmdRechByCategorie_Click(object sender, EventArgs e)
        {
            if (this.cbxCategorie.SelectedItem != null)
            {
                //Initialisation de l'affichage
                ArticleBO tmpArt = new ArticleBO();
                tmpArt.Categorie = (CategorieBO)this.cbxCategorie.SelectedItem;
                this.listArticle = articleBLL.GetArticlesByCategorieId(tmpArt);

                this.articleBOBindingSource.DataSource = this.listArticle;

                this.gridArticle.DataSource = this.articleBOBindingSource;

                //Affichage du nombre d'articles
                this.txtNombreArticle.Text = this.gridArticle.RowCount.ToString();
            }            
        }

        private void cmdImprimer_Click(object sender, EventArgs e)
        {
            if (this.gridArticle.RowCount > 0)
            {
                if (AppMessage.Question("Voulez vous imprimer la liste des articles !") == DialogResult.Yes)
                {
                    FormShowArticle article = new FormShowArticle();
                    article.Owner = this;
                    article.ShowDialog();
                }
            }
        }

        private void gridArticle_DoubleClick(object sender, EventArgs e)
        {
            if ((this.gridArticle.RowCount != 0) && (((FormMain)this.Owner).CurrentUtil.TypeUtil != 2))
            {
                FormArticle.FormNewEditArticle formEditArticle = new FormNewEditArticle();
                formEditArticle.Owner = this;
                formEditArticle.EditMode = true;
                formEditArticle.ShowDialog();
            }
          
        }

        private void nouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Ajout d'un nouvel article
            FormNewEditArticle formNewArticle = new FormNewEditArticle();
            formNewArticle.Owner = this;
            formNewArticle.ShowDialog();

            //Affichage du nombre d'articles
            this.txtNombreArticle.Text = this.gridArticle.RowCount.ToString();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Modification d'un article
            if (this.gridArticle.RowCount != 0)
            {
                FormArticle.FormNewEditArticle formEditArticle = new FormNewEditArticle();
                formEditArticle.Owner = this;
                formEditArticle.ShowDialog();
            }
        }

        private void EnableButtons()
        {
            this.cmdNouveau.Enabled = true;
            this.cmdModifier.Enabled = true;            
            this.cmdSorties.Enabled = true;
            this.cmdImprimer.Enabled = true;
        }

        private void DisableButtons()
        {
            this.cmdNouveau.Enabled = false;
            this.cmdModifier.Enabled = false;
            this.cmdSupprimer.Enabled = false;
            this.cmdSorties.Enabled = false;
            this.cmdImprimer.Enabled = false;
        }

        public void SearchArticles(string article, String options)
        {
            //Initialisation de l'affichage
            this.listArticle = articleBLL.GetArticles(article);
            // filtrer la liste par etat peremption
            this.listArticleFiltre = articleBLL.GetArticles(article);
            if (options.ToLower().Contains("peremption"))
            {
                this.listArticle.Clear();
                foreach (ArticleBO art in this.listArticleFiltre)
                {
                    if (this.etatPeremptionArticle(art.IdArt))
                    {
                        this.listArticle.Add(art);
                    }

                }
            }

            this.articleBOBindingSource.DataSource = this.listArticle;

            this.gridArticle.DataSource = this.articleBOBindingSource;

            //Affichage du nombre d'articles
            this.txtNombreArticle.Text = this.gridArticle.RowCount.ToString();
        }

        private void entréesSortiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowEntreeSortie();
        }

        private void ShowEntreeSortie()
        {
            if (this.gridArticle.RowCount != 0)
            {
                FormEntreesSorties.FormEntreeSortie formES = new App.EasyShop.FormEntreesSorties.FormEntreeSortie();
                formES.Owner = this;
                formES.ShowDialog();
            }
        }

        private void cmdConversion_Click(object sender, EventArgs e)
        {
            if(this.gridArticle.RowCount > 0)
            {
                FormConversion form = new FormConversion();
                form.Article = this.currentArticle;
                form.ShowDialog();
            }            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
