using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using App.Reporting;
using App.BusinessObject;
using App.BusinessLogic;
using App.Tools;


namespace App.EasyShop.FormStatistiques
{
    public partial class FormStats : Form
    {

        private ArchiveVenteBOListView listeArchVente = null, listeArchVenteGlobal = null;

        private ArchiveVenteBLL archiveVenteBLL;
        private VenteBLL venteBLL;
        private ArticleBLL articleBLL;
        private UtilBLL utilBLL;

        public ArchiveVenteBOListView ListeArchVenteGlobal
        {
            get { return listeArchVenteGlobal; }
            set { listeArchVenteGlobal = value; }
        }

        private VenteBOListView listeVente = null;        

        public ArchiveVenteBOListView ListeArchVente
        {
            get { return listeArchVente; }
            set { listeArchVente = value; }
        }

        private ArchiveVenteBO currentArchVente = null;

        public ArchiveVenteBO CurrentArchVente
        {
            get { return currentArchVente; }
            set { currentArchVente = value; }
        }

        private VenteBO currentVente = null;

        public VenteBO CurrentVente
        {
            get { return currentVente; }
            set { currentVente = value; }
        }

        public DataGridView GridArchVente
        {
            get { return this.gridArchVente; }
            set { this.gridArchVente = value; }
        }

        public App.Tools.AppNumericTextBox TxtTotalVente
        {
            get { return this.txtTotalJournalier; }
            set { this.txtTotalJournalier = value; }
        }

        public FormStats()
        {
            archiveVenteBLL = new ArchiveVenteBLL();
            venteBLL = new VenteBLL();
            articleBLL = new ArticleBLL();
            utilBLL = new UtilBLL();
            InitializeComponent();
        }

        private void cmdQuitter_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

        private void FormStats_Load(object sender, EventArgs e)
        {
            this.listeArchVente = new ArchiveVenteBOListView();
            this.listeVente = new VenteBOListView();

            this.currentArchVente = new ArchiveVenteBO();

            //On selectionne la premiere valeur
            this.cbxTypeImpression.SelectedIndex = 0;
        }

        private void cmdRech_Click(object sender, EventArgs e)
        {
            this.listeVente = venteBLL.GetVentesByPeriod(DateTime.Parse(dtpDu.Value.ToShortDateString()), DateTime.Parse(dtpAu.Value.ToShortDateString()));
            this.venteBOListViewBindingSource.DataSource = this.listeVente;
            this.gridVente.DataSource = this.venteBOListViewBindingSource;

            this.CalculBeneficeGlobal();
        }
               
        private void cmdSupprimer_Click(object sender, EventArgs e)
        {
            if (this.gridArchVente.RowCount != 0)
            {
                if (AppMessage.Question("Voulez vous supprimer cette vente ?") != DialogResult.No)
                {
                    try
                    {
                        ArchiveVenteBO tmpAV = new ArchiveVenteBO();
                        
                        tmpAV.IdArch = this.currentArchVente.IdArch;
                        tmpAV.QteVente = this.currentArchVente.QteVente;
                        //tmpAV.IdArt = this.currentArchVente.IdArt;
                        ////Pour éviter les exceptions
                        //tmpAV.PrixVente = 1;
                        //tmpAV.QteVente = 1;

                        if (archiveVenteBLL.Delete(this.currentArchVente) != 0)
                        {
                            this.listeArchVente.Remove(this.currentArchVente);

                            //Actualisation de la quantité en stock
                            articleBLL.UpdateQuantite(tmpAV.QteVente, tmpAV.IdArt);

                            AppMessage.Success("La suppression s'est effectuée avec succès !");

                            //Affichage du total vendu
                            this.txtTotalJournalier.Value = archiveVenteBLL.GetTotalVente(this.listeArchVente).ToString();

                            if (this.gridArchVente.RowCount == 0)
                            {
                                this.txtTotalJournalier.Value = "0";
                            }
                        }
                    }
                    catch (AppException appEx)
                    {
                        AppMessage.Error(appEx.Message);
                    }
                }
            }
        }

        private void cmdModifier_Click(object sender, EventArgs e)
        {
            if (this.gridArchVente.RowCount != 0)
            {
                FormNewEditArchiveVente formEditArchive = new FormNewEditArchiveVente();
                formEditArchive.Owner = this;
                formEditArchive.EditMode = true;
                formEditArchive.ShowDialog();

                //On actualise les statistiques
                this.CalculBeneficeGlobal();
                this.CalculBeneficeParVente();
            }
            else
            {
                AppMessage.Warning("Veuillez afficher d'abord la liste des ventes !");
            }
        }

        private void gridArchVente_SelectionChanged(object sender, EventArgs e)
        {
            if (this.gridArchVente.RowCount != 0)
            {
                this.currentArchVente = (ArchiveVenteBO)this.gridArchVente.CurrentRow.DataBoundItem;

                //LINQ
                var utilName = from a in utilBLL.GetUsers()
                               where a.IdUtil == this.currentArchVente.IdUser
                               select a;

                foreach (var u in utilName)
                {
                    this.txtUserVente.Text = u.NomUtil + " " + u.PrenomUtil;
                }                
            }
        }

        private void cmdAjouter_Click(object sender, EventArgs e)
        {
            if (this.gridVente.RowCount != 0)
            {
                FormNewEditArchiveVente formNewEdit = new FormNewEditArchiveVente();
                formNewEdit.EditMode = false;
                formNewEdit.Owner = this;
                formNewEdit.ShowDialog();
                //On actualise les statistiques
                this.CalculBeneficeGlobal();
                this.CalculBeneficeParVente();
            }
            else
            {
                AppMessage.Warning("Veuillez afficher d'abord la liste des ventes !");
            }
        }

        private void nouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.gridArchVente.RowCount != 0)
            {
                FormNewEditArchiveVente formEditArchive = new FormNewEditArchiveVente();
                formEditArchive.Owner = this;
                formEditArchive.EditMode = false;
                formEditArchive.ShowDialog();
            }                          
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.gridArchVente.RowCount != 0)
            {
                FormNewEditArchiveVente formEditArchive = new FormNewEditArchiveVente();
                formEditArchive.Owner = this;
                formEditArchive.EditMode = true;
                formEditArchive.ShowDialog();
            }       
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.gridArchVente.RowCount != 0)
            {
                if (AppMessage.Question("Voulez vous supprimer cette vente ?") != DialogResult.No)
                {
                    try
                    {
                        int tmpQte = this.currentArchVente.QteVente;
                        int idArt = this.currentArchVente.IdArt;

                        if (archiveVenteBLL.Delete(this.currentArchVente) != 0)
                        {
                            this.listeArchVente.Remove(this.currentArchVente);

                            //Actualisation de la quantité en stock
                            articleBLL.UpdateQuantite(tmpQte, idArt);

                            AppMessage.Success("La suppression s'est effectuée avec succès !");

                            //Affichage du total vendu
                            this.txtTotalJournalier.Value = archiveVenteBLL.GetTotalVente(this.listeArchVente).ToString();

                            if (this.gridArchVente.RowCount == 0)
                            {
                                this.txtTotalJournalier.Value = "0";
                            }
                        }
                    }
                    catch (AppException appEx)
                    {
                        AppMessage.Error(appEx.Message);
                    }
                }
            }
        }

        private void gridArchVente_DoubleClick(object sender, EventArgs e)
        {
            if (this.gridArchVente.RowCount != 0)
            {
                FormNewEditArchiveVente formEditArchive = new FormNewEditArchiveVente();
                formEditArchive.Owner = this;
                formEditArchive.EditMode = true;
                formEditArchive.ShowDialog();
            }        
        }

        private void gridVente_SelectionChanged(object sender, EventArgs e)
        {
            if(this.gridVente.RowCount != 0)
            {
                this.currentVente = (VenteBO)this.gridVente.CurrentRow.DataBoundItem;
                this.CalculBeneficeParVente();                
            }            
        }

        private void CalculBeneficeGlobal()
        {
            //On effectue le calcul du benefice            
            this.listeArchVenteGlobal = archiveVenteBLL.GetVentesByPeriod(DateTime.Parse(dtpDu.Value.ToShortDateString()), DateTime.Parse(dtpAu.Value.ToShortDateString()));
            //Affichage du total vendu
            int montantTotalGlobal = archiveVenteBLL.GetTotalVente(this.listeArchVenteGlobal);
            this.txtTotalGlobal.Value = montantTotalGlobal.ToString();
            //Affichage du total des remises en pourcentage
            int remisePourcentageGlobal = archiveVenteBLL.GetAllRemisePourcentage(this.listeArchVenteGlobal.ToList<ArchiveVenteBO>());
            this.txtRemisePourcentageGlobal.Value = remisePourcentageGlobal.ToString();
            //Affichage du total des remises en montant
            int remiseMontantGlobal = archiveVenteBLL.GetAllRemiseMontant(this.listeArchVenteGlobal.ToList<ArchiveVenteBO>());
            this.txtRemiseMontantGlobal.Value = remiseMontantGlobal.ToString();
            //Affichage du benefice effectue
            int montantBeneficeGlobal = archiveVenteBLL.GetAllBeneficeMontant(this.listeArchVenteGlobal.ToList<ArchiveVenteBO>());
            this.txtBeneficeGlobal.Value = montantBeneficeGlobal.ToString();
        }

        private void CalculBeneficeParVente()
        {
            this.listeArchVente = archiveVenteBLL.GetVentesById(this.currentVente.NumeroVente);
            this.archiveVenteBOBindingSource.DataSource = this.listeArchVente;
            this.gridArchVente.DataSource = this.archiveVenteBOBindingSource;
            //Affichage du total vendu
            int montantTotalJournalier = archiveVenteBLL.GetTotalVente(this.listeArchVente);
            this.txtTotalJournalier.Value = montantTotalJournalier.ToString();
            //Affichage du total des remises en pourcentage
            int remisePourcentageJournalier = archiveVenteBLL.GetAllRemisePourcentage(this.listeArchVente.ToList<ArchiveVenteBO>());
            this.txtRemisePourcentageJournalier.Value = remisePourcentageJournalier.ToString();
            //Affichage du total des remise en montant
            int remiseMontantJournalier = archiveVenteBLL.GetAllRemiseMontant(this.listeArchVente.ToList<ArchiveVenteBO>());
            this.txtRemiseMontantJournalier.Value = remiseMontantJournalier.ToString();            
            //Affichage du benefice effectue
            int montantBeneficeJournalier = archiveVenteBLL.GetAllBeneficeMontant(this.listeArchVente.ToList<ArchiveVenteBO>());
            this.txtBeneficeRealise.Value = montantBeneficeJournalier.ToString();
        }

        private void cmdImprimer_Click(object sender, EventArgs e)
        {
            if(this.gridVente.RowCount != 0)
            {
                if(this.cbxTypeImpression.SelectedIndex == 0)
                {
                    if (AppMessage.Question("Voulez vous imprimer la facture de cette vente ?") == DialogResult.Yes)
                    {
                        FormVente.RetailPrinter.InsertHeader(this.currentVente.NumeroVente);
                        List<ArchiveVenteBO> ventes = archiveVenteBLL.GetVentesById(this.currentVente.NumeroVente).ToList<ArchiveVenteBO>();
                        FormVente.RetailPrinter.InsertBody(ventes);
                        FormVente.RetailPrinter.InsertFooter();
                        //On imprime la facture
                        RawPrinterHelper.SendStringToPrinter("Star TSP100 Cutter (TSP143)", FormVente.RetailPrinter.GetRetail());
                    }
                }
                else
                {
                    switch(this.cbxTypeImpression.SelectedIndex)
                    {
                        case 1:
                            if (AppMessage.Question("Voulez vous imprimer la liste des ventes ?") == DialogResult.Yes)
                            {
                                FormShowFacture formFacture = new FormShowFacture();
                                formFacture.Owner = this;
                                formFacture.TypeFacture = "facture";
                                formFacture.NumeroFacture = this.currentVente.NumeroVente.Trim();                                
                                formFacture.ShowDialog();

                            }
                            break;
                        case 2:
                            if (AppMessage.Question("Voulez vous imprimer la liste des ventes ?") == DialogResult.Yes)
                            {
                                FormShowFacture formFacture = new FormShowFacture();
                                formFacture.Owner = this;                                
                                formFacture.TypeFacture = "periode";
                                formFacture.DateDu = DateTime.Parse(this.dtpDu.Value.ToShortDateString());
                                formFacture.DateAu = DateTime.Parse(this.dtpAu.Value.ToShortDateString());
                                formFacture.ShowDialog();
                            }
                            break;
                    }                                     
                }                
            }
        }

    }
}
