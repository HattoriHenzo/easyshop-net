using System;
using System.Windows.Forms;
using System.Configuration;

using App.BusinessObject;
using App.BusinessLogic;
using App.Tools;


namespace App.EasyShop.FormUser
{
    public partial class FormNewUser : Form
    {

        private UtilBLL utilBLL;

        public FormNewUser()
        {
            utilBLL = new UtilBLL();
            InitializeComponent();
        }

        private void FormNewUser_Load(object sender, EventArgs e)
        {
            this.cbxCategorie.SelectedIndex = 0;
            this.chkBoxValide.Checked = true;            
        }

        private void cmdQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdAjouter_Click(object sender, EventArgs e)
        {
            if (AppMessage.Question("Voulez vous effectuer cette insertion ?") == DialogResult.Yes)
            {
                try
                {
                    UtilBO newUtil = new UtilBO();

                    newUtil.NomUtil = this.txtNom.Text;
                    newUtil.PrenomUtil = this.txtPrenom.Text;
                    newUtil.AgeUtil = short.Parse(this.txtAge.Value);
                    newUtil.NumCarteUtil = this.txtNumCarte.Text;
                    newUtil.AdresseUtil = this.txtAdresse.Text;
                    newUtil.TelUtil = this.txtTelephone.Text;
                    newUtil.CelUtil = this.txtCellulaire.Text;
                    newUtil.EmailUtil = this.txtEmail.Text;
                    newUtil.LoginUtil = this.txtLogin.Text;
                    newUtil.PasswordUtil = this.txtPassword.Text;
                    newUtil.TypeUtil = this.cbxCategorie.SelectedIndex;
                    newUtil.ValideUtil = this.chkBoxValide.Checked;

                    if (utilBLL.Insert(newUtil) != 0)
                    {
                        newUtil.IdUtil = utilBLL.GetMaxId();

                        if (this.Owner != null)
                        {
                            ((FormDisplayUsers)this.Owner).ListUtil.Add(newUtil);
                        }    
                    
                        AppMessage.Success("L'insertion s'est effectuée avec succès !");
                        this.EmptyFields();

                        if (this.Owner == null)
                        {                            
                            //Ecriture dans le fichier de configuration
                            Configuration appConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                            appConfig.AppSettings.Settings["FirstTime"].Value = "false";
                            appConfig.Save(ConfigurationSaveMode.Full);                            

                            FormMain formMain = new FormMain();


                            formMain.CurrentUtil.IdUtil = newUtil.IdUtil;
                            formMain.CurrentUtil.NomUtil = newUtil.NomUtil;
                            formMain.CurrentUtil.PrenomUtil = newUtil.PrenomUtil;

                            this.Hide();

                            formMain.ShowDialog();                            
                        }
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

        private void EmptyFields()
        {
            this.txtNom.Text = "";
            this.txtPrenom.Text = "";
            this.txtAge.Text = "";
            this.txtNumCarte.Text = "";
            this.txtAdresse.Text = "";
            this.txtTelephone.Text = "";
            this.txtCellulaire.Text = "";
            this.txtEmail.Text = "";
            this.txtLogin.Text = "";
            this.txtPassword.Text = "";
            this.cbxCategorie.Text = "";
            this.chkBoxValide.Checked = true;
        }

        private void txtLogin_Enter(object sender, EventArgs e)
        {
            
        }        

        private void txtPrenom_Leave(object sender, EventArgs e)
        {
            try
            {
                this.txtLogin.Text = utilBLL.CreateNewLogin(this.txtNom.Text, this.txtPrenom.Text);
            }
            catch (AppException appEx)
            {
                AppMessage.Error(appEx.Message);
            }
        }
    }
}
