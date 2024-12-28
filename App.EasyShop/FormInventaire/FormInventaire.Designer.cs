namespace App.EasyShop.FormInventaire
{
    partial class FormInventaire
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
            this.dtpDateInventaire = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtObservation = new System.Windows.Forms.TextBox();
            this.gridInventaire = new System.Windows.Forms.DataGridView();
            this.idDateInvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateInvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heureInvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observationInvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valideInvDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dateInventaireBOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmdSupprimer = new System.Windows.Forms.Button();
            this.cmdValider = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtArticleRestant = new App.Tools.AppNumericTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gridArticleInventaire = new System.Windows.Forms.DataGridView();
            this.IdInv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LibelleArt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtePhysInv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QteStockInv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EcartInv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObservationInv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdDateInv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdArt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idInvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelleArtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtePhysInvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qteStockInvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ecartInvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observationInvDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDateInvDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idArtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventaireBOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmdSupprimerArt = new System.Windows.Forms.Button();
            this.cmdModifierArt = new System.Windows.Forms.Button();
            this.cmValiderArt = new System.Windows.Forms.Button();
            this.txtQteCompte = new App.Tools.AppNumericTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxArticle = new System.Windows.Forms.ComboBox();
            this.cmdQuitter = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cmdDebloquer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridInventaire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateInventaireBOBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridArticleInventaire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventaireBOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDateInventaire
            // 
            this.dtpDateInventaire.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateInventaire.Location = new System.Drawing.Point(19, 55);
            this.dtpDateInventaire.Name = "dtpDateInventaire";
            this.dtpDateInventaire.Size = new System.Drawing.Size(99, 20);
            this.dtpDateInventaire.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtObservation);
            this.groupBox1.Controls.Add(this.gridInventaire);
            this.groupBox1.Controls.Add(this.cmdSupprimer);
            this.groupBox1.Controls.Add(this.cmdValider);
            this.groupBox1.Controls.Add(this.dtpDateInventaire);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(541, 190);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nouvel inventaire";
            // 
            // txtObservation
            // 
            this.txtObservation.Location = new System.Drawing.Point(19, 91);
            this.txtObservation.Multiline = true;
            this.txtObservation.Name = "txtObservation";
            this.txtObservation.Size = new System.Drawing.Size(100, 82);
            this.txtObservation.TabIndex = 3;
            // 
            // gridInventaire
            // 
            this.gridInventaire.AllowUserToAddRows = false;
            this.gridInventaire.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.gridInventaire.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridInventaire.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridInventaire.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridInventaire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridInventaire.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDateInvDataGridViewTextBoxColumn,
            this.dateInvDataGridViewTextBoxColumn,
            this.heureInvDataGridViewTextBoxColumn,
            this.observationInvDataGridViewTextBoxColumn,
            this.valideInvDataGridViewCheckBoxColumn});
            this.gridInventaire.DataSource = this.dateInventaireBOBindingSource;
            this.gridInventaire.Location = new System.Drawing.Point(221, 24);
            this.gridInventaire.MultiSelect = false;
            this.gridInventaire.Name = "gridInventaire";
            this.gridInventaire.ReadOnly = true;
            this.gridInventaire.RowTemplate.Height = 20;
            this.gridInventaire.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridInventaire.Size = new System.Drawing.Size(302, 149);
            this.gridInventaire.TabIndex = 2;
            this.gridInventaire.SelectionChanged += new System.EventHandler(this.gridInventaire_SelectionChanged);
            // 
            // idDateInvDataGridViewTextBoxColumn
            // 
            this.idDateInvDataGridViewTextBoxColumn.DataPropertyName = "IdDateInv";
            this.idDateInvDataGridViewTextBoxColumn.HeaderText = "IdDateInv";
            this.idDateInvDataGridViewTextBoxColumn.Name = "idDateInvDataGridViewTextBoxColumn";
            this.idDateInvDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDateInvDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateInvDataGridViewTextBoxColumn
            // 
            this.dateInvDataGridViewTextBoxColumn.DataPropertyName = "DateInv";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dateInvDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.dateInvDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateInvDataGridViewTextBoxColumn.Name = "dateInvDataGridViewTextBoxColumn";
            this.dateInvDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateInvDataGridViewTextBoxColumn.Width = 80;
            // 
            // heureInvDataGridViewTextBoxColumn
            // 
            this.heureInvDataGridViewTextBoxColumn.DataPropertyName = "HeureInv";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.heureInvDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.heureInvDataGridViewTextBoxColumn.HeaderText = "Heure";
            this.heureInvDataGridViewTextBoxColumn.Name = "heureInvDataGridViewTextBoxColumn";
            this.heureInvDataGridViewTextBoxColumn.ReadOnly = true;
            this.heureInvDataGridViewTextBoxColumn.Width = 80;
            // 
            // observationInvDataGridViewTextBoxColumn
            // 
            this.observationInvDataGridViewTextBoxColumn.DataPropertyName = "ObservationInv";
            this.observationInvDataGridViewTextBoxColumn.HeaderText = "Observation";
            this.observationInvDataGridViewTextBoxColumn.Name = "observationInvDataGridViewTextBoxColumn";
            this.observationInvDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valideInvDataGridViewCheckBoxColumn
            // 
            this.valideInvDataGridViewCheckBoxColumn.DataPropertyName = "ValideInv";
            this.valideInvDataGridViewCheckBoxColumn.HeaderText = "ValideInv";
            this.valideInvDataGridViewCheckBoxColumn.Name = "valideInvDataGridViewCheckBoxColumn";
            this.valideInvDataGridViewCheckBoxColumn.ReadOnly = true;
            this.valideInvDataGridViewCheckBoxColumn.Visible = false;
            // 
            // dateInventaireBOBindingSource
            // 
            this.dateInventaireBOBindingSource.DataSource = typeof(App.BusinessObject.DateInventaireBO);
            // 
            // cmdSupprimer
            // 
            this.cmdSupprimer.Image = global::App.EasyShop.Properties.Resources.button_cancel;
            this.cmdSupprimer.Location = new System.Drawing.Point(133, 100);
            this.cmdSupprimer.Name = "cmdSupprimer";
            this.cmdSupprimer.Size = new System.Drawing.Size(73, 40);
            this.cmdSupprimer.TabIndex = 1;
            this.toolTip.SetToolTip(this.cmdSupprimer, "Supprimer");
            this.cmdSupprimer.UseVisualStyleBackColor = true;
            this.cmdSupprimer.Click += new System.EventHandler(this.cmdSupprimer_Click);
            // 
            // cmdValider
            // 
            this.cmdValider.Image = global::App.EasyShop.Properties.Resources.button_ok;
            this.cmdValider.Location = new System.Drawing.Point(133, 54);
            this.cmdValider.Name = "cmdValider";
            this.cmdValider.Size = new System.Drawing.Size(73, 40);
            this.cmdValider.TabIndex = 1;
            this.toolTip.SetToolTip(this.cmdValider, "Ajouter");
            this.cmdValider.UseVisualStyleBackColor = true;
            this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtArticleRestant);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.gridArticleInventaire);
            this.groupBox2.Controls.Add(this.cmdSupprimerArt);
            this.groupBox2.Controls.Add(this.cmdModifierArt);
            this.groupBox2.Controls.Add(this.cmValiderArt);
            this.groupBox2.Controls.Add(this.txtQteCompte);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbxArticle);
            this.groupBox2.Location = new System.Drawing.Point(15, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(541, 232);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Articles inventoriés";
            // 
            // txtArticleRestant
            // 
            this.txtArticleRestant.Location = new System.Drawing.Point(472, 22);
            this.txtArticleRestant.Name = "txtArticleRestant";
            this.txtArticleRestant.ReadOnly = true;
            this.txtArticleRestant.Size = new System.Drawing.Size(50, 20);
            this.txtArticleRestant.TabIndex = 7;
            this.txtArticleRestant.Text = "0,00";
            this.txtArticleRestant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtArticleRestant.Value = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre d\'Articles";
            // 
            // gridArticleInventaire
            // 
            this.gridArticleInventaire.AllowUserToAddRows = false;
            this.gridArticleInventaire.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
            this.gridArticleInventaire.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gridArticleInventaire.AutoGenerateColumns = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridArticleInventaire.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridArticleInventaire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridArticleInventaire.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdInv,
            this.LibelleArt,
            this.QtePhysInv,
            this.QteStockInv,
            this.EcartInv,
            this.ObservationInv,
            this.IdDateInv,
            this.IdArt,
            this.idInvDataGridViewTextBoxColumn,
            this.libelleArtDataGridViewTextBoxColumn,
            this.qtePhysInvDataGridViewTextBoxColumn,
            this.qteStockInvDataGridViewTextBoxColumn,
            this.ecartInvDataGridViewTextBoxColumn,
            this.observationInvDataGridViewTextBoxColumn1,
            this.idDateInvDataGridViewTextBoxColumn1,
            this.idArtDataGridViewTextBoxColumn});
            this.gridArticleInventaire.DataSource = this.inventaireBOBindingSource;
            this.gridArticleInventaire.Location = new System.Drawing.Point(229, 62);
            this.gridArticleInventaire.MultiSelect = false;
            this.gridArticleInventaire.Name = "gridArticleInventaire";
            this.gridArticleInventaire.ReadOnly = true;
            this.gridArticleInventaire.RowTemplate.Height = 20;
            this.gridArticleInventaire.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridArticleInventaire.Size = new System.Drawing.Size(294, 148);
            this.gridArticleInventaire.TabIndex = 5;
            this.gridArticleInventaire.SelectionChanged += new System.EventHandler(this.gridArticleInventaire_SelectionChanged);
            // 
            // IdInv
            // 
            this.IdInv.DataPropertyName = "IdInv";
            this.IdInv.HeaderText = "IdInv";
            this.IdInv.Name = "IdInv";
            this.IdInv.ReadOnly = true;
            this.IdInv.Visible = false;
            this.IdInv.Width = 140;
            // 
            // LibelleArt
            // 
            this.LibelleArt.DataPropertyName = "LibelleArt";
            this.LibelleArt.HeaderText = "Article";
            this.LibelleArt.Name = "LibelleArt";
            this.LibelleArt.ReadOnly = true;
            this.LibelleArt.Width = 180;
            // 
            // QtePhysInv
            // 
            this.QtePhysInv.DataPropertyName = "QtePhysInv";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.QtePhysInv.DefaultCellStyle = dataGridViewCellStyle7;
            this.QtePhysInv.HeaderText = "Qté. Phys.";
            this.QtePhysInv.Name = "QtePhysInv";
            this.QtePhysInv.ReadOnly = true;
            this.QtePhysInv.Width = 80;
            // 
            // QteStockInv
            // 
            this.QteStockInv.DataPropertyName = "QteStockInv";
            this.QteStockInv.HeaderText = "Qté. Stock";
            this.QteStockInv.Name = "QteStockInv";
            this.QteStockInv.ReadOnly = true;
            this.QteStockInv.Visible = false;
            // 
            // EcartInv
            // 
            this.EcartInv.DataPropertyName = "EcartInv";
            this.EcartInv.HeaderText = "Ecart";
            this.EcartInv.Name = "EcartInv";
            this.EcartInv.ReadOnly = true;
            this.EcartInv.Visible = false;
            // 
            // ObservationInv
            // 
            this.ObservationInv.DataPropertyName = "ObservationInv";
            this.ObservationInv.HeaderText = "Observation";
            this.ObservationInv.Name = "ObservationInv";
            this.ObservationInv.ReadOnly = true;
            this.ObservationInv.Visible = false;
            // 
            // IdDateInv
            // 
            this.IdDateInv.DataPropertyName = "IdDateInv";
            this.IdDateInv.HeaderText = "IdDateInv";
            this.IdDateInv.Name = "IdDateInv";
            this.IdDateInv.ReadOnly = true;
            this.IdDateInv.Visible = false;
            // 
            // IdArt
            // 
            this.IdArt.DataPropertyName = "IdArt";
            this.IdArt.HeaderText = "IdArt";
            this.IdArt.Name = "IdArt";
            this.IdArt.ReadOnly = true;
            this.IdArt.Visible = false;
            // 
            // idInvDataGridViewTextBoxColumn
            // 
            this.idInvDataGridViewTextBoxColumn.DataPropertyName = "IdInv";
            this.idInvDataGridViewTextBoxColumn.HeaderText = "IdInv";
            this.idInvDataGridViewTextBoxColumn.Name = "idInvDataGridViewTextBoxColumn";
            this.idInvDataGridViewTextBoxColumn.ReadOnly = true;
            this.idInvDataGridViewTextBoxColumn.Visible = false;
            // 
            // libelleArtDataGridViewTextBoxColumn
            // 
            this.libelleArtDataGridViewTextBoxColumn.DataPropertyName = "LibelleArt";
            this.libelleArtDataGridViewTextBoxColumn.HeaderText = "LibelleArt";
            this.libelleArtDataGridViewTextBoxColumn.Name = "libelleArtDataGridViewTextBoxColumn";
            this.libelleArtDataGridViewTextBoxColumn.ReadOnly = true;
            this.libelleArtDataGridViewTextBoxColumn.Visible = false;
            // 
            // qtePhysInvDataGridViewTextBoxColumn
            // 
            this.qtePhysInvDataGridViewTextBoxColumn.DataPropertyName = "QtePhysInv";
            this.qtePhysInvDataGridViewTextBoxColumn.HeaderText = "QtePhysInv";
            this.qtePhysInvDataGridViewTextBoxColumn.Name = "qtePhysInvDataGridViewTextBoxColumn";
            this.qtePhysInvDataGridViewTextBoxColumn.ReadOnly = true;
            this.qtePhysInvDataGridViewTextBoxColumn.Visible = false;
            // 
            // qteStockInvDataGridViewTextBoxColumn
            // 
            this.qteStockInvDataGridViewTextBoxColumn.DataPropertyName = "QteStockInv";
            this.qteStockInvDataGridViewTextBoxColumn.HeaderText = "QteStockInv";
            this.qteStockInvDataGridViewTextBoxColumn.Name = "qteStockInvDataGridViewTextBoxColumn";
            this.qteStockInvDataGridViewTextBoxColumn.ReadOnly = true;
            this.qteStockInvDataGridViewTextBoxColumn.Visible = false;
            // 
            // ecartInvDataGridViewTextBoxColumn
            // 
            this.ecartInvDataGridViewTextBoxColumn.DataPropertyName = "EcartInv";
            this.ecartInvDataGridViewTextBoxColumn.HeaderText = "EcartInv";
            this.ecartInvDataGridViewTextBoxColumn.Name = "ecartInvDataGridViewTextBoxColumn";
            this.ecartInvDataGridViewTextBoxColumn.ReadOnly = true;
            this.ecartInvDataGridViewTextBoxColumn.Visible = false;
            // 
            // observationInvDataGridViewTextBoxColumn1
            // 
            this.observationInvDataGridViewTextBoxColumn1.DataPropertyName = "ObservationInv";
            this.observationInvDataGridViewTextBoxColumn1.HeaderText = "ObservationInv";
            this.observationInvDataGridViewTextBoxColumn1.Name = "observationInvDataGridViewTextBoxColumn1";
            this.observationInvDataGridViewTextBoxColumn1.ReadOnly = true;
            this.observationInvDataGridViewTextBoxColumn1.Visible = false;
            // 
            // idDateInvDataGridViewTextBoxColumn1
            // 
            this.idDateInvDataGridViewTextBoxColumn1.DataPropertyName = "IdDateInv";
            this.idDateInvDataGridViewTextBoxColumn1.HeaderText = "IdDateInv";
            this.idDateInvDataGridViewTextBoxColumn1.Name = "idDateInvDataGridViewTextBoxColumn1";
            this.idDateInvDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDateInvDataGridViewTextBoxColumn1.Visible = false;
            // 
            // idArtDataGridViewTextBoxColumn
            // 
            this.idArtDataGridViewTextBoxColumn.DataPropertyName = "IdArt";
            this.idArtDataGridViewTextBoxColumn.HeaderText = "IdArt";
            this.idArtDataGridViewTextBoxColumn.Name = "idArtDataGridViewTextBoxColumn";
            this.idArtDataGridViewTextBoxColumn.ReadOnly = true;
            this.idArtDataGridViewTextBoxColumn.Visible = false;
            // 
            // inventaireBOBindingSource
            // 
            this.inventaireBOBindingSource.DataSource = typeof(App.BusinessObject.InventaireBO);
            // 
            // cmdSupprimerArt
            // 
            this.cmdSupprimerArt.Image = global::App.EasyShop.Properties.Resources.button_cancel;
            this.cmdSupprimerArt.Location = new System.Drawing.Point(156, 171);
            this.cmdSupprimerArt.Name = "cmdSupprimerArt";
            this.cmdSupprimerArt.Size = new System.Drawing.Size(56, 40);
            this.cmdSupprimerArt.TabIndex = 4;
            this.toolTip.SetToolTip(this.cmdSupprimerArt, "Supprimer");
            this.cmdSupprimerArt.UseVisualStyleBackColor = true;
            this.cmdSupprimerArt.Click += new System.EventHandler(this.cmdSupprimerArt_Click);
            // 
            // cmdModifierArt
            // 
            this.cmdModifierArt.Image = global::App.EasyShop.Properties.Resources.edit;
            this.cmdModifierArt.Location = new System.Drawing.Point(94, 171);
            this.cmdModifierArt.Name = "cmdModifierArt";
            this.cmdModifierArt.Size = new System.Drawing.Size(56, 40);
            this.cmdModifierArt.TabIndex = 4;
            this.toolTip.SetToolTip(this.cmdModifierArt, "Modifier");
            this.cmdModifierArt.UseVisualStyleBackColor = true;
            this.cmdModifierArt.Click += new System.EventHandler(this.cmdModifierArt_Click);
            // 
            // cmValiderArt
            // 
            this.cmValiderArt.Image = global::App.EasyShop.Properties.Resources.button_ok;
            this.cmValiderArt.Location = new System.Drawing.Point(32, 171);
            this.cmValiderArt.Name = "cmValiderArt";
            this.cmValiderArt.Size = new System.Drawing.Size(56, 40);
            this.cmValiderArt.TabIndex = 4;
            this.toolTip.SetToolTip(this.cmValiderArt, "Valider");
            this.cmValiderArt.UseVisualStyleBackColor = true;
            this.cmValiderArt.Click += new System.EventHandler(this.cmValiderArt_Click);
            // 
            // txtQteCompte
            // 
            this.txtQteCompte.Location = new System.Drawing.Point(81, 104);
            this.txtQteCompte.Name = "txtQteCompte";
            this.txtQteCompte.Size = new System.Drawing.Size(131, 20);
            this.txtQteCompte.TabIndex = 3;
            this.txtQteCompte.Text = "0,00";
            this.txtQteCompte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQteCompte.Value = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Qté. phys.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Article";
            // 
            // cbxArticle
            // 
            this.cbxArticle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxArticle.DropDownWidth = 200;
            this.cbxArticle.FormattingEnabled = true;
            this.cbxArticle.Location = new System.Drawing.Point(81, 64);
            this.cbxArticle.Name = "cbxArticle";
            this.cbxArticle.Size = new System.Drawing.Size(131, 21);
            this.cbxArticle.TabIndex = 0;
            this.cbxArticle.SelectedValueChanged += new System.EventHandler(this.cbxArticle_SelectedValueChanged);
            // 
            // cmdQuitter
            // 
            this.cmdQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdQuitter.Image = global::App.EasyShop.Properties.Resources.exit;
            this.cmdQuitter.Location = new System.Drawing.Point(483, 460);
            this.cmdQuitter.Name = "cmdQuitter";
            this.cmdQuitter.Size = new System.Drawing.Size(73, 40);
            this.cmdQuitter.TabIndex = 3;
            this.toolTip.SetToolTip(this.cmdQuitter, "Fermer");
            this.cmdQuitter.UseVisualStyleBackColor = true;
            this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
            // 
            // cmdDebloquer
            // 
            this.cmdDebloquer.Image = global::App.EasyShop.Properties.Resources.password;
            this.cmdDebloquer.Location = new System.Drawing.Point(15, 460);
            this.cmdDebloquer.Name = "cmdDebloquer";
            this.cmdDebloquer.Size = new System.Drawing.Size(73, 40);
            this.cmdDebloquer.TabIndex = 4;
            this.toolTip.SetToolTip(this.cmdDebloquer, "Débloquer");
            this.cmdDebloquer.UseVisualStyleBackColor = true;
            this.cmdDebloquer.Click += new System.EventHandler(this.cmdDebloquer_Click);
            // 
            // FormInventaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdQuitter;
            this.ClientSize = new System.Drawing.Size(568, 509);
            this.Controls.Add(this.cmdDebloquer);
            this.Controls.Add(this.cmdQuitter);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormInventaire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventaire des articles";
            this.Load += new System.EventHandler(this.FormInventaire_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormInventaire_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridInventaire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateInventaireBOBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridArticleInventaire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventaireBOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDateInventaire;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdSupprimer;
        private System.Windows.Forms.Button cmdValider;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdQuitter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxArticle;
        private App.Tools.AppNumericTextBox txtQteCompte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdSupprimerArt;
        private System.Windows.Forms.Button cmdModifierArt;
        private System.Windows.Forms.Button cmValiderArt;
        private System.Windows.Forms.DataGridView gridArticleInventaire;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button cmdDebloquer;
        private System.Windows.Forms.DataGridView gridInventaire;
        private System.Windows.Forms.BindingSource dateInventaireBOBindingSource;
        private System.Windows.Forms.TextBox txtObservation;
        private System.Windows.Forms.BindingSource inventaireBOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDateInvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateInvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heureInvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observationInvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn valideInvDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Label label2;
        private App.Tools.AppNumericTextBox txtArticleRestant;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdInv;
        private System.Windows.Forms.DataGridViewTextBoxColumn LibelleArt;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtePhysInv;
        private System.Windows.Forms.DataGridViewTextBoxColumn QteStockInv;
        private System.Windows.Forms.DataGridViewTextBoxColumn EcartInv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObservationInv;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDateInv;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdArt;
        private System.Windows.Forms.DataGridViewTextBoxColumn idInvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleArtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtePhysInvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qteStockInvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ecartInvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observationInvDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDateInvDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArtDataGridViewTextBoxColumn;
    }
}