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

namespace App.EasyShop.FormVente
{
    public partial class FormRechArticle : Form
    {
        private ArticleBOListView listeArticle = null;

        private ArticleBLL articleBLL;

        public FormRechArticle()
        {
            articleBLL = new ArticleBLL();
            InitializeComponent();
        }

        private void cmdFermer_Click(object sender, EventArgs e)
        {
            //Fermeture du formulaire
            this.Close();
        }

        private void FormRechArticle_Load(object sender, EventArgs e)
        {
            this.listeArticle = new ArticleBOListView();
        }

        private void cmdRecherche_Click(object sender, EventArgs e)
        {
            //On rempli la liste
            this.listeArticle = articleBLL.GetArticles(this.txtRecherche.Text);
            this.articleBOBindingSource.DataSource = this.listeArticle;
            this.gridArticle.DataSource = this.articleBOBindingSource;
        }

        private void cmdSelect_Click(object sender, EventArgs e)
        {
            if (this.gridArticle.RowCount != 0)
            {
                ((FormVente.FormVentes)this.Owner).ArticleSelected = ((ArticleBO)this.gridArticle.CurrentRow.DataBoundItem).LibelleArt;
                this.Close();
            }
            else
            {
                AppMessage.Error("Veuillez effectuer une recherche avant de faire la sélection !");
            }
        }

        private void gridArticle_DoubleClick(object sender, EventArgs e)
        {
            if (this.gridArticle.RowCount != 0)
            {
                ((FormVente.FormVentes)this.Owner).ArticleSelected = ((ArticleBO)this.gridArticle.CurrentRow.DataBoundItem).LibelleArt;
                this.Close();
            }
            else
            {
                AppMessage.Error("Veuillez effectuer une recherche avant de faire la sélection !");
            }
        }
    }
}
