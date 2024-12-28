using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BusinessLogicLayerLib;
using ToolsLib;

namespace GestionBoutique.FormFournisseur
{
    public partial class FormNewFournisseur : Form
    {
        public FormNewFournisseur()
        {
            InitializeComponent();
        }

        private void cmdQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdAjouter_Click(object sender, EventArgs e)
        {
            
        }

        private void EmptyFields()
        {
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    c.Text = "";
                }
            }
        }

        private void FormNewFournisseur_Load(object sender, EventArgs e)
        {

        }
    }
}
