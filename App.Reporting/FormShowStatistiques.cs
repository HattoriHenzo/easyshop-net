using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App.Reporting
{
    public partial class FormShowStatistiques : Form
    {
        public FormShowStatistiques()
        {
            InitializeComponent();
        }

        private void FormShowStatistiques_Load(object sender, EventArgs e)
        {

            this.reportStatistique.RefreshReport();
        }
    }
}
