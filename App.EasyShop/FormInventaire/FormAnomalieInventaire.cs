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

namespace App.EasyShop.FormInventaire
{
    public partial class FormAnomalieInventaire : Form
    {
        DateInventaireBOListView listeDateInv = null;

        InventaireBOListView listeInv = null;

        InventaireBO currentInv = null;

        private DateInventaireBLL dateInventaireBLL;
        private InventaireBLL inventaireBLL;

        public FormAnomalieInventaire()
        {
            dateInventaireBLL = new DateInventaireBLL();
            inventaireBLL = new InventaireBLL();
            InitializeComponent();
        }

        private void cmdQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAnomalieInventaire_Load(object sender, EventArgs e)
        {                    
        }       

        private void gridListeInventaire_SelectionChanged(object sender, EventArgs e)
        {
            if (this.gridListeInventaire.RowCount != 0)
            {
                this.listeInv = inventaireBLL.GetInventaireByDateId(((DateInventaireBO)this.gridListeInventaire.CurrentRow.DataBoundItem).IdDateInv);
                this.inventaireBOBindingSource.DataSource = this.listeInv;
                this.gridAnomalies.DataSource = this.inventaireBOBindingSource;
            }
        }

        private void gridAnomalies_SelectionChanged(object sender, EventArgs e)
        {
            if (this.gridAnomalies.RowCount != 0)
            {
                this.currentInv = (InventaireBO)this.gridAnomalies.CurrentRow.DataBoundItem;

                if (this.currentInv.EcartInv == 0)
                {
                    this.txtConforme.Text = "OUI";
                    this.txtConforme.BackColor = Color.GreenYellow;
                }
                else
                {
                    this.txtConforme.Text = "NON";
                    this.txtConforme.BackColor = Color.Red;
                }
            }
        }       

        private void cmdImprimer_Click(object sender, EventArgs e)
        {
            if (this.gridAnomalies.RowCount != 0)
            {
                if (AppMessage.Question("Voulez vous afficher l'état à imprimer ?") == DialogResult.Yes)
                {
                    FormShowAnomalies formAnomalie = new FormShowAnomalies();
                    formAnomalie.Owner = this;
                    formAnomalie.DateInv = ((DateInventaireBO)this.gridListeInventaire.CurrentRow.DataBoundItem).IdDateInv;
                    formAnomalie.ShowDialog();
                }
            }            
        }

        private void cmdRech_Click(object sender, EventArgs e)
        {                      
            //On rempli la liste des dateInventaire
            this.listeDateInv = dateInventaireBLL.GetDatesInventairesByDate(this.dtpDu.Value, this.dtpAu.Value);
            this.dateInventaireBOBindingSource.DataSource = this.listeDateInv;
            this.gridListeInventaire.DataSource = this.dateInventaireBOBindingSource;
        }
    }
}
