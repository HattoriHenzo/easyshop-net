using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using App.BusinessLogic;
using App.Tools;


namespace App.EasyShop.FormInventaire
{
    public partial class FormValeurStock : Form
    {                       
        public FormValeurStock()
        {
            InitializeComponent();
        }

        private void cmdQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormValeurStock_Load(object sender, EventArgs e)
        {
            
        }       

        private void gridDateInventaire_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void HideValeurStockColumns()
        {
            
        }

        private void cmdImprimer_Click(object sender, EventArgs e)
        {
                
        }
        
    }
}
