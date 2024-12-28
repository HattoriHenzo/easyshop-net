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

namespace GestionBoutique.FormCommande
{
    public partial class FormNewCommande : Form
    {
        //Représente le numéro de la commande
        int commandeNumber;

        //Booléen indiquant si la commande a été validée ou non
        bool commandeValide;        
                
        public FormNewCommande()
        {
            InitializeComponent();
        }
        
        private void cmdQuitter_Click(object sender, EventArgs e)
        {            
            this.Close();           
        }

        private void FormNewCommande_Load(object sender, EventArgs e)
        {            
            
        }

        private void cmdNouveauArticle_Click(object sender, EventArgs e)
        {            
        }

        private void gridDetailsCommande_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmdValider_Click(object sender, EventArgs e)
        {
             
                             
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void gridDetailsCommande_SelectionChanged(object sender, EventArgs e)
        {            
        }

        private void cmdValiderCommande_Click(object sender, EventArgs e)
        {
           
        }

        private void FormNewCommande_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void cbxArticle_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void cmdNouveauFournisseur_Click(object sender, EventArgs e)
        {
            FormFournisseur.FormNewFournisseur formNewFourn = new GestionBoutique.FormFournisseur.FormNewFournisseur();
            formNewFourn.Owner = this;
            formNewFourn.ShowDialog();
        }

        private void cmdModifier_Click(object sender, EventArgs e)
        {
            
         }

    }
}
