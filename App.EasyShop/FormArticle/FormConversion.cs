using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using App.BusinessObject;

namespace App.EasyShop.FormArticle
{
    public partial class FormConversion : Form
    {
        private ArticleBO article = new ArticleBO();

        public ArticleBO Article
        {
            get { return article; }
            set { article = value; }
        }

        public FormConversion()
        {
            InitializeComponent();
        }

        private void FormConversion_Load(object sender, EventArgs e)
        {
            StringBuilder sbuilder = new StringBuilder();
            sbuilder.Append("Prix achat = " + (article.PrixAchatArt / 656).ToString() + " Euros");
            sbuilder.Append(", Prix en detail = " + (article.PrixVenteArt / 656).ToString() + " Euros");
            sbuilder.Append(", Prix en demi gros = " + (article.PrixEnDemiGros / 656).ToString() + " Euros");
            sbuilder.Append(", Prix en gros = " + (article.PrixEnGros / 656).ToString() + " Euros");            
            this.txtArticle.Text = article.LibelleArt;
            this.txtConversion.Text = sbuilder.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmdFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
