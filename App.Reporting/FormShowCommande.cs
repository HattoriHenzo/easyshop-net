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
    public partial class FormShowCommande : Form
    {
        private int idCom;

        public int IdCom
        {
            get { return idCom; }
            set { idCom = value; }
        }
        
        public FormShowCommande()
        {
            InitializeComponent();
        }

        private void FormShowCommande_Load(object sender, EventArgs e)
        {
            this.reportDetailsCommandes.LocalReport.ReportEmbeddedResource = "App.Reporting.ReportDetailCommande.rdlc";

            DbConnection conn = AppConnection.Instance.GetConnection();

            try
            {
                conn.Open();

                DbCommand com = conn.CreateCommand();
                com.CommandType = CommandType.Text;
                com.CommandText = "SELECT Article.LibelleArt AS Designation, QteCom AS Quantite, PrixCom AS PrixAchat, (QteCom * PrixCom) AS Total " +
                    "FROM Article " +
                    "INNER JOIN Commander ON Article.IdArt = Commander.IdArt WHERE IdCom = @IdCom";

                DbParameter dbParam = com.CreateParameter();
                dbParam.ParameterName = "@IdCom";
                dbParam.Value = this.idCom;
                com.Parameters.Add(dbParam);

                DbDataReader reader = com.ExecuteReader();

                DataSetCommande.DetailsCommandeDataTable detailCommande = new DataSetCommande.DetailsCommandeDataTable();

                detailCommande.Load(reader);

                //RÃ©cupÃ©ration de la date d'inventaire
                DbCommand com2 = conn.CreateCommand();
                com2.CommandType = CommandType.Text;
                com2.CommandText = "Select Commande.NumComText as Numero, Commande.DateCom as DateCommande From Commande Where Commande.IdCom = @IdCom";

                DbParameter dbParam2 = com.CreateParameter();
                dbParam2.ParameterName = "@IdCom";
                dbParam2.Value = this.idCom;
                com2.Parameters.Add(dbParam2);

                DbDataReader reader2 = com2.ExecuteReader();

                DataSetCommande.CommandeDataTable commande = new DataSetCommande.CommandeDataTable();
                commande.Load(reader2);                

                conn.Close();
                reader.Close();
                reader2.Close();

                //Prepare the report datasource
                ReportDataSource rptDS = new ReportDataSource();
                rptDS.Name = "DataSetCommande_DetailsCommande";
                rptDS.Value = detailCommande;

                //Prepare the report datasource
                ReportDataSource rptDS2 = new ReportDataSource();
                rptDS2.Name = "DataSetCommande_Commande";
                rptDS2.Value = commande;

                reportDetailsCommandes.LocalReport.DataSources.Add(rptDS);
                reportDetailsCommandes.LocalReport.DataSources.Add(rptDS2);
                //Load the report viewer
                //you need to set this to show multi column output in report viewer
                reportDetailsCommandes.SetDisplayMode(DisplayMode.PrintLayout);
                // set the zoom mode of report viewer to 100%
                reportDetailsCommandes.ZoomMode = ZoomMode.Percent;
                reportDetailsCommandes.ZoomPercent = 100;

                this.reportDetailsCommandes.RefreshReport();
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
