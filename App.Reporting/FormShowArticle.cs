using Microsoft.Reporting.WebForms;
using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

using App.Tools;
using System.Data.Common;

namespace App.Reporting
{
    public partial class FormShowArticle : Form
    {
        public FormShowArticle()
        {
            InitializeComponent();
        }

        private void FormShowArticle_Load(object sender, EventArgs e)
        {
            this.reportArticle.LocalReport.ReportEmbeddedResource = "App.Reporting.ReportArticle.rdlc";

            OleDbConnection conn = new OleDbConnection();

            conn.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Jet OLEDB:Database Password = adminadmin; Data Source = App.EasyShopDB.accdb";

            try
            {
                conn.Open();

                DbCommand com = conn.CreateCommand();

                com.CommandType = CommandType.Text;
                com.CommandText = "SELECT Article.LibelleArt AS Designation, Article.PrixAchatArt AS PrixAchat, Article.PrixVenteArt AS PrixVente, Article.CoutSortie AS CoutSortie, Article.SeuilArt AS Seuil, Article.QteStockArt AS Quantite, Categorie.LibelleCat AS Categorie " +
                    "FROM (Article INNER JOIN Categorie ON Article.IdCat = Categorie.IdCat) ORDER BY Article.LibelleArt";

                DbDataReader reader = com.ExecuteReader();

                DataSetArticle.ArticleDataTable article = new DataSetArticle.ArticleDataTable();

                article.Load(reader);               

                conn.Close();
                reader.Close();

                //Prepare the report datasource
                ReportDataSource rptDS = new ReportDataSource();
                rptDS.Name = "DataSetArticle_Article";
                rptDS.Value = article;                

                reportArticle.LocalReport.DataSources.Add(rptDS);              
                //Load the report viewer
                //you need to set this to show multi column output in report viewer
                reportArticle.SetDisplayMode(DisplayMode.PrintLayout);               
                // set the zoom mode of report viewer to 100%
                reportArticle.ZoomMode = ZoomMode.Percent;
                reportArticle.ZoomPercent = 100;

                this.reportArticle.RefreshReport();
            }
            catch (Exception ex)
            {
                AppMessage.Error(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }                   
        }
    }
}
