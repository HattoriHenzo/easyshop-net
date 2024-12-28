namespace App.EasyShop.FormUser
{
    partial class FormDisplayUsers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridUsers = new System.Windows.Forms.DataGridView();
            this.idUtilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomUtilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomUtilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageUtilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numCarteUtilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseUtilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telUtilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celUtilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailUtilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginUtilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordUtilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeUtilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valideUtilDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nouveauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilBOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmdNouveau = new System.Windows.Forms.Button();
            this.cmdModifier = new System.Windows.Forms.Button();
            this.cmdSupprimer = new System.Windows.Forms.Button();
            this.cmdQuitter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxFiltre = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCategorieUser = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.utilBOBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridUsers
            // 
            this.gridUsers.AllowUserToAddRows = false;
            this.gridUsers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.gridUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridUsers.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUtilDataGridViewTextBoxColumn,
            this.nomUtilDataGridViewTextBoxColumn,
            this.prenomUtilDataGridViewTextBoxColumn,
            this.ageUtilDataGridViewTextBoxColumn,
            this.numCarteUtilDataGridViewTextBoxColumn,
            this.adresseUtilDataGridViewTextBoxColumn,
            this.telUtilDataGridViewTextBoxColumn,
            this.celUtilDataGridViewTextBoxColumn,
            this.emailUtilDataGridViewTextBoxColumn,
            this.loginUtilDataGridViewTextBoxColumn,
            this.passwordUtilDataGridViewTextBoxColumn,
            this.typeUtilDataGridViewTextBoxColumn,
            this.valideUtilDataGridViewCheckBoxColumn});
            this.gridUsers.ContextMenuStrip = this.contextMenuStrip;
            this.gridUsers.DataSource = this.utilBOBindingSource;
            this.gridUsers.Location = new System.Drawing.Point(12, 92);
            this.gridUsers.MultiSelect = false;
            this.gridUsers.Name = "gridUsers";
            this.gridUsers.ReadOnly = true;
            this.gridUsers.RowTemplate.Height = 20;
            this.gridUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUsers.Size = new System.Drawing.Size(615, 270);
            this.gridUsers.TabIndex = 0;
            this.gridUsers.DoubleClick += new System.EventHandler(this.gridUsers_DoubleClick);
            this.gridUsers.SelectionChanged += new System.EventHandler(this.gridUsers_SelectionChanged);
            // 
            // idUtilDataGridViewTextBoxColumn
            // 
            this.idUtilDataGridViewTextBoxColumn.DataPropertyName = "IdUtil";
            this.idUtilDataGridViewTextBoxColumn.HeaderText = "IdUtil";
            this.idUtilDataGridViewTextBoxColumn.Name = "idUtilDataGridViewTextBoxColumn";
            this.idUtilDataGridViewTextBoxColumn.ReadOnly = true;
            this.idUtilDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomUtilDataGridViewTextBoxColumn
            // 
            this.nomUtilDataGridViewTextBoxColumn.DataPropertyName = "NomUtil";
            this.nomUtilDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomUtilDataGridViewTextBoxColumn.Name = "nomUtilDataGridViewTextBoxColumn";
            this.nomUtilDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prenomUtilDataGridViewTextBoxColumn
            // 
            this.prenomUtilDataGridViewTextBoxColumn.DataPropertyName = "PrenomUtil";
            this.prenomUtilDataGridViewTextBoxColumn.HeaderText = "Prénom";
            this.prenomUtilDataGridViewTextBoxColumn.Name = "prenomUtilDataGridViewTextBoxColumn";
            this.prenomUtilDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ageUtilDataGridViewTextBoxColumn
            // 
            this.ageUtilDataGridViewTextBoxColumn.DataPropertyName = "AgeUtil";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ageUtilDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.ageUtilDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageUtilDataGridViewTextBoxColumn.Name = "ageUtilDataGridViewTextBoxColumn";
            this.ageUtilDataGridViewTextBoxColumn.ReadOnly = true;
            this.ageUtilDataGridViewTextBoxColumn.Width = 70;
            // 
            // numCarteUtilDataGridViewTextBoxColumn
            // 
            this.numCarteUtilDataGridViewTextBoxColumn.DataPropertyName = "NumCarteUtil";
            this.numCarteUtilDataGridViewTextBoxColumn.HeaderText = "N° Carte";
            this.numCarteUtilDataGridViewTextBoxColumn.Name = "numCarteUtilDataGridViewTextBoxColumn";
            this.numCarteUtilDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresseUtilDataGridViewTextBoxColumn
            // 
            this.adresseUtilDataGridViewTextBoxColumn.DataPropertyName = "AdresseUtil";
            this.adresseUtilDataGridViewTextBoxColumn.HeaderText = "Adresse";
            this.adresseUtilDataGridViewTextBoxColumn.Name = "adresseUtilDataGridViewTextBoxColumn";
            this.adresseUtilDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telUtilDataGridViewTextBoxColumn
            // 
            this.telUtilDataGridViewTextBoxColumn.DataPropertyName = "TelUtil";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.telUtilDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.telUtilDataGridViewTextBoxColumn.HeaderText = "Téléphone";
            this.telUtilDataGridViewTextBoxColumn.Name = "telUtilDataGridViewTextBoxColumn";
            this.telUtilDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // celUtilDataGridViewTextBoxColumn
            // 
            this.celUtilDataGridViewTextBoxColumn.DataPropertyName = "CelUtil";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.celUtilDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.celUtilDataGridViewTextBoxColumn.HeaderText = "Cellulaire";
            this.celUtilDataGridViewTextBoxColumn.Name = "celUtilDataGridViewTextBoxColumn";
            this.celUtilDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailUtilDataGridViewTextBoxColumn
            // 
            this.emailUtilDataGridViewTextBoxColumn.DataPropertyName = "EmailUtil";
            this.emailUtilDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.emailUtilDataGridViewTextBoxColumn.Name = "emailUtilDataGridViewTextBoxColumn";
            this.emailUtilDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loginUtilDataGridViewTextBoxColumn
            // 
            this.loginUtilDataGridViewTextBoxColumn.DataPropertyName = "LoginUtil";
            this.loginUtilDataGridViewTextBoxColumn.HeaderText = "Login";
            this.loginUtilDataGridViewTextBoxColumn.Name = "loginUtilDataGridViewTextBoxColumn";
            this.loginUtilDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordUtilDataGridViewTextBoxColumn
            // 
            this.passwordUtilDataGridViewTextBoxColumn.DataPropertyName = "PasswordUtil";
            this.passwordUtilDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordUtilDataGridViewTextBoxColumn.Name = "passwordUtilDataGridViewTextBoxColumn";
            this.passwordUtilDataGridViewTextBoxColumn.ReadOnly = true;
            this.passwordUtilDataGridViewTextBoxColumn.Visible = false;
            // 
            // typeUtilDataGridViewTextBoxColumn
            // 
            this.typeUtilDataGridViewTextBoxColumn.DataPropertyName = "TypeUtil";
            this.typeUtilDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeUtilDataGridViewTextBoxColumn.Name = "typeUtilDataGridViewTextBoxColumn";
            this.typeUtilDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeUtilDataGridViewTextBoxColumn.Visible = false;
            // 
            // valideUtilDataGridViewCheckBoxColumn
            // 
            this.valideUtilDataGridViewCheckBoxColumn.DataPropertyName = "ValideUtil";
            this.valideUtilDataGridViewCheckBoxColumn.HeaderText = "Valide";
            this.valideUtilDataGridViewCheckBoxColumn.Name = "valideUtilDataGridViewCheckBoxColumn";
            this.valideUtilDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauToolStripMenuItem,
            this.toolStripSeparator1,
            this.modifierToolStripMenuItem,
            this.toolStripSeparator2,
            this.supprimerToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(150, 82);
            // 
            // nouveauToolStripMenuItem
            // 
            this.nouveauToolStripMenuItem.Image = global::App.EasyShop.Properties.Resources.edit_add;
            this.nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
            this.nouveauToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.nouveauToolStripMenuItem.Text = "Nouveau";
            this.nouveauToolStripMenuItem.Click += new System.EventHandler(this.nouveauToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(146, 6);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Image = global::App.EasyShop.Properties.Resources.edit;
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(146, 6);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Image = global::App.EasyShop.Properties.Resources.button_cancel;
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // utilBOBindingSource
            // 
            this.utilBOBindingSource.DataSource = typeof(App.BusinessObject.UtilBO);
            // 
            // cmdNouveau
            // 
            this.cmdNouveau.Image = global::App.EasyShop.Properties.Resources.edit_add;
            this.cmdNouveau.Location = new System.Drawing.Point(12, 371);
            this.cmdNouveau.Name = "cmdNouveau";
            this.cmdNouveau.Size = new System.Drawing.Size(75, 40);
            this.cmdNouveau.TabIndex = 1;
            this.toolTip.SetToolTip(this.cmdNouveau, "Nouveau");
            this.cmdNouveau.UseVisualStyleBackColor = true;
            this.cmdNouveau.Click += new System.EventHandler(this.cmdNouveau_Click);
            // 
            // cmdModifier
            // 
            this.cmdModifier.Image = global::App.EasyShop.Properties.Resources.edit;
            this.cmdModifier.Location = new System.Drawing.Point(93, 371);
            this.cmdModifier.Name = "cmdModifier";
            this.cmdModifier.Size = new System.Drawing.Size(75, 40);
            this.cmdModifier.TabIndex = 1;
            this.toolTip.SetToolTip(this.cmdModifier, "Modifier");
            this.cmdModifier.UseVisualStyleBackColor = true;
            this.cmdModifier.Click += new System.EventHandler(this.cmdModifier_Click);
            // 
            // cmdSupprimer
            // 
            this.cmdSupprimer.Image = global::App.EasyShop.Properties.Resources.button_cancel;
            this.cmdSupprimer.Location = new System.Drawing.Point(174, 371);
            this.cmdSupprimer.Name = "cmdSupprimer";
            this.cmdSupprimer.Size = new System.Drawing.Size(75, 40);
            this.cmdSupprimer.TabIndex = 1;
            this.toolTip.SetToolTip(this.cmdSupprimer, "Supprimer");
            this.cmdSupprimer.UseVisualStyleBackColor = true;
            this.cmdSupprimer.Click += new System.EventHandler(this.cmdSupprimer_Click);
            // 
            // cmdQuitter
            // 
            this.cmdQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdQuitter.Image = global::App.EasyShop.Properties.Resources.exit;
            this.cmdQuitter.Location = new System.Drawing.Point(552, 371);
            this.cmdQuitter.Name = "cmdQuitter";
            this.cmdQuitter.Size = new System.Drawing.Size(75, 40);
            this.cmdQuitter.TabIndex = 1;
            this.toolTip.SetToolTip(this.cmdQuitter, "Fermer");
            this.cmdQuitter.UseVisualStyleBackColor = true;
            this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxFiltre);
            this.groupBox1.Location = new System.Drawing.Point(13, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 60);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtre";
            // 
            // cbxFiltre
            // 
            this.cbxFiltre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFiltre.FormattingEnabled = true;
            this.cbxFiltre.Items.AddRange(new object[] {
            "Tous les utilisateurs",
            "Tous les utilisateurs valides",
            "Tous les utilisateurs non valides"});
            this.cbxFiltre.Location = new System.Drawing.Point(19, 25);
            this.cbxFiltre.Name = "cbxFiltre";
            this.cbxFiltre.Size = new System.Drawing.Size(182, 21);
            this.cbxFiltre.TabIndex = 0;
            this.cbxFiltre.SelectedIndexChanged += new System.EventHandler(this.cbxFiltre_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(409, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Catégorie";
            // 
            // txtCategorieUser
            // 
            this.txtCategorieUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategorieUser.Location = new System.Drawing.Point(473, 50);
            this.txtCategorieUser.Name = "txtCategorieUser";
            this.txtCategorieUser.ReadOnly = true;
            this.txtCategorieUser.Size = new System.Drawing.Size(154, 20);
            this.txtCategorieUser.TabIndex = 4;
            this.txtCategorieUser.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtCategorieUser_MouseClick);
            // 
            // FormDisplayUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdQuitter;
            this.ClientSize = new System.Drawing.Size(639, 420);
            this.Controls.Add(this.txtCategorieUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdQuitter);
            this.Controls.Add(this.cmdSupprimer);
            this.Controls.Add(this.cmdModifier);
            this.Controls.Add(this.cmdNouveau);
            this.Controls.Add(this.gridUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormDisplayUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste des utilisateurs";
            this.Load += new System.EventHandler(this.FormDisplayUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.utilBOBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridUsers;
        private System.Windows.Forms.Button cmdNouveau;
        private System.Windows.Forms.Button cmdModifier;
        private System.Windows.Forms.Button cmdSupprimer;
        private System.Windows.Forms.Button cmdQuitter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxFiltre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCategorieUser;
        private System.Windows.Forms.BindingSource utilBOBindingSource;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUtilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomUtilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomUtilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageUtilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numCarteUtilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseUtilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telUtilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celUtilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailUtilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginUtilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordUtilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeUtilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn valideUtilDataGridViewCheckBoxColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem nouveauToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
    }
}