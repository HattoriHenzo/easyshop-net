using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

using App.BusinessObject;
using App.BusinessLogic;
using App.Tools;


namespace App.EasyShop
{
    public partial class FormMain : Form
    {
        //Id du user
        private int idUser = 0;

        private StockDateBLL stockDateBLL;

        public int IdUser
        {
            get { return idUser; }
            set { idUser = value; }
        }

        private UtilBO currentUtil = new UtilBO();

        public UtilBO CurrentUtil
        {
            get { return currentUtil; }
            set { currentUtil = value; }
        }       

        public FormMain()
        {
            stockDateBLL = new StockDateBLL();
            InitializeComponent();
        }      

        private void catégorieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormParametre.FormParametres formParametres = new FormParametre.FormParametres();
            formParametres.InnerTabControl.SelectTab("tabCategorie");
            formParametres.ShowDialog();
        }

        private void motifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormParametre.FormParametres formParametres = new FormParametre.FormParametres();
            formParametres.InnerTabControl.SelectTab("tabMotif");
            formParametres.ShowDialog();
        }

        private void nouveauToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FormArticle.FormDisplayArticles formArticle = new FormArticle.FormDisplayArticles();
            formArticle.Owner = this;
            formArticle.ShowDialog();
        }

        private void utilisateursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUser.FormDisplayUsers formDisplayUsers = new App.EasyShop.FormUser.FormDisplayUsers();
            formDisplayUsers.Owner = this;
            formDisplayUsers.ShowDialog();
        }

        private void nouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormArticle.FormNewEditArticle formNewArticle = new App.EasyShop.FormArticle.FormNewEditArticle();
            formNewArticle.Owner = null;
            formNewArticle.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormCommande.FormNewEditCommande formNewCommande = new App.EasyShop.FormCommande.FormNewEditCommande();
            formNewCommande.Owner = null;
            formNewCommande.ShowDialog();
        }

        private void consulterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCommande.FormDisplayCommande formDisplayCommande = new App.EasyShop.FormCommande.FormDisplayCommande();
            formDisplayCommande.Owner = this;
            formDisplayCommande.ShowDialog();
        }

        private void consulterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormFournisseur.FormDisplayFournisseurs formDisplayFournisseur = new App.EasyShop.FormFournisseur.FormDisplayFournisseurs();
            formDisplayFournisseur.ShowDialog();
        }

        private void nouveauToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormFournisseur.FormNewEditFournisseur formFournisseur = new FormFournisseur.FormNewEditFournisseur();
            formFournisseur.Owner = null;
            formFournisseur.ShowDialog();
        }

        private void stocksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEntreesSorties.FormEntreeSortie formES = new App.EasyShop.FormEntreesSorties.FormEntreeSortie();
            formES.Owner = this;
            formES.ShowDialog();
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void catégoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormParametre.FormParametres formParametres = new FormParametre.FormParametres();            
            formParametres.ShowDialog();
        }

        private void nouvelleVenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVente.FormVentes formVente = new App.EasyShop.FormVente.FormVentes();
            formVente.Owner = this;
            formVente.ShowDialog();
        }

        private void arrêtéDeCaisseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormArreteDeCaisse.FormArreteDeCaisse formArreteCaisse = new App.EasyShop.FormArreteDeCaisse.FormArreteDeCaisse();
            formArreteCaisse.Owner = this;
            formArreteCaisse.ShowDialog();
        }

        private void statistiquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStatistiques.FormStats formStat = new App.EasyShop.FormStatistiques.FormStats();
            formStat.Owner = this;
            formStat.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {            
            string utilCat = string.Empty;

            switch (this.currentUtil.TypeUtil)
            {
                case 0:

                    utilCat = "Contrôleur";

                break;

                case 1:

                    utilCat = "Patron";

                break;

                case 2:

                    utilCat = "Gérant";

                break;
            }

            this.toolStripStatus.Text = "Utilisateur connecté : " + this.currentUtil.NomUtil + " " + this.currentUtil.PrenomUtil + " (" + utilCat + ")";

            //Réaffichage de l'interface en fonction du profil de l'utilisateur
            if (this.currentUtil.TypeUtil == 2)
            {
                this.DisableMenus();
            }
            else
            {
                this.EnableMenus();
            }            
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (AppMessage.Question("Voulez vous quitter l'application ?") != DialogResult.Yes)
            {
                e.Cancel = true;
            }
            else
            {
                // On actualise le stock ave la date en cours
                if (stockDateBLL.Delete(DateTime.Parse(DateTime.Today.ToShortDateString())) >= 0)
                {
                    if (stockDateBLL.Insert() >= 0)
                    {
                        AppMessage.Success("Le stock de la date du jour a été actualisé !");                        
                    }
                }
            }
        }

        private void inventaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void faireUnInventaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInventaire.FormInventaire formInv = new App.EasyShop.FormInventaire.FormInventaire();
            formInv.Owner = this;
            formInv.ShowDialog();
        }

        private void anomaliesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInventaire.FormAnomalieInventaire formAnomalie = new App.EasyShop.FormInventaire.FormAnomalieInventaire();
            formAnomalie.Owner = this;
            formAnomalie.ShowDialog();
        }

        private void valeurStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInventaire.FormValeurStock formValeurStock = new App.EasyShop.FormInventaire.FormValeurStock();
            formValeurStock.Owner = this;
            formValeurStock.ShowDialog();
        }        

        private void quitterToolStripMenuItem1_Click(object sender, EventArgs e)
        {


            // Fermeture de la fenetre
            this.Close();
        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAPropos formAPropos = new FormAPropos();
            formAPropos.ShowDialog();
        }

        private void toolStripDeconnexion_Click(object sender, EventArgs e)
        {
            if (AppMessage.Question("Voulez vous vous déconnecter de l'application ?") != DialogResult.No)
            {
                this.Hide();

                FormLogin formLogin = new FormLogin();
                formLogin.Owner = this;
                formLogin.ShowDialog();
            }            
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {            
        }

        private void EnableMenus()
        {
            toolStripSeparator8.Visible = true;
            stocksToolStripMenuItem.Visible = true;
            toolStripSeparator1.Visible = true;
            catégoriesToolStripMenuItem.Visible = true;
            toolStripMenuItem2.Visible = true;
            toolStripSeparator6.Visible = true;
            arrêtéDeCaisseToolStripMenuItem.Visible = true;
            toolStripSeparator7.Visible = true;
            statistiquesToolStripMenuItem.Visible = true;
            utilisateursToolStripMenuItem.Visible = true;
            toolStripSeparator12.Visible = true;
            commandesToolStripMenuItem.Visible = true;
            toolStripMenuItem4.Visible = true;
        }

        private void DisableMenus()
        {
            toolStripSeparator8.Visible = false;
            stocksToolStripMenuItem.Visible = false;
            toolStripSeparator1.Visible = false;
            catégoriesToolStripMenuItem.Visible = false;
            toolStripMenuItem2.Visible = false;
            toolStripSeparator6.Visible = false;
            arrêtéDeCaisseToolStripMenuItem.Visible = false;
            toolStripSeparator7.Visible = false;
            statistiquesToolStripMenuItem.Visible = false;
            utilisateursToolStripMenuItem.Visible = false;
            toolStripSeparator12.Visible = false;
            commandesToolStripMenuItem.Visible = false;
            toolStripMenuItem4.Visible = false;
        }

        private void documentationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppMessage.Error("L'aide est en cours de développement !");
        }

        private void stockADateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormArticle.FormStockDate frmStockDate = new App.EasyShop.FormArticle.FormStockDate();
            frmStockDate.Owner = this;
            frmStockDate.ShowDialog();
        }

        private void afficherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDepense.FormDepense formDepense = new App.EasyShop.FormDepense.FormDepense();
            formDepense.ShowDialog();
        }
    }
}
