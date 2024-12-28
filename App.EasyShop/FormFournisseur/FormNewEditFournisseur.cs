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

namespace App.EasyShop.FormFournisseur
{
    public partial class FormNewEditFournisseur : Form
    {
        /// <summary>
        /// Indique on est dans un cas d'ajout ou de modification
        /// </summary>
        private bool modif = false;

        private FournisseurBLL fournisseurBLL;

        public bool Modif
        {
            get { return modif; }
            set { modif = value; }
        }

        public FormNewEditFournisseur()
        {
            fournisseurBLL = new FournisseurBLL();
            InitializeComponent();
        }

        private void cmdQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdAjouter_Click(object sender, EventArgs e)
        {
            //Cas d'ajout
            if (this.modif == false)
            {
                if (AppMessage.Question("Voulez vous ajouter ce fournisseur ?") != DialogResult.No)
                {
                    try
                    {
                        FournisseurBO f = new FournisseurBO();

                        f.RaisonSocialeFour = this.txtNom.Text;
                        f.AdresseFour = this.txtAdresse.Text;
                        f.TelFour = this.txtTel.Text;
                        f.CelFour = this.txtCel.Text;
                        f.FaxFour = this.txtFax.Text;
                        f.EmailFour = this.txtEmail.Text;
                        f.SiteInternetFour = this.txtSite.Text;

                        if (fournisseurBLL.Insert(f) != 0)
                        {
                            f.IdFour = fournisseurBLL.GetMaxId();
                            ((FormDisplayFournisseurs)this.Owner).ListeFournisseur.Add(f);
                            AppMessage.Success("L'insertion s'est effectuée avec succès !");
                            this.EmptyFields();
                        }
                    }
                    catch (AppValidationException appValEx)
                    {
                        AppMessage.Error(appValEx.Message);
                    }
                    catch (AppException appEx)
                    {
                        AppMessage.Error(appEx.Message);
                    }
                }
            }
            //Cas d'une modif
            else
            {
                if (AppMessage.Question("Voulez vous ajouter ce fournisseur ?") != DialogResult.No)
                {
                    try
                    {
                        FournisseurBO fOld = new FournisseurBO();

                        fOld.IdFour = ((FormDisplayFournisseurs)this.Owner).CurrentFournisseur.IdFour;
                        fOld.RaisonSocialeFour = this.txtNom.Text;
                        fOld.AdresseFour = this.txtAdresse.Text;
                        fOld.TelFour = this.txtTel.Text;
                        fOld.CelFour = this.txtCel.Text;
                        fOld.FaxFour = this.txtFax.Text;
                        fOld.EmailFour = this.txtEmail.Text;
                        fOld.SiteInternetFour = this.txtSite.Text;

                        if (fournisseurBLL.Update(fOld) != 0)
                        {
                            ((FormDisplayFournisseurs)this.Owner).CurrentFournisseur.RaisonSocialeFour = fOld.RaisonSocialeFour;
                            ((FormDisplayFournisseurs)this.Owner).CurrentFournisseur.AdresseFour = fOld.AdresseFour;
                            ((FormDisplayFournisseurs)this.Owner).CurrentFournisseur.TelFour = fOld.TelFour;
                            ((FormDisplayFournisseurs)this.Owner).CurrentFournisseur.CelFour = fOld.CelFour;
                            ((FormDisplayFournisseurs)this.Owner).CurrentFournisseur.FaxFour = fOld.FaxFour;
                            ((FormDisplayFournisseurs)this.Owner).CurrentFournisseur.EmailFour = fOld.EmailFour;
                            ((FormDisplayFournisseurs)this.Owner).CurrentFournisseur.SiteInternetFour = fOld.SiteInternetFour;

                            ((FormDisplayFournisseurs)this.Owner).GridFournisseur.Refresh();

                            AppMessage.Success("La modification s'est effectuée avec succès !");
                            this.Close();
                        }
                    }
                    catch (AppValidationException appValEx)
                    {
                        AppMessage.Error(appValEx.Message);
                    }
                    catch (AppException appEx)
                    {
                        AppMessage.Error(appEx.Message);
                    }
                }
            }            
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
            if (this.modif == false)
            {
            }
            //Cas de modification
            else
            {
                this.txtNom.Text = ((FormDisplayFournisseurs)this.Owner).CurrentFournisseur.RaisonSocialeFour;
                this.txtAdresse.Text = ((FormDisplayFournisseurs)this.Owner).CurrentFournisseur.AdresseFour;
                this.txtTel.Text = ((FormDisplayFournisseurs)this.Owner).CurrentFournisseur.TelFour;
                this.txtCel.Text = ((FormDisplayFournisseurs)this.Owner).CurrentFournisseur.CelFour;
                this.txtFax.Text = ((FormDisplayFournisseurs)this.Owner).CurrentFournisseur.FaxFour;
                this.txtEmail.Text = ((FormDisplayFournisseurs)this.Owner).CurrentFournisseur.EmailFour;
                this.txtSite.Text = ((FormDisplayFournisseurs)this.Owner).CurrentFournisseur.SiteInternetFour;
            }
        }
    }
}
