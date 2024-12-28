using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GestionBoutique.FormStatistiques
{
    public partial class FormEditArchiveVente : Form
    {
        public FormEditArchiveVente()
        {
            InitializeComponent();
        }

        private void cmdFermer_Click(object sender, EventArgs e)
        {
            //Fermeture du formulaire
            this.Close();
        }
    }
}
