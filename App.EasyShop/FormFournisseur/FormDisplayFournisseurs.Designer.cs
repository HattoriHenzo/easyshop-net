namespace App.EasyShop.FormFournisseur
{
    partial class FormDisplayFournisseurs
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
            this.gridFournisseur = new System.Windows.Forms.DataGridView();
            this.fournisseurBOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmdNouveau = new System.Windows.Forms.Button();
            this.cmdModifier = new System.Windows.Forms.Button();
            this.cmdSupprimer = new System.Windows.Forms.Button();
            this.cmdQuitter = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.idFourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raisonSocialeFourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseFourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telFourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celFourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faxFourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailFourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siteInternetFourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridFournisseur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fournisseurBOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridFournisseur
            // 
            this.gridFournisseur.AllowUserToAddRows = false;
            this.gridFournisseur.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.gridFournisseur.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridFournisseur.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridFournisseur.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridFournisseur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFournisseur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFourDataGridViewTextBoxColumn,
            this.raisonSocialeFourDataGridViewTextBoxColumn,
            this.adresseFourDataGridViewTextBoxColumn,
            this.telFourDataGridViewTextBoxColumn,
            this.celFourDataGridViewTextBoxColumn,
            this.faxFourDataGridViewTextBoxColumn,
            this.emailFourDataGridViewTextBoxColumn,
            this.siteInternetFourDataGridViewTextBoxColumn});
            this.gridFournisseur.DataSource = this.fournisseurBOBindingSource;
            this.gridFournisseur.Location = new System.Drawing.Point(12, 28);
            this.gridFournisseur.Name = "gridFournisseur";
            this.gridFournisseur.ReadOnly = true;
            this.gridFournisseur.RowTemplate.Height = 20;
            this.gridFournisseur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridFournisseur.Size = new System.Drawing.Size(601, 245);
            this.gridFournisseur.TabIndex = 0;
            this.gridFournisseur.SelectionChanged += new System.EventHandler(this.gridFournisseur_SelectionChanged);
            // 
            // fournisseurBOBindingSource
            // 
            this.fournisseurBOBindingSource.DataSource = typeof(App.BusinessObject.FournisseurBO);
            // 
            // cmdNouveau
            // 
            this.cmdNouveau.Image = global::App.EasyShop.Properties.Resources.edit_add;
            this.cmdNouveau.Location = new System.Drawing.Point(12, 286);
            this.cmdNouveau.Name = "cmdNouveau";
            this.cmdNouveau.Size = new System.Drawing.Size(74, 40);
            this.cmdNouveau.TabIndex = 1;
            this.toolTip.SetToolTip(this.cmdNouveau, "Ajouter");
            this.cmdNouveau.UseVisualStyleBackColor = true;
            this.cmdNouveau.Click += new System.EventHandler(this.cmdNouveau_Click);
            // 
            // cmdModifier
            // 
            this.cmdModifier.Image = global::App.EasyShop.Properties.Resources.edit;
            this.cmdModifier.Location = new System.Drawing.Point(92, 286);
            this.cmdModifier.Name = "cmdModifier";
            this.cmdModifier.Size = new System.Drawing.Size(74, 40);
            this.cmdModifier.TabIndex = 1;
            this.toolTip.SetToolTip(this.cmdModifier, "Modifier");
            this.cmdModifier.UseVisualStyleBackColor = true;
            this.cmdModifier.Click += new System.EventHandler(this.cmdModifier_Click);
            // 
            // cmdSupprimer
            // 
            this.cmdSupprimer.Image = global::App.EasyShop.Properties.Resources.button_cancel;
            this.cmdSupprimer.Location = new System.Drawing.Point(172, 286);
            this.cmdSupprimer.Name = "cmdSupprimer";
            this.cmdSupprimer.Size = new System.Drawing.Size(74, 40);
            this.cmdSupprimer.TabIndex = 1;
            this.toolTip.SetToolTip(this.cmdSupprimer, "Supprimer");
            this.cmdSupprimer.UseVisualStyleBackColor = true;
            this.cmdSupprimer.Click += new System.EventHandler(this.cmdSupprimer_Click);
            // 
            // cmdQuitter
            // 
            this.cmdQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdQuitter.Image = global::App.EasyShop.Properties.Resources.exit;
            this.cmdQuitter.Location = new System.Drawing.Point(539, 286);
            this.cmdQuitter.Name = "cmdQuitter";
            this.cmdQuitter.Size = new System.Drawing.Size(74, 40);
            this.cmdQuitter.TabIndex = 1;
            this.toolTip.SetToolTip(this.cmdQuitter, "Fermer");
            this.cmdQuitter.UseVisualStyleBackColor = true;
            this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
            // 
            // idFourDataGridViewTextBoxColumn
            // 
            this.idFourDataGridViewTextBoxColumn.DataPropertyName = "IdFour";
            this.idFourDataGridViewTextBoxColumn.HeaderText = "IdFour";
            this.idFourDataGridViewTextBoxColumn.Name = "idFourDataGridViewTextBoxColumn";
            this.idFourDataGridViewTextBoxColumn.ReadOnly = true;
            this.idFourDataGridViewTextBoxColumn.Visible = false;
            // 
            // raisonSocialeFourDataGridViewTextBoxColumn
            // 
            this.raisonSocialeFourDataGridViewTextBoxColumn.DataPropertyName = "RaisonSocialeFour";
            this.raisonSocialeFourDataGridViewTextBoxColumn.HeaderText = "Raison Sociale";
            this.raisonSocialeFourDataGridViewTextBoxColumn.Name = "raisonSocialeFourDataGridViewTextBoxColumn";
            this.raisonSocialeFourDataGridViewTextBoxColumn.ReadOnly = true;
            this.raisonSocialeFourDataGridViewTextBoxColumn.Width = 140;
            // 
            // adresseFourDataGridViewTextBoxColumn
            // 
            this.adresseFourDataGridViewTextBoxColumn.DataPropertyName = "AdresseFour";
            this.adresseFourDataGridViewTextBoxColumn.HeaderText = "Adresse";
            this.adresseFourDataGridViewTextBoxColumn.Name = "adresseFourDataGridViewTextBoxColumn";
            this.adresseFourDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telFourDataGridViewTextBoxColumn
            // 
            this.telFourDataGridViewTextBoxColumn.DataPropertyName = "TelFour";
            this.telFourDataGridViewTextBoxColumn.HeaderText = "Téléphone";
            this.telFourDataGridViewTextBoxColumn.Name = "telFourDataGridViewTextBoxColumn";
            this.telFourDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // celFourDataGridViewTextBoxColumn
            // 
            this.celFourDataGridViewTextBoxColumn.DataPropertyName = "CelFour";
            this.celFourDataGridViewTextBoxColumn.HeaderText = "Cellulaire";
            this.celFourDataGridViewTextBoxColumn.Name = "celFourDataGridViewTextBoxColumn";
            this.celFourDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // faxFourDataGridViewTextBoxColumn
            // 
            this.faxFourDataGridViewTextBoxColumn.DataPropertyName = "FaxFour";
            this.faxFourDataGridViewTextBoxColumn.HeaderText = "Fax";
            this.faxFourDataGridViewTextBoxColumn.Name = "faxFourDataGridViewTextBoxColumn";
            this.faxFourDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailFourDataGridViewTextBoxColumn
            // 
            this.emailFourDataGridViewTextBoxColumn.DataPropertyName = "EmailFour";
            this.emailFourDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailFourDataGridViewTextBoxColumn.Name = "emailFourDataGridViewTextBoxColumn";
            this.emailFourDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // siteInternetFourDataGridViewTextBoxColumn
            // 
            this.siteInternetFourDataGridViewTextBoxColumn.DataPropertyName = "SiteInternetFour";
            this.siteInternetFourDataGridViewTextBoxColumn.HeaderText = "Site Internet";
            this.siteInternetFourDataGridViewTextBoxColumn.Name = "siteInternetFourDataGridViewTextBoxColumn";
            this.siteInternetFourDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormDisplayFournisseurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdQuitter;
            this.ClientSize = new System.Drawing.Size(625, 336);
            this.Controls.Add(this.cmdQuitter);
            this.Controls.Add(this.cmdSupprimer);
            this.Controls.Add(this.cmdModifier);
            this.Controls.Add(this.cmdNouveau);
            this.Controls.Add(this.gridFournisseur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormDisplayFournisseurs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste des fournisseurs";
            this.Load += new System.EventHandler(this.FormDisplayFournisseurs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridFournisseur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fournisseurBOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridFournisseur;
        private System.Windows.Forms.Button cmdNouveau;
        private System.Windows.Forms.Button cmdModifier;
        private System.Windows.Forms.Button cmdSupprimer;
        private System.Windows.Forms.Button cmdQuitter;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.BindingSource fournisseurBOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn raisonSocialeFourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseFourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telFourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celFourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faxFourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailFourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siteInternetFourDataGridViewTextBoxColumn;
    }
}