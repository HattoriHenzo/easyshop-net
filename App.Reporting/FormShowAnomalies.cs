using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using Microsoft.Reporting.WebForms;
using Microsoft.Reporting.WinForms;

using App.Tools;
using System.Data.Common;
using App.DataAccess;

namespace App.Reporting
{
    public partial class FormShowAnomalies : Form
    {
        private int _dateInv;

        public int DateInv
        {
            get { return _dateInv; }
            set { _dateInv = value;}
        }

        public FormShowAnomalies()
        {
            InitializeComponent();
        }

        private void FormShowAnomalies_Load(object sender, EventArgs e)
        {
            //Provide local report information to local viewer
            this.reportAnomalies.LocalReport.ReportEmbeddedResource = "App.Reporting.ReportAnomalieInventaire.rdlc";

            DbConnection conn = AppConnection.Instance.GetConnection();

            try
            {
                conn.Open();

                DbCommand com = conn.CreateCommand();

                com.CommandType = CommandType.Text;
                com.CommandText = "SELECT Article.LibelleArt AS Designation, Inventaire.QteStockInv AS QteEnStock, Inventaire.QtePhysInv AS QteComptee, (Inventaire.QtePhysInv - Inventaire.QteStockInv) as Ecart From Article, Inventaire Where Article.IdArt = Inventaire.IdArt And Inventaire.IdDateInv = @IdDateInv";
                DbParameter dbParam = com.CreateParameter();
                dbParam.ParameterName = "@IdDateInv";
                dbParam.Value = this._dateInv;
                com.Parameters.Add(dbParam);

                DbDataReader reader = com.ExecuteReader();

                DataSetAnomalies.AnomaliesInventaireDataTable anomalieInventaire = new DataSetAnomalies.AnomaliesInventaireDataTable();

                anomalieInventaire.Load(reader);

                //Récupération de la date d'inventaire
                DbCommand com2 = conn.CreateCommand();
                com2.CommandType = CommandType.Text;
                com2.CommandText = "Select DateInv as DateInv From DateInventaire Where DateInventaire.IdDateInv = @IdDateInv";
                DbParameter dbParam2 = com2.CreateParameter();
                dbParam2.ParameterName = "@IdDateInv";
                dbParam2.Value = this._dateInv;

                DbDataReader reader2 = com2.ExecuteReader();

                DataSetAnomalies.DateInventaireDataTable dateInv = new DataSetAnomalies.DateInventaireDataTable();
                dateInv.Load(reader2);

                conn.Close();
                reader.Close();
                reader2.Close();

                //Prepare the report datasource
                ReportDataSource rptDS = new ReportDataSource();
                rptDS.Name = "DataSetAnomalies_AnomaliesInventaire";
                rptDS.Value = anomalieInventaire;

                //Prepare the report datasource
                ReportDataSource rptDS2 = new ReportDataSource();
                rptDS2.Name = "DataSetAnomalies_DateInventaire";
                rptDS2.Value = dateInv;

                reportAnomalies.LocalReport.DataSources.Add(rptDS);
                reportAnomalies.LocalReport.DataSources.Add(rptDS2);
                //Load the report viewer
                //you need to set this to show multi column output in report viewer
                reportAnomalies.SetDisplayMode(DisplayMode.PrintLayout);
                // set the zoom mode of report viewer to 100%
                reportAnomalies.ZoomMode = ZoomMode.Percent;
                reportAnomalies.ZoomPercent = 100;

                this.reportAnomalies.RefreshReport();
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
