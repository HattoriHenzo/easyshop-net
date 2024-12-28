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

namespace App.EasyShop.FormCommande
{
    public partial class FormNewEditCommande : Form
    {       
        bool modif = false;

        private CommandeBLL commandeBLL;

        /// <summary>
        /// Indique si on est dans un cas de modification ou pas
        /// </summary>
        public bool Modif
        {
            get { return modif; }
            set { modif = value; }
        }

        public FormNewEditCommande()
        {
            commandeBLL = new CommandeBLL();
            InitializeComponent();
        }
        
        private void cmdQuitter_Click(object sender, EventArgs e)
        {            
            this.Close();           
        }

        private void FormNewCommande_Load(object sender, EventArgs e)
        {            
            //Cas d'une modification 
            if (this.modif == true)
            {
                this.txtNumCommande.Text = ((FormDisplayCommande)this.Owner).CurrentCommande.NumComText;
                this.dtpDateCommande.Value = ((FormDisplayCommande)this.Owner).CurrentCommande.DateCom;
                this.txtDescriptionCommande.Text = ((FormDisplayCommande)this.Owner).CurrentCommande.DescCom;
                this.chkValide.Checked = ((FormDisplayCommande)this.Owner).CurrentCommande.AnnulerCom;
            }
            else
            {
                this.txtNumCommande.Text = "CMD-" + AppOrderManager.GetOrder(commandeBLL.GetMaxId() + 1);
            }
        }

        private void cmdNouveauArticle_Click(object sender, EventArgs e)
        {            
        }

        private void gridDetailsCommande_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            FormFournisseur.FormNewEditFournisseur formNewFourn = new App.EasyShop.FormFournisseur.FormNewEditFournisseur();
            formNewFourn.Owner = this;
            formNewFourn.ShowDialog();
        }

        private void cmdModifier_Click(object sender, EventArgs e)
        {
            
         }

        private void cmdValider_Click_1(object sender, EventArgs e)
        {
            //Cas d'un ajout
            if (this.modif == false)
            {
                if (AppMessage.Question("Voulez vous ajouter cette commande ?") != DialogResult.No)
                {
                    try
                    {
                        CommandeBO c = new CommandeBO();

                        c.NumCom = commandeBLL.GetMaxId() + 1;
                        c.NumComText = this.txtNumCommande.Text;
                        c.DateCom = DateTime.Parse(this.dtpDateCommande.Value.ToShortDateString());
                        c.HeureCom = DateTime.Now.ToShortTimeString();
                        c.DescCom = this.txtDescriptionCommande.Text;
                        c.AnnulerCom = this.chkValide.Checked;

                        if (commandeBLL.Insert(c) != 0)
                        {
                            c.IdCom = commandeBLL.GetMaxId();
                            ((FormDisplayCommande)this.Owner).ListeCommande.Add(c);
                            AppMessage.Success("L'insertion s'est effectuée avec succès !");

                            this.Close();
                        }
                    }
                    catch(AppException appEx)
                    {
                        AppMessage.Error(appEx.Message);
                    }
                }
            }
            //Cas d'une modification
            else
            {
                if (AppMessage.Question("Voulez vous modifier cette commande ?") != DialogResult.No)
                {
                    try
                    {
                        CommandeBO oldC = new CommandeBO();

                        oldC.IdCom = ((FormDisplayCommande)this.Owner).CurrentCommande.IdCom;
                        oldC.NumComText = ((FormDisplayCommande)this.Owner).CurrentCommande.NumComText;
                        oldC.DateCom = this.dtpDateCommande.Value;
                        oldC.HeureCom = DateTime.Now.ToShortTimeString();
                        oldC.DescCom = this.txtDescriptionCommande.Text; ;
                        oldC.AnnulerCom = this.chkValide.Checked;

                        if (commandeBLL.Update(oldC) != 0)
                        {
                            ((FormDisplayCommande)this.Owner).CurrentCommande.NumComText = oldC.NumComText;
                            ((FormDisplayCommande)this.Owner).CurrentCommande.DateCom = oldC.DateCom;
                            ((FormDisplayCommande)this.Owner).CurrentCommande.HeureCom = DateTime.Now.ToShortTimeString();
                            ((FormDisplayCommande)this.Owner).CurrentCommande.DescCom = oldC.DescCom;
                            ((FormDisplayCommande)this.Owner).CurrentCommande.AnnulerCom = oldC.AnnulerCom;

                            ((FormDisplayCommande)this.Owner).GridCommande.Refresh();

                            AppMessage.Success("La modification s'est effectuée avec succès !");

                            this.Close();
                        }

                    }
                    catch (AppException appEx)
                    {
                        AppMessage.Error(appEx.Message);
                    }
                }
            }
        }

    }
}
