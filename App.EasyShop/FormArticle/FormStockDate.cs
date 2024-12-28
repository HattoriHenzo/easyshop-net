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
    public partial class FormStockDate : Form
    {
        private StockDateBOListView listArticle = null;
        private StockDateBLL stockDateBLL;
        private ArticleBLL articleBLL;

        public FormStockDate()
        {
            stockDateBLL = new StockDateBLL();
            articleBLL = new ArticleBLL();
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmdQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            //Initialisation de l'affichage
            this.listArticle = stockDateBLL.GetStockDateByPeriod(DateTime.Parse(dtpDateDu.Value.ToShortDateString()), DateTime.Parse(dtpDateAu.Value.ToShortDateString()), this.txtArticle.Text);
            this.stockDateBOBindingSource.DataSource = this.listArticle;
            this.gridStockDate.DataSource = this.stockDateBOBindingSource;
            //Affichage de la period de stock
            this.txtPeriodStock.Text = this.dtpDateDu.Value.ToShortDateString() + " au " + this.dtpDateAu.Value.ToShortDateString();
            //Affichage du nombre d'articles
            this.txtNombreArticle.Text = this.gridStockDate.RowCount.ToString();
        }

        private void cmdActualiserStock_Click(object sender, EventArgs e)
        {
            if(AppMessage.Question("Voulez vous actualiser le stock a date ?") == DialogResult.Yes)
            {
                // On actualise le stock ave la date en cours
                if (stockDateBLL.Delete(DateTime.Parse(DateTime.Today.ToShortDateString())) >= 0)
                {
                    if (stockDateBLL.Insert() >= 0)
                    {
                        AppMessage.Success("Le stock de la date du jour a été actualisé !");
                    }
                }
            }            
        }

        private void gridStockDate_SelectionChanged(object sender, EventArgs e)
        {
            if(this.gridStockDate.RowCount != 0) 
            {
                StockDateBO currentSD = (StockDateBO)this.gridStockDate.CurrentRow.DataBoundItem;
                this.txtDetailsDateStock.Text = currentSD.LibelleArt + ", " + currentSD.QteStockArt.ToString() + " en stock le " +
                                                currentSD.DateStock.ToShortDateString();
                this.txtStockActuel.Text = articleBLL.GetArticleById(currentSD.IdArt).QteStockArt.ToString();
            }
        }        
    }
}
