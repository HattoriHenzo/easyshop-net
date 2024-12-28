namespace App.EasyShop.FormCommande
{
    partial class FormDisplayCommande
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTotalCommande = new App.Tools.AppNumericTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gridCommande = new System.Windows.Forms.DataGridView();
            this.idComDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numComDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numComTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateComDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heureComDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descComDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.annulerComDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.commandeBOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridDetailCommande = new System.Windows.Forms.DataGridView();
            this.idComderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelleArtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qteComDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixComDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idArtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idComDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raisonSocialeFourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commanderBOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmdLivraison = new System.Windows.Forms.Button();
            this.Supprimer = new System.Windows.Forms.Button();
            this.cmdModifier = new System.Windows.Forms.Button();
            this.cmdNouveau = new System.Windows.Forms.Button();
            this.cmdQuitter = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cmdImprimer = new System.Windows.Forms.Button();
            this.cmdNouveauDetailCom = new System.Windows.Forms.Button();
            this.cmdModifierDetailCom = new System.Windows.Forms.Button();
            this.cmdSupprimerDetailCom = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCommande)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandeBOBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetailCommande)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commanderBOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTotalCommande);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.gridCommande);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 276);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Commandes";
            // 
            // txtTotalCommande
            // 
            this.txtTotalCommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCommande.Location = new System.Drawing.Point(373, 241);
            this.txtTotalCommande.Name = "txtTotalCommande";
            this.txtTotalCommande.ReadOnly = true;
            this.txtTotalCommande.Size = new System.Drawing.Size(122, 20);
            this.txtTotalCommande.TabIndex = 10;
            this.txtTotalCommande.Text = "0,00";
            this.txtTotalCommande.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalCommande.Value = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "TOTAL DE LA COMMANDE";
            // 
            // gridCommande
            // 
            this.gridCommande.AllowUserToAddRows = false;
            this.gridCommande.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.gridCommande.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridCommande.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCommande.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCommande.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idComDataGridViewTextBoxColumn,
            this.numComDataGridViewTextBoxColumn,
            this.numComTextDataGridViewTextBoxColumn,
            this.dateComDataGridViewTextBoxColumn,
            this.heureComDataGridViewTextBoxColumn,
            this.descComDataGridViewTextBoxColumn,
            this.annulerComDataGridViewCheckBoxColumn});
            this.gridCommande.DataSource = this.commandeBOBindingSource;
            this.gridCommande.Location = new System.Drawing.Point(16, 40);
            this.gridCommande.MultiSelect = false;
            this.gridCommande.Name = "gridCommande";
            this.gridCommande.ReadOnly = true;
            this.gridCommande.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCommande.Size = new System.Drawing.Size(479, 189);
            this.gridCommande.TabIndex = 8;
            this.gridCommande.SelectionChanged += new System.EventHandler(this.gridCommande_SelectionChanged_1);
            // 
            // idComDataGridViewTextBoxColumn
            // 
            this.idComDataGridViewTextBoxColumn.DataPropertyName = "IdCom";
            this.idComDataGridViewTextBoxColumn.HeaderText = "IdCom";
            this.idComDataGridViewTextBoxColumn.Name = "idComDataGridViewTextBoxColumn";
            this.idComDataGridViewTextBoxColumn.ReadOnly = true;
            this.idComDataGridViewTextBoxColumn.Visible = false;
            // 
            // numComDataGridViewTextBoxColumn
            // 
            this.numComDataGridViewTextBoxColumn.DataPropertyName = "NumCom";
            this.numComDataGridViewTextBoxColumn.HeaderText = "NumCom";
            this.numComDataGridViewTextBoxColumn.Name = "numComDataGridViewTextBoxColumn";
            this.numComDataGridViewTextBoxColumn.ReadOnly = true;
            this.numComDataGridViewTextBoxColumn.Visible = false;
            // 
            // numComTextDataGridViewTextBoxColumn
            // 
            this.numComTextDataGridViewTextBoxColumn.DataPropertyName = "NumComText";
            this.numComTextDataGridViewTextBoxColumn.HeaderText = "Numéro";
            this.numComTextDataGridViewTextBoxColumn.Name = "numComTextDataGridViewTextBoxColumn";
            this.numComTextDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateComDataGridViewTextBoxColumn
            // 
            this.dateComDataGridViewTextBoxColumn.DataPropertyName = "DateCom";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dateComDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.dateComDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateComDataGridViewTextBoxColumn.Name = "dateComDataGridViewTextBoxColumn";
            this.dateComDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // heureComDataGridViewTextBoxColumn
            // 
            this.heureComDataGridViewTextBoxColumn.DataPropertyName = "HeureCom";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.heureComDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.heureComDataGridViewTextBoxColumn.HeaderText = "Heure";
            this.heureComDataGridViewTextBoxColumn.Name = "heureComDataGridViewTextBoxColumn";
            this.heureComDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descComDataGridViewTextBoxColumn
            // 
            this.descComDataGridViewTextBoxColumn.DataPropertyName = "DescCom";
            this.descComDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descComDataGridViewTextBoxColumn.Name = "descComDataGridViewTextBoxColumn";
            this.descComDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // annulerComDataGridViewCheckBoxColumn
            // 
            this.annulerComDataGridViewCheckBoxColumn.DataPropertyName = "AnnulerCom";
            this.annulerComDataGridViewCheckBoxColumn.HeaderText = "Annuler";
            this.annulerComDataGridViewCheckBoxColumn.Name = "annulerComDataGridViewCheckBoxColumn";
            this.annulerComDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // commandeBOBindingSource
            // 
            this.commandeBOBindingSource.DataSource = typeof(App.BusinessObject.CommandeBO);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridDetailCommande);
            this.groupBox2.Location = new System.Drawing.Point(12, 313);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(511, 247);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Détails de la commande";
            // 
            // gridDetailCommande
            // 
            this.gridDetailCommande.AllowUserToAddRows = false;
            this.gridDetailCommande.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
            this.gridDetailCommande.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gridDetailCommande.AutoGenerateColumns = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDetailCommande.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridDetailCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDetailCommande.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idComderDataGridViewTextBoxColumn,
            this.libelleArtDataGridViewTextBoxColumn,
            this.qteComDataGridViewTextBoxColumn,
            this.prixComDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.idArtDataGridViewTextBoxColumn,
            this.idComDataGridViewTextBoxColumn1,
            this.idFourDataGridViewTextBoxColumn,
            this.raisonSocialeFourDataGridViewTextBoxColumn});
            this.gridDetailCommande.DataSource = this.commanderBOBindingSource;
            this.gridDetailCommande.Location = new System.Drawing.Point(19, 31);
            this.gridDetailCommande.MultiSelect = false;
            this.gridDetailCommande.Name = "gridDetailCommande";
            this.gridDetailCommande.ReadOnly = true;
            this.gridDetailCommande.RowTemplate.Height = 20;
            this.gridDetailCommande.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDetailCommande.Size = new System.Drawing.Size(476, 199);
            this.gridDetailCommande.TabIndex = 0;
            this.gridDetailCommande.DoubleClick += new System.EventHandler(this.gridDetailCommande_DoubleClick);
            this.gridDetailCommande.SelectionChanged += new System.EventHandler(this.gridDetailCommande_SelectionChanged);
            // 
            // idComderDataGridViewTextBoxColumn
            // 
            this.idComderDataGridViewTextBoxColumn.DataPropertyName = "IdComder";
            this.idComderDataGridViewTextBoxColumn.HeaderText = "IdComder";
            this.idComderDataGridViewTextBoxColumn.Name = "idComderDataGridViewTextBoxColumn";
            this.idComderDataGridViewTextBoxColumn.ReadOnly = true;
            this.idComderDataGridViewTextBoxColumn.Visible = false;
            // 
            // libelleArtDataGridViewTextBoxColumn
            // 
            this.libelleArtDataGridViewTextBoxColumn.DataPropertyName = "LibelleArt";
            this.libelleArtDataGridViewTextBoxColumn.HeaderText = "Article";
            this.libelleArtDataGridViewTextBoxColumn.Name = "libelleArtDataGridViewTextBoxColumn";
            this.libelleArtDataGridViewTextBoxColumn.ReadOnly = true;
            this.libelleArtDataGridViewTextBoxColumn.Width = 120;
            // 
            // qteComDataGridViewTextBoxColumn
            // 
            this.qteComDataGridViewTextBoxColumn.DataPropertyName = "QteCom";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.qteComDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.qteComDataGridViewTextBoxColumn.HeaderText = "Quantité";
            this.qteComDataGridViewTextBoxColumn.Name = "qteComDataGridViewTextBoxColumn";
            this.qteComDataGridViewTextBoxColumn.ReadOnly = true;
            this.qteComDataGridViewTextBoxColumn.Width = 80;
            // 
            // prixComDataGridViewTextBoxColumn
            // 
            this.prixComDataGridViewTextBoxColumn.DataPropertyName = "PrixCom";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "# ### ###";
            dataGridViewCellStyle8.NullValue = null;
            this.prixComDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.prixComDataGridViewTextBoxColumn.HeaderText = "Prix d\'Achat";
            this.prixComDataGridViewTextBoxColumn.Name = "prixComDataGridViewTextBoxColumn";
            this.prixComDataGridViewTextBoxColumn.ReadOnly = true;
            this.prixComDataGridViewTextBoxColumn.Width = 80;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle9.Format = "# ### ###";
            dataGridViewCellStyle9.NullValue = null;
            this.totalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalDataGridViewTextBoxColumn.Width = 80;
            // 
            // idArtDataGridViewTextBoxColumn
            // 
            this.idArtDataGridViewTextBoxColumn.DataPropertyName = "IdArt";
            this.idArtDataGridViewTextBoxColumn.HeaderText = "IdArt";
            this.idArtDataGridViewTextBoxColumn.Name = "idArtDataGridViewTextBoxColumn";
            this.idArtDataGridViewTextBoxColumn.ReadOnly = true;
            this.idArtDataGridViewTextBoxColumn.Visible = false;
            // 
            // idComDataGridViewTextBoxColumn1
            // 
            this.idComDataGridViewTextBoxColumn1.DataPropertyName = "IdCom";
            this.idComDataGridViewTextBoxColumn1.HeaderText = "IdCom";
            this.idComDataGridViewTextBoxColumn1.Name = "idComDataGridViewTextBoxColumn1";
            this.idComDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idComDataGridViewTextBoxColumn1.Visible = false;
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
            this.raisonSocialeFourDataGridViewTextBoxColumn.HeaderText = "Fournisseur";
            this.raisonSocialeFourDataGridViewTextBoxColumn.Name = "raisonSocialeFourDataGridViewTextBoxColumn";
            this.raisonSocialeFourDataGridViewTextBoxColumn.ReadOnly = true;
            this.raisonSocialeFourDataGridViewTextBoxColumn.Width = 140;
            // 
            // commanderBOBindingSource
            // 
            this.commanderBOBindingSource.DataSource = typeof(App.BusinessObject.CommanderBO);
            // 
            // cmdLivraison
            // 
            this.cmdLivraison.Image = global::App.EasyShop.Properties.Resources.ark2;
            this.cmdLivraison.Location = new System.Drawing.Point(542, 181);
            this.cmdLivraison.Name = "cmdLivraison";
            this.cmdLivraison.Size = new System.Drawing.Size(73, 40);
            this.cmdLivraison.TabIndex = 4;
            this.toolTip.SetToolTip(this.cmdLivraison, "Livraison");
            this.cmdLivraison.UseVisualStyleBackColor = true;
            this.cmdLivraison.Click += new System.EventHandler(this.cmdLivraison_Click);
            // 
            // Supprimer
            // 
            this.Supprimer.Image = global::App.EasyShop.Properties.Resources.button_cancel;
            this.Supprimer.Location = new System.Drawing.Point(542, 135);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(73, 40);
            this.Supprimer.TabIndex = 3;
            this.toolTip.SetToolTip(this.Supprimer, "Supprimer");
            this.Supprimer.UseVisualStyleBackColor = true;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // cmdModifier
            // 
            this.cmdModifier.Image = global::App.EasyShop.Properties.Resources.edit;
            this.cmdModifier.Location = new System.Drawing.Point(542, 89);
            this.cmdModifier.Name = "cmdModifier";
            this.cmdModifier.Size = new System.Drawing.Size(73, 40);
            this.cmdModifier.TabIndex = 3;
            this.toolTip.SetToolTip(this.cmdModifier, "Modifier");
            this.cmdModifier.UseVisualStyleBackColor = true;
            this.cmdModifier.Click += new System.EventHandler(this.cmdModifier_Click);
            // 
            // cmdNouveau
            // 
            this.cmdNouveau.Image = global::App.EasyShop.Properties.Resources.edit_add;
            this.cmdNouveau.Location = new System.Drawing.Point(542, 43);
            this.cmdNouveau.Name = "cmdNouveau";
            this.cmdNouveau.Size = new System.Drawing.Size(73, 40);
            this.cmdNouveau.TabIndex = 3;
            this.toolTip.SetToolTip(this.cmdNouveau, "Nouveau");
            this.cmdNouveau.UseVisualStyleBackColor = true;
            this.cmdNouveau.Click += new System.EventHandler(this.cmdNouveau_Click);
            // 
            // cmdQuitter
            // 
            this.cmdQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdQuitter.Image = global::App.EasyShop.Properties.Resources.exit;
            this.cmdQuitter.Location = new System.Drawing.Point(542, 520);
            this.cmdQuitter.Name = "cmdQuitter";
            this.cmdQuitter.Size = new System.Drawing.Size(73, 40);
            this.cmdQuitter.TabIndex = 2;
            this.toolTip.SetToolTip(this.cmdQuitter, "Fermer");
            this.cmdQuitter.UseVisualStyleBackColor = true;
            this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
            // 
            // cmdImprimer
            // 
            this.cmdImprimer.Image = global::App.EasyShop.Properties.Resources.printer1;
            this.cmdImprimer.Location = new System.Drawing.Point(542, 227);
            this.cmdImprimer.Name = "cmdImprimer";
            this.cmdImprimer.Size = new System.Drawing.Size(73, 40);
            this.cmdImprimer.TabIndex = 5;
            this.toolTip.SetToolTip(this.cmdImprimer, "Imprimer le détail de la commande");
            this.cmdImprimer.UseVisualStyleBackColor = true;
            this.cmdImprimer.Click += new System.EventHandler(this.cmdImprimer_Click);
            // 
            // cmdNouveauDetailCom
            // 
            this.cmdNouveauDetailCom.Image = global::App.EasyShop.Properties.Resources.edit_add;
            this.cmdNouveauDetailCom.Location = new System.Drawing.Point(542, 342);
            this.cmdNouveauDetailCom.Name = "cmdNouveauDetailCom";
            this.cmdNouveauDetailCom.Size = new System.Drawing.Size(73, 40);
            this.cmdNouveauDetailCom.TabIndex = 6;
            this.toolTip.SetToolTip(this.cmdNouveauDetailCom, "Nouvel Article");
            this.cmdNouveauDetailCom.UseVisualStyleBackColor = true;
            this.cmdNouveauDetailCom.Click += new System.EventHandler(this.cmdNouveauDetailCom_Click);
            // 
            // cmdModifierDetailCom
            // 
            this.cmdModifierDetailCom.Image = global::App.EasyShop.Properties.Resources.edit;
            this.cmdModifierDetailCom.Location = new System.Drawing.Point(542, 388);
            this.cmdModifierDetailCom.Name = "cmdModifierDetailCom";
            this.cmdModifierDetailCom.Size = new System.Drawing.Size(73, 40);
            this.cmdModifierDetailCom.TabIndex = 7;
            this.toolTip.SetToolTip(this.cmdModifierDetailCom, "Modifier Article");
            this.cmdModifierDetailCom.UseVisualStyleBackColor = true;
            this.cmdModifierDetailCom.Click += new System.EventHandler(this.cmdModifierDetailCom_Click);
            // 
            // cmdSupprimerDetailCom
            // 
            this.cmdSupprimerDetailCom.Image = global::App.EasyShop.Properties.Resources.button_cancel;
            this.cmdSupprimerDetailCom.Location = new System.Drawing.Point(542, 434);
            this.cmdSupprimerDetailCom.Name = "cmdSupprimerDetailCom";
            this.cmdSupprimerDetailCom.Size = new System.Drawing.Size(73, 40);
            this.cmdSupprimerDetailCom.TabIndex = 8;
            this.toolTip.SetToolTip(this.cmdSupprimerDetailCom, "Supprimer Article");
            this.cmdSupprimerDetailCom.UseVisualStyleBackColor = true;
            this.cmdSupprimerDetailCom.Click += new System.EventHandler(this.cmdSupprimerDetailCom_Click);
            // 
            // FormDisplayCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdQuitter;
            this.ClientSize = new System.Drawing.Size(624, 572);
            this.Controls.Add(this.cmdSupprimerDetailCom);
            this.Controls.Add(this.cmdModifierDetailCom);
            this.Controls.Add(this.cmdNouveauDetailCom);
            this.Controls.Add(this.cmdImprimer);
            this.Controls.Add(this.cmdLivraison);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.cmdModifier);
            this.Controls.Add(this.cmdNouveau);
            this.Controls.Add(this.cmdQuitter);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormDisplayCommande";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des commandes";
            this.Load += new System.EventHandler(this.FormDisplayCommande_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDisplayCommande_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCommande)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandeBOBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDetailCommande)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commanderBOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdQuitter;
        private System.Windows.Forms.DataGridView gridDetailCommande;
        private System.Windows.Forms.Button cmdNouveau;
        private System.Windows.Forms.Button cmdModifier;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.Button cmdLivraison;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button cmdImprimer;
        private System.Windows.Forms.Button cmdNouveauDetailCom;
        private System.Windows.Forms.Button cmdModifierDetailCom;
        private System.Windows.Forms.Button cmdSupprimerDetailCom;
        private System.Windows.Forms.DataGridView gridCommande;
        private System.Windows.Forms.BindingSource commandeBOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idComDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numComDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numComTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateComDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heureComDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descComDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn annulerComDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource commanderBOBindingSource;
        private App.Tools.AppNumericTextBox txtTotalCommande;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idComderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleArtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qteComDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixComDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idComDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn raisonSocialeFourDataGridViewTextBoxColumn;
    }
}