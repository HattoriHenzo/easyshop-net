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

namespace App.EasyShop.FormArreteDeCaisse
{
    public partial class FormArreteDeCaisse : Form
    {
        private ArreteDeCaisseBO currentAC;
        private ArreteDeCaisseBLL arreteDeCaisseBLL;
        private ArreteDeCaisseBOListView listeAC;
        private ArchiveVenteBLL archiveVenteBLL;
        private bool deblocForm;

        public bool DeblocForm { get => deblocForm; set => deblocForm = value; }

        public FormArreteDeCaisse()
        {
            this.currentAC = new ArreteDeCaisseBO();
            this.arreteDeCaisseBLL = new ArreteDeCaisseBLL();
            this.listeAC = new ArreteDeCaisseBOListView();
            this.archiveVenteBLL = new ArchiveVenteBLL();
            InitializeComponent();
        }

        private void cmdQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormArreteDeCaisse_Load(object sender, EventArgs e)
        {
            //On récupère le toyal vendu dans la journée
            this.txtMontantBase.Value = this.archiveVenteBLL.GetTotalVentesByPeriod(DateTime.Parse(this.dtpDu.Value.ToShortDateString()), DateTime.Parse(this.dtpDu.Value.ToShortDateString())).ToString();            

            //Remplissage de la liste
            //Remplissage du datagridview            
            this.arreteDeCaisseBOBindingSource.DataSource = this.listeAC;
            this.gridAC.DataSource = this.arreteDeCaisseBOBindingSource;
        }
       

        private void txtMontantCaisse_Leave(object sender, EventArgs e)
        {
            
        }

        private void cmdValider_Click(object sender, EventArgs e)
        {
            if (this.txtMontantCaisse.ReadOnly == true)
            {
                AppMessage.Warning("Veuillez débloquer le formulaire avant de faire une insertion !");
                return;
            }

            if (AppMessage.Question("Voulez vous effectuer l'arrêté de caisse ?") != DialogResult.No)
            {
                try
                {
                    ArreteDeCaisseBO newAC = new ArreteDeCaisseBO();
                    newAC.MontantBase = int.Parse(this.txtMontantBase.Value);
                    newAC.MontantEnCaisse = int.Parse(this.txtMontantCaisse.Value);
                    newAC.DateAC = DateTime.Parse(this.dtpDateJour.Value.ToShortDateString());
                    newAC.HeureAC = DateTime.Now.ToShortTimeString();
                    newAC.ObservationAC = this.txtObservation.Text;

                    if (this.arreteDeCaisseBLL.Insert(newAC) != 0)
                    {
                        newAC.IdAC = this.arreteDeCaisseBLL.GetMaxId();

                        this.listeAC.Add(newAC);

                        //On indique la conformité de l'arrêté de caisse
                        if (this.currentAC.ConformeAC == true)
                        {
                            this.txtConformite.Text = "OUI";
                            this.txtConformite.BackColor = Color.GreenYellow;
                        }
                        else
                        {
                            this.txtConformite.Text = "NON";
                            this.txtConformite.BackColor = Color.Red;
                        }

                        AppMessage.Success("L'insertion s'est effectuée avec succès !");
                        
                        this.dtpDateJour.Enabled = false;
                        this.txtMontantCaisse.ReadOnly = true;
                        this.txtObservation.ReadOnly = true;
                    }
                }
                catch (AppException appEx)
                {
                    AppMessage.Error(appEx.Message);

                    this.dtpDateJour.Enabled = false;
                    this.txtMontantCaisse.ReadOnly = true;
                    this.txtObservation.ReadOnly = true;

                    this.DeblocForm = false;
                }
            }
        }

        

        private void gridArreteDeCaisse_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void cmdNouveau_Click(object sender, EventArgs e)
        {
                 
        }

        private void cmdModifier_Click(object sender, EventArgs e)
        {            
            if (this.gridAC.RowCount != 0)
            {
                if (this.txtMontantCaisse.ReadOnly == true)
                {
                    AppMessage.Warning("Veuillez débloquer le formulaire avant de tenter une modification !");
                    return;
                }

                if (AppMessage.Question("Voulez effectuer la modification ?") != DialogResult.No)
                {
                    try
                    {
                        ArreteDeCaisseBO oldAC = new ArreteDeCaisseBO();

                        oldAC.IdAC = this.currentAC.IdAC;
                        oldAC.MontantBase = int.Parse(this.txtMontantBase.Value);
                        oldAC.MontantEnCaisse = int.Parse(this.txtMontantCaisse.Value);
                        oldAC.DateAC = DateTime.Parse(this.dtpDateJour.Value.ToShortDateString());
                        oldAC.HeureAC = DateTime.Today.ToShortTimeString();
                        oldAC.ObservationAC = this.txtObservation.Text;

                        if (this.arreteDeCaisseBLL.Update(oldAC) != 0)
                        {
                            this.currentAC.MontantBase = oldAC.MontantBase;
                            this.currentAC.MontantEnCaisse = oldAC.MontantEnCaisse;
                            this.currentAC.DateAC = oldAC.DateAC;
                            this.currentAC.HeureAC = oldAC.HeureAC;
                            this.currentAC.ObservationAC = oldAC.ObservationAC;

                            //On récupère la valeur du champ "conformité" dans la base de données
                            foreach (ArreteDeCaisseBO ac in this.arreteDeCaisseBLL.GetArreteDeCaissesByPeriod(oldAC.DateAC, oldAC.DateAC))
                            {
                                this.currentAC.ConformeAC = ac.ConformeAC;
                            }

                            this.gridAC.Refresh();

                            AppMessage.Success("La modification s'est effectuée avec succès !");

                            this.dtpDateJour.Enabled = false;
                            this.txtMontantCaisse.ReadOnly = true;
                            this.txtObservation.ReadOnly = true;

                            //On indique la conformité de l'arrêté de caisse
                            if (this.currentAC.ConformeAC == true)
                            {
                                this.txtConformite.Text = "OUI";
                                this.txtConformite.BackColor = Color.GreenYellow;
                            }
                            else
                            {
                                this.txtConformite.Text = "NON";
                                this.txtConformite.BackColor = Color.Red;
                            }                           
                        }                                                            
                    }
                    catch (AppException appEx)
                    {
                        AppMessage.Error(appEx.Message);

                        this.dtpDateJour.Enabled = false;
                        this.txtMontantCaisse.ReadOnly = true;
                        this.txtObservation.ReadOnly = true;

                        this.DeblocForm = false;
                    }   
                }
            }
        }

        private void dtpDateJour_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cmdDebloquer_Click(object sender, EventArgs e)
        {
            //Formulaire bloqué
            if (this.DeblocForm == false)
            {
                if (AppMessage.Question("Voulez vous débloquer le formulaire ?") != DialogResult.No)
                {
                    this.dtpDateJour.Enabled = true;
                    this.txtMontantCaisse.ReadOnly = false;
                    this.txtObservation.ReadOnly = false;

                    this.txtMontantCaisse.Focus();
                }

                this.DeblocForm = true;
            }
            //Formulaire débloqué
            else
            {
                if (AppMessage.Question("Voulez vous bloquer le formulaire ?") != DialogResult.No)
                {
                    this.dtpDateJour.Enabled = false;
                    this.txtMontantCaisse.ReadOnly = true;
                    this.txtObservation.ReadOnly = true;

                    this.txtMontantCaisse.Focus();
                }

                this.DeblocForm = false;
            }                
        }

        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtMontantCaisse_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cmdDeb_Click(object sender, EventArgs e)
        {
            this.txtMontantCaisse.ReadOnly = false;
            this.txtMontantCaisse.Focus();
        }

        private void gridAC_SelectionChanged(object sender, EventArgs e)
        {
            if (this.gridAC.RowCount != 0)
            {
                this.currentAC = (ArreteDeCaisseBO)this.gridAC.CurrentRow.DataBoundItem;

                this.txtMontantBase.Value = this.currentAC.MontantBase.ToString();
                this.txtMontantCaisse.Value = this.currentAC.MontantEnCaisse.ToString();
                this.txtObservation.Text = this.currentAC.ObservationAC;

                this.txtMontantCaisse.ReadOnly = true;
                this.txtObservation.ReadOnly = true;

                //On indique la conformité de l'arrêté de caisse
                if (this.currentAC.ConformeAC == true)
                {
                    this.txtConformite.Text = "OUI";
                    this.txtConformite.BackColor = Color.GreenYellow;
                }
                else
                {
                    this.txtConformite.Text = "NON";
                    this.txtConformite.BackColor = Color.Red;
                }

            }
        }

        private void cmdRech_Click(object sender, EventArgs e)
        {
            //Remplissage du datagridview
            this.listeAC = this.arreteDeCaisseBLL.GetArreteDeCaissesByPeriod(DateTime.Parse(this.dtpDu.Value.ToShortDateString()), DateTime.Parse(this.dtpAu.Value.ToShortDateString()));
            this.arreteDeCaisseBOBindingSource.DataSource = this.listeAC;
            this.gridAC.DataSource = this.arreteDeCaisseBOBindingSource;

            if (this.gridAC.RowCount == 0)
            {
                this.txtMontantBase.Value = "0";
                this.txtMontantCaisse.Value = "0";
                this.txtConformite.Text = string.Empty;
                this.txtObservation.Text = string.Empty;
            }
        }

        private void cmdSupprimer_Click(object sender, EventArgs e)
        {
            if (this.gridAC.RowCount != 0)
            {
                if (AppMessage.Question("Voulez effectuer cette suppression ?") != DialogResult.No)
                {
                    try
                    {
                        if (this.arreteDeCaisseBLL.Delete(this.currentAC) != 0)
                        {
                            this.listeAC.Remove(this.currentAC);

                            AppMessage.Success("La suppression s'est effectuée avec succès !");

                            if (this.gridAC.RowCount == 0)
                            {
                                this.txtMontantBase.Value = "0";
                                this.txtMontantCaisse.Value = "0";
                                this.txtConformite.Text = string.Empty;
                                this.txtObservation.Text = string.Empty;
                            }
                        }
                    }
                    catch (AppException appEx)
                    {
                        AppMessage.Error(appEx.Message);

                        this.dtpDateJour.Enabled = false;
                        this.txtMontantCaisse.ReadOnly = true;
                        this.txtObservation.ReadOnly = true;

                        this.DeblocForm = false;
                    }
                }
            }
        }

        
    }
}
