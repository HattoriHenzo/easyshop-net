using System;
using System.Windows.Forms;

using App.BusinessObject;
using App.BusinessLogic;
using App.Tools;

namespace App.EasyShop.FormDepense
{
    public partial class FormDepense : Form
    {
        private DepenseBO currentDepense = new DepenseBO();

        private DepenseBOListView depenses = null;

        private DepenseBLL depenseBLL;
        public FormDepense()
        {
            depenseBLL = new DepenseBLL();
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cmdAjouter_Click(object sender, EventArgs e)
        {
            if (this.txtObjet.Text != String.Empty)
            {
                DepenseBO depense = new DepenseBO();
                depense.Date = DateTime.Parse(this.dtpDateDepense.Value.ToShortDateString());
                depense.Objet = this.txtObjet.Text;
                depense.Montant = int.Parse(this.txtMontant.Value);

                if (depenseBLL.Insert(depense) > 0)
                {
                    AppMessage.Success("L'insertion s'est effectuee avec succes !");
                    depenses = depenseBLL.GetDepenses();
                    depenseBOBindingSource.DataSource = depenses;
                    this.gridDepenses.DataSource = depenseBOBindingSource;
                    this.txtDepenseTotal.Value = CalculDepenseTotal(depenses).ToString();
                }
            }
            else
            {
                AppMessage.Warning("Veuillez saisir un objet pour la depense !");
            }
        }

        private void cmdRecherche_Click(object sender, EventArgs e)
        {
            depenses = depenseBLL.GetDepensesByPeriod(this.dtpDateDu.Value, this.dtpDateAu.Value);
            depenseBOBindingSource.DataSource = depenses;
            this.gridDepenses.DataSource = depenseBOBindingSource;
            this.txtDepenseTotal.Value = CalculDepenseTotal(depenses).ToString();
        }

        private void cmdSupprimer_Click(object sender, EventArgs e)
        {
            if(AppMessage.Question("Voulez supprimer cette depense ?") == DialogResult.Yes)
            {
                depenseBLL.Delete(currentDepense);
                depenseBOBindingSource.DataSource = depenseBLL.GetDepenses();
                gridDepenses.DataSource = depenseBOBindingSource;
                this.txtDepenseTotal.Value = CalculDepenseTotal(depenseBLL.GetDepenses()).ToString();
            }
        }

        private void gridDepenses_SelectionChanged(object sender, EventArgs e)
        {
            if (gridDepenses.RowCount != 0)
            {
                currentDepense = (DepenseBO)gridDepenses.CurrentRow.DataBoundItem;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="depenses"></param>
        /// <returns></returns>
        private int CalculDepenseTotal(DepenseBOListView depenses)
        {
            int total = 0;

            foreach(DepenseBO d in depenses)
            {
                total += d.Montant;
            }

            return total;
        }
    }
}
