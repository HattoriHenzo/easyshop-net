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
using System.Drawing.Printing;
using System.Data.Common;
using App.DataAccess;

namespace App.Reporting
{
    public partial class FormShowFacture : Form
    {
        private string numeroFacture = "";

        public string NumeroFacture
        {
            get { return numeroFacture; }
            set { numeroFacture = value; }
        }

        private string typeFacture;

        public string TypeFacture
        {
            get { return typeFacture; }
            set { typeFacture = value; }
        }

        private DateTime dateDu = new DateTime();

        public DateTime DateDu
        {
            get { return dateDu; }
            set { dateDu = value; }
        }

        private DateTime dateAu = new DateTime();

        public DateTime DateAu
        {
            get { return dateAu; }
            set { dateAu = value; }
        }



        public FormShowFacture()
        {
            InitializeComponent();
        }

        private void FormShowFacture_Load(object sender, EventArgs e)
        {            
            this.reportFacture.LocalReport.ReportEmbeddedResource = "App.Reporting.ReportFacture.rdlc";

            DbConnection conn = AppConnection.Instance.GetConnection();

            try
            {
                conn.Open();                

                DbCommand comVente = conn.CreateCommand();
                String query = String.Empty;
                               
                // Detail des ventes
                DbCommand comArchiveVente = conn.CreateCommand();
                String queryDetails = String.Empty;

                // On verifie le type d'impression a effectuer                
                if (typeFacture.Equals("facture"))
                {
                    query = "SELECT NumeroVente as NumeroFacture, DateVente as DateFacture " +
                        "FROM Vente " +
                        "WHERE NumeroVente = @NumeroVente";
                    comVente.Parameters.Add(AbstractDataAccess.CreateDbParameter(comVente, "@NumeroVente", this.numeroFacture));            
                    
                    queryDetails = "SELECT a.LibelleArt as Designation, b.PrixVente, b.RemisePourcentage, b.RemiseMontant, b.QteVente as Quantite " +
                        "FROM Article a, ArchiveVente b " +
                        "WHERE a.IdArt = b.IdArt AND b.NumeroVente = @NumeroVente";
                    comArchiveVente.Parameters.Add(AbstractDataAccess.CreateDbParameter(comArchiveVente, "@NumeroVente", this.numeroFacture));
                }
                else
                {
                    query = "SELECT Min(b.DateVente) as NumeroFacture, Max(b.DateVente) as DateFacture " +
                        "FROM Article a, ArchiveVente b " +
                        "WHERE a.IdArt = b.IdArt AND b.DateVente BETWEEN @DateDu AND @DateAu";
                    comVente.Parameters.Add(AbstractDataAccess.CreateDbParameter(comVente, "@DateDu", this.dateDu));
                    comVente.Parameters.Add(AbstractDataAccess.CreateDbParameter(comVente, "@DateAu", this.dateAu));

                    queryDetails = "SELECT a.LibelleArt as Designation, b.PrixVente, b.RemisePourcentage, b.RemiseMontant, b.QteVente as Quantite " +
                        "FROM Article a, ArchiveVente b " +
                        "WHERE a.IdArt = b.IdArt AND b.DateVente BETWEEN @DateDu AND @DateAu";
                    comArchiveVente.Parameters.Add(AbstractDataAccess.CreateDbParameter(comVente, "@DateDu", this.dateDu));
                    comArchiveVente.Parameters.Add(AbstractDataAccess.CreateDbParameter(comVente, "@DateAu", this.dateAu));                 
                }

                // Affichage de la facture ou de la periode
                comVente.CommandType = CommandType.Text;
                comVente.CommandText = query;                
                DbDataReader readerVente = comVente.ExecuteReader();
                DataSetFacture.VenteDataTable vente = new DataSetFacture.VenteDataTable();
                vente.Load(readerVente);

                // Affichage des details
                comArchiveVente.CommandType = CommandType.Text;
                comArchiveVente.CommandText = queryDetails;                
                DbDataReader readerArchiveVente = comArchiveVente.ExecuteReader();
                DataSetFacture.ArchiveVenteDataTable archivevente = new DataSetFacture.ArchiveVenteDataTable();
                archivevente.Load(readerArchiveVente);

                conn.Close();
                readerVente.Close();
                readerArchiveVente.Close();

                //Prepare the report datasource
                ReportDataSource rptDS1 = new ReportDataSource();
                rptDS1.Name = "DataSetFacture_Vente";
                rptDS1.Value = vente;
                reportFacture.LocalReport.DataSources.Add(rptDS1);

                ReportDataSource rptDS2 = new ReportDataSource();
                rptDS2.Name = "DataSetFacture_ArchiveVente";
                rptDS2.Value = archivevente;
                reportFacture.LocalReport.DataSources.Add(rptDS2);                             
                reportFacture.RefreshReport();
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
