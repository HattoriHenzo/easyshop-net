﻿namespace App.EasyShop.FormParametre
{
    partial class FormParametres
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
            this.tabControlParametres = new System.Windows.Forms.TabControl();
            this.tabCategorie = new System.Windows.Forms.TabPage();
            this.gridCategorie = new System.Windows.Forms.DataGridView();
            this.idCatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelleCatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valideCatDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.categorieBOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkValide = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCategorie = new System.Windows.Forms.TextBox();
            this.cmdSupprimerCategorie = new System.Windows.Forms.Button();
            this.cmdModifierCategorie = new System.Windows.Forms.Button();
            this.cmdAjouterCategorie = new System.Windows.Forms.Button();
            this.cmdNouveauCategorie = new System.Windows.Forms.Button();
            this.cmdQuitter = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tabControlParametres.SuspendLayout();
            this.tabCategorie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCategorie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBOBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlParametres
            // 
            this.tabControlParametres.Controls.Add(this.tabCategorie);
            this.tabControlParametres.Location = new System.Drawing.Point(12, 14);
            this.tabControlParametres.Name = "tabControlParametres";
            this.tabControlParametres.SelectedIndex = 0;
            this.tabControlParametres.Size = new System.Drawing.Size(394, 348);
            this.tabControlParametres.TabIndex = 0;
            // 
            // tabCategorie
            // 
            this.tabCategorie.Controls.Add(this.gridCategorie);
            this.tabCategorie.Controls.Add(this.groupBox1);
            this.tabCategorie.Controls.Add(this.cmdSupprimerCategorie);
            this.tabCategorie.Controls.Add(this.cmdModifierCategorie);
            this.tabCategorie.Controls.Add(this.cmdAjouterCategorie);
            this.tabCategorie.Controls.Add(this.cmdNouveauCategorie);
            this.tabCategorie.Location = new System.Drawing.Point(4, 22);
            this.tabCategorie.Name = "tabCategorie";
            this.tabCategorie.Padding = new System.Windows.Forms.Padding(3);
            this.tabCategorie.Size = new System.Drawing.Size(386, 322);
            this.tabCategorie.TabIndex = 1;
            this.tabCategorie.Text = "Catégories";
            this.tabCategorie.UseVisualStyleBackColor = true;
            this.tabCategorie.Enter += new System.EventHandler(this.tabCategorie_Enter);
            // 
            // gridCategorie
            // 
            this.gridCategorie.AllowUserToAddRows = false;
            this.gridCategorie.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.gridCategorie.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridCategorie.AutoGenerateColumns = false;
            this.gridCategorie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCategorie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCatDataGridViewTextBoxColumn,
            this.libelleCatDataGridViewTextBoxColumn,
            this.valideCatDataGridViewCheckBoxColumn});
            this.gridCategorie.DataSource = this.categorieBOBindingSource;
            this.gridCategorie.Location = new System.Drawing.Point(35, 153);
            this.gridCategorie.Name = "gridCategorie";
            this.gridCategorie.ReadOnly = true;
            this.gridCategorie.RowTemplate.Height = 20;
            this.gridCategorie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCategorie.Size = new System.Drawing.Size(226, 150);
            this.gridCategorie.TabIndex = 6;
            this.gridCategorie.SelectionChanged += new System.EventHandler(this.gridCategorie_SelectionChanged);
            // 
            // idCatDataGridViewTextBoxColumn
            // 
            this.idCatDataGridViewTextBoxColumn.DataPropertyName = "IdCat";
            this.idCatDataGridViewTextBoxColumn.HeaderText = "IdCat";
            this.idCatDataGridViewTextBoxColumn.Name = "idCatDataGridViewTextBoxColumn";
            this.idCatDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCatDataGridViewTextBoxColumn.Visible = false;
            // 
            // libelleCatDataGridViewTextBoxColumn
            // 
            this.libelleCatDataGridViewTextBoxColumn.DataPropertyName = "LibelleCat";
            this.libelleCatDataGridViewTextBoxColumn.HeaderText = "Libellé";
            this.libelleCatDataGridViewTextBoxColumn.Name = "libelleCatDataGridViewTextBoxColumn";
            this.libelleCatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valideCatDataGridViewCheckBoxColumn
            // 
            this.valideCatDataGridViewCheckBoxColumn.DataPropertyName = "ValideCat";
            this.valideCatDataGridViewCheckBoxColumn.HeaderText = "Valide";
            this.valideCatDataGridViewCheckBoxColumn.Name = "valideCatDataGridViewCheckBoxColumn";
            this.valideCatDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // categorieBOBindingSource
            // 
            this.categorieBOBindingSource.DataSource = typeof(App.BusinessObject.CategorieBO);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkValide);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCategorie);
            this.groupBox1.Location = new System.Drawing.Point(38, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // chkValide
            // 
            this.chkValide.AutoSize = true;
            this.chkValide.Location = new System.Drawing.Point(68, 69);
            this.chkValide.Name = "chkValide";
            this.chkValide.Size = new System.Drawing.Size(55, 17);
            this.chkValide.TabIndex = 8;
            this.chkValide.Text = "Valide";
            this.chkValide.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Catégorie";
            // 
            // txtCategorie
            // 
            this.txtCategorie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCategorie.Location = new System.Drawing.Point(67, 23);
            this.txtCategorie.Name = "txtCategorie";
            this.txtCategorie.Size = new System.Drawing.Size(133, 20);
            this.txtCategorie.TabIndex = 6;
            // 
            // cmdSupprimerCategorie
            // 
            this.cmdSupprimerCategorie.Image = global::App.EasyShop.Properties.Resources.button_cancel;
            this.cmdSupprimerCategorie.Location = new System.Drawing.Point(289, 255);
            this.cmdSupprimerCategorie.Name = "cmdSupprimerCategorie";
            this.cmdSupprimerCategorie.Size = new System.Drawing.Size(73, 40);
            this.cmdSupprimerCategorie.TabIndex = 4;
            this.toolTip.SetToolTip(this.cmdSupprimerCategorie, "Supprimer");
            this.cmdSupprimerCategorie.UseVisualStyleBackColor = true;
            this.cmdSupprimerCategorie.Click += new System.EventHandler(this.cmdSupprimerCategorie_Click);
            // 
            // cmdModifierCategorie
            // 
            this.cmdModifierCategorie.Image = global::App.EasyShop.Properties.Resources.edit;
            this.cmdModifierCategorie.Location = new System.Drawing.Point(289, 209);
            this.cmdModifierCategorie.Name = "cmdModifierCategorie";
            this.cmdModifierCategorie.Size = new System.Drawing.Size(73, 40);
            this.cmdModifierCategorie.TabIndex = 4;
            this.toolTip.SetToolTip(this.cmdModifierCategorie, "Modifier");
            this.cmdModifierCategorie.UseVisualStyleBackColor = true;
            this.cmdModifierCategorie.Click += new System.EventHandler(this.cmdModifierCategorie_Click);
            // 
            // cmdAjouterCategorie
            // 
            this.cmdAjouterCategorie.Image = global::App.EasyShop.Properties.Resources.button_ok;
            this.cmdAjouterCategorie.Location = new System.Drawing.Point(289, 163);
            this.cmdAjouterCategorie.Name = "cmdAjouterCategorie";
            this.cmdAjouterCategorie.Size = new System.Drawing.Size(73, 40);
            this.cmdAjouterCategorie.TabIndex = 4;
            this.toolTip.SetToolTip(this.cmdAjouterCategorie, "Valider");
            this.cmdAjouterCategorie.UseVisualStyleBackColor = true;
            this.cmdAjouterCategorie.Click += new System.EventHandler(this.cmdAjouterCategorie_Click);
            // 
            // cmdNouveauCategorie
            // 
            this.cmdNouveauCategorie.Location = new System.Drawing.Point(289, 50);
            this.cmdNouveauCategorie.Name = "cmdNouveauCategorie";
            this.cmdNouveauCategorie.Size = new System.Drawing.Size(75, 23);
            this.cmdNouveauCategorie.TabIndex = 3;
            this.cmdNouveauCategorie.Text = "Vider";
            this.toolTip.SetToolTip(this.cmdNouveauCategorie, "Vide le champ pour une nouvelle saisie");
            this.cmdNouveauCategorie.UseVisualStyleBackColor = true;
            this.cmdNouveauCategorie.Click += new System.EventHandler(this.cmdNouveauCategorie_Click);
            // 
            // cmdQuitter
            // 
            this.cmdQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdQuitter.Image = global::App.EasyShop.Properties.Resources.exit;
            this.cmdQuitter.Location = new System.Drawing.Point(333, 368);
            this.cmdQuitter.Name = "cmdQuitter";
            this.cmdQuitter.Size = new System.Drawing.Size(73, 40);
            this.cmdQuitter.TabIndex = 6;
            this.toolTip.SetToolTip(this.cmdQuitter, "Fermer");
            this.cmdQuitter.UseVisualStyleBackColor = true;
            this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
            // 
            // FormParametres
            // 
            this.AcceptButton = this.cmdAjouterCategorie;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdQuitter;
            this.ClientSize = new System.Drawing.Size(418, 417);
            this.Controls.Add(this.cmdQuitter);
            this.Controls.Add(this.tabControlParametres);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormParametres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catégories";
            this.Load += new System.EventHandler(this.FormParametres_Load);
            this.tabControlParametres.ResumeLayout(false);
            this.tabCategorie.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCategorie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBOBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabCategorie;
        private System.Windows.Forms.Button cmdQuitter;
        private System.Windows.Forms.Button cmdNouveauCategorie;
        private System.Windows.Forms.Button cmdAjouterCategorie;
        private System.Windows.Forms.Button cmdSupprimerCategorie;
        private System.Windows.Forms.Button cmdModifierCategorie;
        private System.Windows.Forms.TabControl tabControlParametres;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkValide;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCategorie;
        private System.Windows.Forms.DataGridView gridCategorie;
        private System.Windows.Forms.BindingSource categorieBOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleCatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn valideCatDataGridViewCheckBoxColumn;
    }
}