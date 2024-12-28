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

namespace App.EasyShop.FormUser
{
    public partial class FormEditUser : Form
    {
        private UtilBLL utilBLL;

        public FormEditUser()
        {
            utilBLL = new UtilBLL();
            InitializeComponent();
        }

        private void cmdQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEditUser_Load(object sender, EventArgs e)
        {
                     
            //Affichage des données de l'utilisateur à modifier
            this.txtNom.Text = ((FormDisplayUsers)this.Owner).CurrentUtil.NomUtil;
            this.txtPrenom.Text = ((FormDisplayUsers)this.Owner).CurrentUtil.PrenomUtil;
            this.txtAge.Value = ((FormDisplayUsers)this.Owner).CurrentUtil.AgeUtil.ToString();
            this.txtNumCarte.Text = ((FormDisplayUsers)this.Owner).CurrentUtil.NumCarteUtil;
            this.txtAdresse.Text = ((FormDisplayUsers)this.Owner).CurrentUtil.AdresseUtil;
            this.txtTelephone.Text = ((FormDisplayUsers)this.Owner).CurrentUtil.TelUtil;
            this.txtCellulaire.Text = ((FormDisplayUsers)this.Owner).CurrentUtil.CelUtil;
            this.txtEmail.Text = ((FormDisplayUsers)this.Owner).CurrentUtil.EmailUtil;
            this.txtLogin.Text = ((FormDisplayUsers)this.Owner).CurrentUtil.LoginUtil;
            this.txtPassword.Text = ((FormDisplayUsers)this.Owner).CurrentUtil.PasswordUtil;
            this.cbxCategorie.SelectedIndex = ((FormDisplayUsers)this.Owner).CurrentUtil.TypeUtil;
            this.chkBoxValide.Checked = ((FormDisplayUsers)this.Owner).CurrentUtil.ValideUtil;
            
        }       

        private void cmdModifier_Click(object sender, EventArgs e)
        {
            if (AppMessage.Question("Voulez vous effectuer cette modification ?") == DialogResult.Yes)
            {
                try
                {
                    //Objet à modifier
                    UtilBO oldUtil = new UtilBO();

                    oldUtil.IdUtil = ((FormDisplayUsers)this.Owner).CurrentUtil.IdUtil;
                    oldUtil.NomUtil = this.txtNom.Text;
                    oldUtil.PrenomUtil = this.txtPrenom.Text;
                    oldUtil.AgeUtil = short.Parse(this.txtAge.Value);
                    oldUtil.NumCarteUtil = this.txtNumCarte.Text;
                    oldUtil.AdresseUtil = this.txtAdresse.Text;
                    oldUtil.TelUtil = this.txtTelephone.Text;
                    oldUtil.CelUtil = this.txtCellulaire.Text;
                    oldUtil.EmailUtil = this.txtEmail.Text;
                    oldUtil.LoginUtil = this.txtLogin.Text;
                    oldUtil.PasswordUtil = this.txtPassword.Text;
                    oldUtil.TypeUtil = this.cbxCategorie.SelectedIndex;
                    oldUtil.ValideUtil = this.chkBoxValide.Checked;

                    if (utilBLL.Update(oldUtil) != 0)
                    {
                        AppMessage.Success("La modification s'est effectuée avec succès !");

                        ((FormDisplayUsers)this.Owner).CurrentUtil.NomUtil = oldUtil.NomUtil;
                        ((FormDisplayUsers)this.Owner).CurrentUtil.PrenomUtil = oldUtil.PrenomUtil;
                        ((FormDisplayUsers)this.Owner).CurrentUtil.AgeUtil = oldUtil.AgeUtil;
                        ((FormDisplayUsers)this.Owner).CurrentUtil.NumCarteUtil = oldUtil.NumCarteUtil;
                        ((FormDisplayUsers)this.Owner).CurrentUtil.AdresseUtil = oldUtil.AdresseUtil;
                        ((FormDisplayUsers)this.Owner).CurrentUtil.TelUtil = oldUtil.TelUtil;
                        ((FormDisplayUsers)this.Owner).CurrentUtil.CelUtil = oldUtil.CelUtil;
                        ((FormDisplayUsers)this.Owner).CurrentUtil.EmailUtil = oldUtil.EmailUtil;
                        ((FormDisplayUsers)this.Owner).CurrentUtil.LoginUtil = oldUtil.LoginUtil;
                        ((FormDisplayUsers)this.Owner).CurrentUtil.PasswordUtil = oldUtil.PasswordUtil;
                        ((FormDisplayUsers)this.Owner).CurrentUtil.TypeUtil = oldUtil.TypeUtil;
                        ((FormDisplayUsers)this.Owner).CurrentUtil.ValideUtil = oldUtil.ValideUtil;

                        ((FormDisplayUsers)this.Owner).GrisUsers.Refresh();

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

        private void txtLogin_Enter(object sender, EventArgs e)
        {
            
        }

        
    }
}
