using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

using App.Tools;
using System.Data.Common;
using App.DataAccess;

namespace App.Reporting
{
    public partial class FormReport : Form
    {
        private int dateValeurStock;

        public int DateValeurStock
        {
            get { return dateValeurStock; }
            set { dateValeurStock = value; }
        }

        public FormReport()
        {
            InitializeComponent();
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            //Provide local report information to local viewer
            this.reportValeurStock.LocalReport.ReportEmbeddedResource = "App.Reporting.ReportValeurStock.rdlc";

            DbConnection conn = AppConnection.Instance.GetConnection();

            try
            {
                conn.Open();

                DbCommand com = conn.CreateCommand();

                com.CommandType = CommandType.Text;
                com.CommandText = "SELECT Article.LibelleArt AS Designation, Inventaire.QteStockInv AS QteStock, Inventaire.QtePhysInv AS QteComptee, Article.CoutSortie, (Inventaire.QtePhysInv*Article.CoutSortie) AS ValeurStock, DateInventaire.DateHeureInv " +
                    "FROM DateInventaire " +
                    "INNER JOIN (Article INNER JOIN Inventaire ON Article.IdArt = Inventaire.IdArt) ON DateInventaire.IdDateInv = Inventaire.IdDateInv " +
                    "WHERE (((Inventaire.IdDateInv)=@IdDateInv))";
                DbParameter dbParam = com.CreateParameter();
                dbParam.ParameterName = "@IdDateInv";
                dbParam.Value = dateValeurStock;
                com.Parameters.Add(dbParam);

                DbDataReader reader = com.ExecuteReader();

                DataSetValeurStock.ArticleValeurStockDataTable articleValeurStockTable = new DataSetValeurStock.ArticleValeurStockDataTable();

                articleValeurStockTable.Load(reader);

                //Récupération de la date d'inventaire
                DbCommand com2 = conn.CreateCommand();
                com2.CommandType = CommandType.Text;
                com2.CommandText = "SELECT DateHeureInv as DateInv FROM DateInventaire WHERE DateInventaire.IdDateInv = @IdDateInv";
                DbParameter dbParam2 = com2.CreateParameter();
                dbParam2.ParameterName = "@IdDateInv";
                dbParam2.Value = dateValeurStock;
                com2.Parameters.Add(dbParam2);

                DbDataReader reader2 = com2.ExecuteReader();

                DataSetValeurStock.DateInventaireDataTable dateInv = new DataSetValeurStock.DateInventaireDataTable();
                dateInv.Load(reader2);

                conn.Close();
                reader.Close();
                reader2.Close();

                //Prepare the report datasource
                ReportDataSource rptDS = new ReportDataSource();
                rptDS.Name = "DataSetValeurStock_ArticleValeurStock";
                rptDS.Value = articleValeurStockTable;

                //Prepare the report datasource
                ReportDataSource rptDS2 = new ReportDataSource();
                rptDS2.Name = "DataSetValeurStock_DateInventaire";
                rptDS2.Value = dateInv;

                reportValeurStock.LocalReport.DataSources.Add(rptDS);
                reportValeurStock.LocalReport.DataSources.Add(rptDS2);
                //Load the report viewer
                //you need to set this to show multi column output in report viewer
                reportValeurStock.SetDisplayMode(DisplayMode.PrintLayout);
                // set the zoom mode of report viewer to 100%
                reportValeurStock.ZoomMode = ZoomMode.Percent;
                reportValeurStock.ZoomPercent = 100;               

                this.reportValeurStock.RefreshReport();
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
