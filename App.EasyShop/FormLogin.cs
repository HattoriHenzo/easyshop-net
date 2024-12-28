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
    public partial class FormLogin : Form
    {
        private UtilBLL utilBLL;

        public FormLogin()
        {
            utilBLL = new UtilBLL();
            InitializeComponent();
        }

        private void cmdAnnuler_Click(object sender, EventArgs e)
        {
            //Fermeture de l'application
            Application.Exit();           
        }

        private void cmdConnexion_Click(object sender, EventArgs e)
        {
            bool valideUser = false;

            UtilBO vUser = new UtilBO();

            //On vérifie le login et le password
            foreach (UtilBO util in utilBLL.GetUsersValide(true))
            {                                
                if ((util.LoginUtil == this.txtLogin.Text.Trim()) && (util.PasswordUtil == this.txtPassword.Text))
                {
                    valideUser = true;
                    vUser = util;
                }                
            }

            if (valideUser == true)
            {
                this.Hide();  

                FormMain formMain = new FormMain();
                formMain.CurrentUtil = vUser;
                //Ouverture du formulaire au moment de la fermeture du formulaire de login
                formMain.ShowDialog();                              
            }
            else
            {
                AppMessage.Error("Impossible de se connecter ! Veuillez vérifier les informations fournies !");
                this.txtLogin.Focus();
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            //On s'assure que le fichier est lu depuis le disque
            ConfigurationManager.RefreshSection("appSettings");

            //On vérifie si c'est la première utilisattion de l'application
            if (ConfigurationManager.AppSettings["FirstTime"].ToString() == "true")
            {                
                AppMessage.Warning("Vous utilisez l'application pour la première fois. Veuillez créer un administrateur par défaut.");

                FormUser.FormNewUser formUser = new FormUser.FormNewUser();
                formUser.Owner = null;
                formUser.ShowDialog();               

                //Fermeture du FormLogin
                this.Close();
            }
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
