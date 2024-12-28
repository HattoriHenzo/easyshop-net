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
    public partial class FormDisplayUsers : Form
    {
        //Objet de type UtilBO
        private UtilBO currentUtil = null;
        private UtilBLL utilBLL; 

        public UtilBO CurrentUtil
        {
            get { return currentUtil; }
            set { currentUtil = value; }
        }

        //Objet de type UtilBOListView
        UtilBOListView listUtil = null;

        public UtilBOListView ListUtil
        {
            get { return listUtil; }
            set { listUtil = value; }
        }
       
        public FormDisplayUsers()
        {
            utilBLL = new UtilBLL();
            InitializeComponent();
        }

        public DataGridView GrisUsers
        {
            get { return this.gridUsers; }
            set { this.gridUsers = value; }
        }

        private void FormDisplayUsers_Load(object sender, EventArgs e)
        {
            this.cbxFiltre.SelectedIndex = 0;
            this.currentUtil = new UtilBO();
            this.listUtil = new UtilBOListView();

            //Renvoie la liste de tous les utilisateurs
            this.listUtil = utilBLL.GetUsers();
            this.utilBOBindingSource.DataSource = this.listUtil;
            this.gridUsers.DataSource = this.utilBOBindingSource;            
        }               

        private void cmdQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdNouveau_Click(object sender, EventArgs e)
        {
            FormUser.FormNewUser formNewUser = new FormNewUser();
            formNewUser.Owner = this;
            formNewUser.ShowDialog();
        }

        private void gridUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (this.gridUsers.RowCount != 0)
            {
                this.currentUtil = (UtilBO)this.gridUsers.CurrentRow.DataBoundItem;

                if (this.currentUtil.LoginUtil == "sysadmin")
                {
                    this.cmdModifier.Enabled = false;
                    this.cmdSupprimer.Enabled = false;
                }
                else
                {
                    this.cmdModifier.Enabled = true;
                    this.cmdSupprimer.Enabled = true;
                }

                switch (this.currentUtil.TypeUtil)
                {
                    case 0:

                        this.txtCategorieUser.Text = "Contrôleur";

                    break;

                    case 1:

                        this.txtCategorieUser.Text = "Patron";

                    break;

                    case 2:

                        this.txtCategorieUser.Text = "Gérant";

                    break;
                }
            }
        }

        private void cbxFiltre_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Initialisation du datagridview

            switch (this.cbxFiltre.SelectedIndex)
            {
                case 0:
                    //Renvoie la liste de tous les utilisateurs
                    this.listUtil = utilBLL.GetUsers();
                    this.utilBOBindingSource.DataSource = this.listUtil;
                    this.gridUsers.DataSource = this.utilBOBindingSource;

                break;

                case 1:

                    //Renvoie la liste de tous les utilisateurs valides
                    this.listUtil = utilBLL.GetUsersValide(true);
                    this.utilBOBindingSource.DataSource = this.listUtil;
                    this.gridUsers.DataSource = this.utilBOBindingSource;

                break;

                case 2:

                    //Renvoie la liste de tous les utilisateurs non valides
                    this.listUtil = utilBLL.GetUsersValide(false);
                    this.utilBOBindingSource.DataSource = this.listUtil;
                    this.gridUsers.DataSource = this.utilBOBindingSource;

                break;
            }
        }

        private void cmdModifier_Click(object sender, EventArgs e)
        {
            if (this.gridUsers.RowCount != 0)
            {
                FormUser.FormEditUser formEditUser = new FormEditUser();
                formEditUser.Owner = this;
                formEditUser.ShowDialog();
            }
        }

        private void cmdSupprimer_Click(object sender, EventArgs e)
        {
            if (this.gridUsers.RowCount != 0)
            {
                if (AppMessage.Question("Voulez vous effectuer cette suppression ?") == DialogResult.Yes)
                {
                    if (utilBLL.Delete(false, this.currentUtil.IdUtil) != 0)
                    {
                        this.currentUtil.ValideUtil = false;
                        AppMessage.Success("La suppression s'est effectuée avec succès ! L'utilisateur n'est plus valide ");
                        this.gridUsers.Refresh();
                    }
                }
            }
        }

        private void txtCategorieUser_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void gridUsers_DoubleClick(object sender, EventArgs e)
        {
            if (this.currentUtil.LoginUtil == "sysadmin")
            {
                this.cmdModifier.Enabled = false;
                this.cmdSupprimer.Enabled = false;
            }
            else
            {
                if (this.gridUsers.RowCount != 0)
                {
                    FormUser.FormEditUser formEditUser = new FormEditUser();
                    formEditUser.Owner = this;
                    formEditUser.ShowDialog();
                }
            }            
        }

        private void nouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUser.FormNewUser formNewUser = new FormNewUser();
            formNewUser.Owner = this;
            formNewUser.ShowDialog();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.currentUtil.LoginUtil != "sysadmin")
            {
                if (this.gridUsers.RowCount != 0)
                {
                    FormUser.FormEditUser formEditUser = new FormEditUser();
                    formEditUser.Owner = this;
                    formEditUser.ShowDialog();
                }   
            }            
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.currentUtil.LoginUtil != "sysadmin")
            {
                if (this.gridUsers.RowCount != 0)
                {
                    if (AppMessage.Question("Voulez vous effectuer cette suppression ?") == DialogResult.Yes)
                    {
                        if (utilBLL.Delete(false, this.currentUtil.IdUtil) != 0)
                        {
                            this.currentUtil.ValideUtil = false;
                            AppMessage.Success("La suppression s'est effectuée avec succès ! L'utilisateur n'est plus valide ");
                            this.gridUsers.Refresh();
                        }
                    }
                }
            }            
        }
    }
}
