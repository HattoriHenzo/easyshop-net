namespace App.EasyShop.FormVente
{
    partial class FormVentes
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtRemiseMontant = new App.Tools.AppNumericTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cbxRemisePourcentage = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbxTypeVente = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCategorie = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmdArticles = new System.Windows.Forms.Button();
            this.txtSeuil = new System.Windows.Forms.TextBox();
            this.txtEtatArticle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtQteStock = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrixVente = new App.Tools.AppNumericTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxArticle = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNumeroVente = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtQteModif = new App.Tools.AppNumericTextBox();
            this.cmdValiderVente = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSousTotal = new App.Tools.AppNumericTextBox();
            this.gridArticlesAchetes = new System.Windows.Forms.DataGridView();
            this.idArchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateVenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heureVenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idArtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelleArtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeVenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixVenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qteVenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remisePourcentageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remiseMontantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalVenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelleCatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroVenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.archiveVenteBOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.cmdRetirer = new System.Windows.Forms.Button();
            this.cmdAjouter = new System.Windows.Forms.Button();
            this.cmdSupprimer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDateJour = new System.Windows.Forms.DateTimePicker();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cmdQuitter = new System.Windows.Forms.Button();
            this.cmdInsertPanier = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTotalAchat = new App.Tools.AppNumericTextBox();
            this.txtQteAchete = new App.Tools.AppNumericTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridArticlesAchetes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.archiveVenteBOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date du jour";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.txtRemiseMontant);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.cbxRemisePourcentage);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.cbxTypeVente);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtCategorie);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cmdArticles);
            this.groupBox1.Controls.Add(this.txtSeuil);
            this.groupBox1.Controls.Add(this.txtEtatArticle);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtQteStock);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtPrixVente);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbxArticle);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(12, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 405);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Articles";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(248, 173);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(27, 13);
            this.label19.TabIndex = 22;
            this.label19.Text = "CFA";
            // 
            // txtRemiseMontant
            // 
            this.txtRemiseMontant.Location = new System.Drawing.Point(106, 166);
            this.txtRemiseMontant.Name = "txtRemiseMontant";
            this.txtRemiseMontant.Size = new System.Drawing.Size(138, 20);
            this.txtRemiseMontant.TabIndex = 21;
            this.txtRemiseMontant.Text = "0,00";
            this.txtRemiseMontant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRemiseMontant.Value = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(24, 173);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 13);
            this.label18.TabIndex = 20;
            this.label18.Text = "Remise en CFA";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(252, 128);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(15, 13);
            this.label17.TabIndex = 19;
            this.label17.Text = "%";
            // 
            // cbxRemisePourcentage
            // 
            this.cbxRemisePourcentage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRemisePourcentage.FormattingEnabled = true;
            this.cbxRemisePourcentage.Items.AddRange(new object[] {
            "0",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30"});
            this.cbxRemisePourcentage.Location = new System.Drawing.Point(106, 122);
            this.cbxRemisePourcentage.Name = "cbxRemisePourcentage";
            this.cbxRemisePourcentage.Size = new System.Drawing.Size(138, 21);
            this.cbxRemisePourcentage.TabIndex = 18;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(24, 130);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 13);
            this.label16.TabIndex = 17;
            this.label16.Text = "Remise en %";
            // 
            // cbxTypeVente
            // 
            this.cbxTypeVente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTypeVente.FormattingEnabled = true;
            this.cbxTypeVente.Items.AddRange(new object[] {
            "DETAIL",
            "DEMI GROS",
            "GROS"});
            this.cbxTypeVente.Location = new System.Drawing.Point(106, 82);
            this.cbxTypeVente.Name = "cbxTypeVente";
            this.cbxTypeVente.Size = new System.Drawing.Size(138, 21);
            this.cbxTypeVente.TabIndex = 16;
            this.cbxTypeVente.SelectedIndexChanged += new System.EventHandler(this.cbxTypeVente_SelectedIndexChanged);
            this.cbxTypeVente.SelectedValueChanged += new System.EventHandler(this.cbxTypeVente_SelectedValueChanged);
            this.cbxTypeVente.Click += new System.EventHandler(this.cbxTypeVente_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(24, 90);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Vente en";
            // 
            // txtCategorie
            // 
            this.txtCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategorie.Location = new System.Drawing.Point(106, 209);
            this.txtCategorie.Name = "txtCategorie";
            this.txtCategorie.ReadOnly = true;
            this.txtCategorie.Size = new System.Drawing.Size(138, 20);
            this.txtCategorie.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 216);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Catégorie";
            // 
            // cmdArticles
            // 
            this.cmdArticles.Location = new System.Drawing.Point(250, 41);
            this.cmdArticles.Name = "cmdArticles";
            this.cmdArticles.Size = new System.Drawing.Size(24, 23);
            this.cmdArticles.TabIndex = 12;
            this.cmdArticles.Text = "...";
            this.toolTip.SetToolTip(this.cmdArticles, "Recherche rapide");
            this.cmdArticles.UseVisualStyleBackColor = true;
            this.cmdArticles.Click += new System.EventHandler(this.cmdArticles_Click);
            // 
            // txtSeuil
            // 
            this.txtSeuil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeuil.Location = new System.Drawing.Point(106, 326);
            this.txtSeuil.Name = "txtSeuil";
            this.txtSeuil.ReadOnly = true;
            this.txtSeuil.Size = new System.Drawing.Size(138, 20);
            this.txtSeuil.TabIndex = 11;
            this.txtSeuil.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtEtatArticle
            // 
            this.txtEtatArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEtatArticle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEtatArticle.Location = new System.Drawing.Point(106, 365);
            this.txtEtatArticle.Name = "txtEtatArticle";
            this.txtEtatArticle.ReadOnly = true;
            this.txtEtatArticle.Size = new System.Drawing.Size(168, 20);
            this.txtEtatArticle.TabIndex = 12;
            this.txtEtatArticle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEtatArticle.TextChanged += new System.EventHandler(this.txtEtatArticle_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Etat de l\'article";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 333);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Seuil";
            // 
            // txtQteStock
            // 
            this.txtQteStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQteStock.Location = new System.Drawing.Point(106, 287);
            this.txtQteStock.Name = "txtQteStock";
            this.txtQteStock.ReadOnly = true;
            this.txtQteStock.Size = new System.Drawing.Size(138, 20);
            this.txtQteStock.TabIndex = 9;
            this.txtQteStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 294);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Qté Stock";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtPrixVente
            // 
            this.txtPrixVente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrixVente.Location = new System.Drawing.Point(106, 248);
            this.txtPrixVente.Name = "txtPrixVente";
            this.txtPrixVente.Size = new System.Drawing.Size(138, 20);
            this.txtPrixVente.TabIndex = 7;
            this.txtPrixVente.Text = "0,00";
            this.txtPrixVente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrixVente.Value = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Prix Vente";
            // 
            // cbxArticle
            // 
            this.cbxArticle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxArticle.DropDownWidth = 200;
            this.cbxArticle.FormattingEnabled = true;
            this.cbxArticle.Location = new System.Drawing.Point(106, 42);
            this.cbxArticle.Name = "cbxArticle";
            this.cbxArticle.Size = new System.Drawing.Size(138, 21);
            this.cbxArticle.TabIndex = 5;
            this.cbxArticle.SelectedValueChanged += new System.EventHandler(this.cbxArticle_SelectedValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Article";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNumeroVente);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtQteModif);
            this.groupBox2.Controls.Add(this.cmdValiderVente);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtSousTotal);
            this.groupBox2.Controls.Add(this.gridArticlesAchetes);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmdRetirer);
            this.groupBox2.Controls.Add(this.cmdAjouter);
            this.groupBox2.Controls.Add(this.cmdSupprimer);
            this.groupBox2.Location = new System.Drawing.Point(406, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(546, 404);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Liste des achats";
            // 
            // txtNumeroVente
            // 
            this.txtNumeroVente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroVente.Location = new System.Drawing.Point(318, 42);
            this.txtNumeroVente.Name = "txtNumeroVente";
            this.txtNumeroVente.ReadOnly = true;
            this.txtNumeroVente.Size = new System.Drawing.Size(146, 20);
            this.txtNumeroVente.TabIndex = 18;
            this.txtNumeroVente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(262, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "N° Vente";
            // 
            // txtQteModif
            // 
            this.txtQteModif.Location = new System.Drawing.Point(480, 108);
            this.txtQteModif.Name = "txtQteModif";
            this.txtQteModif.Size = new System.Drawing.Size(50, 20);
            this.txtQteModif.TabIndex = 16;
            this.txtQteModif.Text = "0,00";
            this.txtQteModif.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQteModif.Value = "0";
            // 
            // cmdValiderVente
            // 
            this.cmdValiderVente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdValiderVente.Image = global::App.EasyShop.Properties.Resources.button_ok;
            this.cmdValiderVente.Location = new System.Drawing.Point(16, 354);
            this.cmdValiderVente.Name = "cmdValiderVente";
            this.cmdValiderVente.Size = new System.Drawing.Size(70, 38);
            this.cmdValiderVente.TabIndex = 14;
            this.toolTip.SetToolTip(this.cmdValiderVente, "Valider la vente");
            this.cmdValiderVente.UseVisualStyleBackColor = true;
            this.cmdValiderVente.Click += new System.EventHandler(this.cmdValiderVente_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(436, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "CFA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(481, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Quantité";
            // 
            // txtSousTotal
            // 
            this.txtSousTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSousTotal.Location = new System.Drawing.Point(328, 364);
            this.txtSousTotal.Name = "txtSousTotal";
            this.txtSousTotal.ReadOnly = true;
            this.txtSousTotal.Size = new System.Drawing.Size(102, 20);
            this.txtSousTotal.TabIndex = 2;
            this.txtSousTotal.Text = "0,00";
            this.txtSousTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSousTotal.Value = "0";
            // 
            // gridArticlesAchetes
            // 
            this.gridArticlesAchetes.AllowUserToAddRows = false;
            this.gridArticlesAchetes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.gridArticlesAchetes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridArticlesAchetes.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridArticlesAchetes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridArticlesAchetes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridArticlesAchetes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idArchDataGridViewTextBoxColumn,
            this.dateVenteDataGridViewTextBoxColumn,
            this.heureVenteDataGridViewTextBoxColumn,
            this.idArtDataGridViewTextBoxColumn,
            this.libelleArtDataGridViewTextBoxColumn,
            this.typeVenteDataGridViewTextBoxColumn,
            this.prixVenteDataGridViewTextBoxColumn,
            this.qteVenteDataGridViewTextBoxColumn,
            this.remisePourcentageDataGridViewTextBoxColumn,
            this.remiseMontantDataGridViewTextBoxColumn,
            this.totalVenteDataGridViewTextBoxColumn,
            this.libelleCatDataGridViewTextBoxColumn,
            this.idUserDataGridViewTextBoxColumn,
            this.numeroVenteDataGridViewTextBoxColumn});
            this.gridArticlesAchetes.DataSource = this.archiveVenteBOBindingSource;
            this.gridArticlesAchetes.Location = new System.Drawing.Point(16, 81);
            this.gridArticlesAchetes.MultiSelect = false;
            this.gridArticlesAchetes.Name = "gridArticlesAchetes";
            this.gridArticlesAchetes.ReadOnly = true;
            this.gridArticlesAchetes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridArticlesAchetes.Size = new System.Drawing.Size(448, 264);
            this.gridArticlesAchetes.TabIndex = 0;
            this.gridArticlesAchetes.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gridArticlesAchetes_RowsAdded);
            this.gridArticlesAchetes.SelectionChanged += new System.EventHandler(this.gridArticlesAchetes_SelectionChanged);
            // 
            // idArchDataGridViewTextBoxColumn
            // 
            this.idArchDataGridViewTextBoxColumn.DataPropertyName = "IdArch";
            this.idArchDataGridViewTextBoxColumn.HeaderText = "IdArch";
            this.idArchDataGridViewTextBoxColumn.Name = "idArchDataGridViewTextBoxColumn";
            this.idArchDataGridViewTextBoxColumn.ReadOnly = true;
            this.idArchDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateVenteDataGridViewTextBoxColumn
            // 
            this.dateVenteDataGridViewTextBoxColumn.DataPropertyName = "DateVente";
            this.dateVenteDataGridViewTextBoxColumn.HeaderText = "DateVente";
            this.dateVenteDataGridViewTextBoxColumn.Name = "dateVenteDataGridViewTextBoxColumn";
            this.dateVenteDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateVenteDataGridViewTextBoxColumn.Visible = false;
            // 
            // heureVenteDataGridViewTextBoxColumn
            // 
            this.heureVenteDataGridViewTextBoxColumn.DataPropertyName = "HeureVente";
            this.heureVenteDataGridViewTextBoxColumn.HeaderText = "HeureVente";
            this.heureVenteDataGridViewTextBoxColumn.Name = "heureVenteDataGridViewTextBoxColumn";
            this.heureVenteDataGridViewTextBoxColumn.ReadOnly = true;
            this.heureVenteDataGridViewTextBoxColumn.Visible = false;
            // 
            // idArtDataGridViewTextBoxColumn
            // 
            this.idArtDataGridViewTextBoxColumn.DataPropertyName = "IdArt";
            this.idArtDataGridViewTextBoxColumn.HeaderText = "IdArt";
            this.idArtDataGridViewTextBoxColumn.Name = "idArtDataGridViewTextBoxColumn";
            this.idArtDataGridViewTextBoxColumn.ReadOnly = true;
            this.idArtDataGridViewTextBoxColumn.Visible = false;
            // 
            // libelleArtDataGridViewTextBoxColumn
            // 
            this.libelleArtDataGridViewTextBoxColumn.DataPropertyName = "LibelleArt";
            this.libelleArtDataGridViewTextBoxColumn.HeaderText = "Article";
            this.libelleArtDataGridViewTextBoxColumn.Name = "libelleArtDataGridViewTextBoxColumn";
            this.libelleArtDataGridViewTextBoxColumn.ReadOnly = true;
            this.libelleArtDataGridViewTextBoxColumn.Width = 200;
            // 
            // typeVenteDataGridViewTextBoxColumn
            // 
            this.typeVenteDataGridViewTextBoxColumn.DataPropertyName = "TypeVente";
            this.typeVenteDataGridViewTextBoxColumn.HeaderText = "Type Vente";
            this.typeVenteDataGridViewTextBoxColumn.Name = "typeVenteDataGridViewTextBoxColumn";
            this.typeVenteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prixVenteDataGridViewTextBoxColumn
            // 
            this.prixVenteDataGridViewTextBoxColumn.DataPropertyName = "PrixVente";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.prixVenteDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.prixVenteDataGridViewTextBoxColumn.HeaderText = "Prix de vente";
            this.prixVenteDataGridViewTextBoxColumn.Name = "prixVenteDataGridViewTextBoxColumn";
            this.prixVenteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qteVenteDataGridViewTextBoxColumn
            // 
            this.qteVenteDataGridViewTextBoxColumn.DataPropertyName = "QteVente";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.qteVenteDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.qteVenteDataGridViewTextBoxColumn.HeaderText = "Qte en Vente";
            this.qteVenteDataGridViewTextBoxColumn.Name = "qteVenteDataGridViewTextBoxColumn";
            this.qteVenteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // remisePourcentageDataGridViewTextBoxColumn
            // 
            this.remisePourcentageDataGridViewTextBoxColumn.DataPropertyName = "RemisePourcentage";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.remisePourcentageDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.remisePourcentageDataGridViewTextBoxColumn.HeaderText = "Remise (%)";
            this.remisePourcentageDataGridViewTextBoxColumn.Name = "remisePourcentageDataGridViewTextBoxColumn";
            this.remisePourcentageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // remiseMontantDataGridViewTextBoxColumn
            // 
            this.remiseMontantDataGridViewTextBoxColumn.DataPropertyName = "RemiseMontant";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.remiseMontantDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.remiseMontantDataGridViewTextBoxColumn.HeaderText = "Remise (CFA)";
            this.remiseMontantDataGridViewTextBoxColumn.Name = "remiseMontantDataGridViewTextBoxColumn";
            this.remiseMontantDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalVenteDataGridViewTextBoxColumn
            // 
            this.totalVenteDataGridViewTextBoxColumn.DataPropertyName = "TotalVente";
            this.totalVenteDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalVenteDataGridViewTextBoxColumn.Name = "totalVenteDataGridViewTextBoxColumn";
            this.totalVenteDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalVenteDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.totalVenteDataGridViewTextBoxColumn.Visible = false;
            // 
            // libelleCatDataGridViewTextBoxColumn
            // 
            this.libelleCatDataGridViewTextBoxColumn.DataPropertyName = "LibelleCat";
            this.libelleCatDataGridViewTextBoxColumn.HeaderText = "Categorie";
            this.libelleCatDataGridViewTextBoxColumn.Name = "libelleCatDataGridViewTextBoxColumn";
            this.libelleCatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idUserDataGridViewTextBoxColumn
            // 
            this.idUserDataGridViewTextBoxColumn.DataPropertyName = "IdUser";
            this.idUserDataGridViewTextBoxColumn.HeaderText = "IdUser";
            this.idUserDataGridViewTextBoxColumn.Name = "idUserDataGridViewTextBoxColumn";
            this.idUserDataGridViewTextBoxColumn.ReadOnly = true;
            this.idUserDataGridViewTextBoxColumn.Visible = false;
            // 
            // numeroVenteDataGridViewTextBoxColumn
            // 
            this.numeroVenteDataGridViewTextBoxColumn.DataPropertyName = "NumeroVente";
            this.numeroVenteDataGridViewTextBoxColumn.HeaderText = "NumeroVente";
            this.numeroVenteDataGridViewTextBoxColumn.Name = "numeroVenteDataGridViewTextBoxColumn";
            this.numeroVenteDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroVenteDataGridViewTextBoxColumn.Visible = false;
            // 
            // archiveVenteBOBindingSource
            // 
            this.archiveVenteBOBindingSource.DataSource = typeof(App.BusinessObject.ArchiveVenteBO);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(253, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Sous-Total";
            // 
            // cmdRetirer
            // 
            this.cmdRetirer.Image = global::App.EasyShop.Properties.Resources.edit_remove;
            this.cmdRetirer.Location = new System.Drawing.Point(480, 185);
            this.cmdRetirer.Name = "cmdRetirer";
            this.cmdRetirer.Size = new System.Drawing.Size(50, 40);
            this.cmdRetirer.TabIndex = 14;
            this.toolTip.SetToolTip(this.cmdRetirer, "Retirer");
            this.cmdRetirer.UseVisualStyleBackColor = true;
            this.cmdRetirer.Click += new System.EventHandler(this.cmdRetirer_Click);
            // 
            // cmdAjouter
            // 
            this.cmdAjouter.Image = global::App.EasyShop.Properties.Resources.edit_add;
            this.cmdAjouter.Location = new System.Drawing.Point(480, 139);
            this.cmdAjouter.Name = "cmdAjouter";
            this.cmdAjouter.Size = new System.Drawing.Size(50, 40);
            this.cmdAjouter.TabIndex = 5;
            this.toolTip.SetToolTip(this.cmdAjouter, "Ajouter");
            this.cmdAjouter.UseVisualStyleBackColor = true;
            this.cmdAjouter.Click += new System.EventHandler(this.cmdAjouter_Click);
            // 
            // cmdSupprimer
            // 
            this.cmdSupprimer.Image = global::App.EasyShop.Properties.Resources.button_cancel;
            this.cmdSupprimer.Location = new System.Drawing.Point(480, 231);
            this.cmdSupprimer.Name = "cmdSupprimer";
            this.cmdSupprimer.Size = new System.Drawing.Size(50, 40);
            this.cmdSupprimer.TabIndex = 3;
            this.toolTip.SetToolTip(this.cmdSupprimer, "Annuler");
            this.cmdSupprimer.UseVisualStyleBackColor = true;
            this.cmdSupprimer.Click += new System.EventHandler(this.cmdSupprimer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(842, 508);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "CFA";
            // 
            // dtpDateJour
            // 
            this.dtpDateJour.Location = new System.Drawing.Point(80, 34);
            this.dtpDateJour.Name = "dtpDateJour";
            this.dtpDateJour.Size = new System.Drawing.Size(176, 20);
            this.dtpDateJour.TabIndex = 10;
            // 
            // cmdQuitter
            // 
            this.cmdQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdQuitter.Image = global::App.EasyShop.Properties.Resources.exit;
            this.cmdQuitter.Location = new System.Drawing.Point(10, 491);
            this.cmdQuitter.Name = "cmdQuitter";
            this.cmdQuitter.Size = new System.Drawing.Size(76, 38);
            this.cmdQuitter.TabIndex = 9;
            this.toolTip.SetToolTip(this.cmdQuitter, "Fermer");
            this.cmdQuitter.UseVisualStyleBackColor = true;
            this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
            // 
            // cmdInsertPanier
            // 
            this.cmdInsertPanier.Image = global::App.EasyShop.Properties.Resources.loopnone;
            this.cmdInsertPanier.Location = new System.Drawing.Point(323, 175);
            this.cmdInsertPanier.Name = "cmdInsertPanier";
            this.cmdInsertPanier.Size = new System.Drawing.Size(70, 38);
            this.cmdInsertPanier.TabIndex = 15;
            this.toolTip.SetToolTip(this.cmdInsertPanier, "Ajouter au panier");
            this.cmdInsertPanier.UseVisualStyleBackColor = true;
            this.cmdInsertPanier.Click += new System.EventHandler(this.cmdInsertPanier_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(326, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Qté. Vendue";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(667, 508);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Total vente";
            // 
            // txtTotalAchat
            // 
            this.txtTotalAchat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAchat.Location = new System.Drawing.Point(734, 501);
            this.txtTotalAchat.Name = "txtTotalAchat";
            this.txtTotalAchat.ReadOnly = true;
            this.txtTotalAchat.Size = new System.Drawing.Size(102, 20);
            this.txtTotalAchat.TabIndex = 7;
            this.txtTotalAchat.Text = "0,00";
            this.txtTotalAchat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalAchat.Value = "0";
            // 
            // txtQteAchete
            // 
            this.txtQteAchete.Location = new System.Drawing.Point(331, 135);
            this.txtQteAchete.Name = "txtQteAchete";
            this.txtQteAchete.Size = new System.Drawing.Size(54, 20);
            this.txtQteAchete.TabIndex = 4;
            this.txtQteAchete.Text = "0,00";
            this.txtQteAchete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQteAchete.Value = "0";
            // 
            // FormVentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdQuitter;
            this.ClientSize = new System.Drawing.Size(964, 534);
            this.Controls.Add(this.cmdInsertPanier);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpDateJour);
            this.Controls.Add(this.cmdQuitter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotalAchat);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtQteAchete);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormVentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion Ventes";
            this.Load += new System.EventHandler(this.FormVentes_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormVentes_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridArticlesAchetes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.archiveVenteBOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdSupprimer;
        private App.Tools.AppNumericTextBox txtQteAchete;
        private System.Windows.Forms.Button cmdAjouter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdQuitter;
        private System.Windows.Forms.DateTimePicker dtpDateJour;
        private System.Windows.Forms.DataGridView gridArticlesAchetes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEtatArticle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cmdRetirer;
        private System.Windows.Forms.ComboBox cbxArticle;
        private System.Windows.Forms.Label label9;
        private App.Tools.AppNumericTextBox txtPrixVente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtQteStock;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSeuil;
        private System.Windows.Forms.Button cmdArticles;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button cmdValiderVente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdInsertPanier;
        private App.Tools.AppNumericTextBox txtQteModif;
        private System.Windows.Forms.TextBox txtCategorie;
        private System.Windows.Forms.Label label13;
        private App.Tools.AppNumericTextBox txtTotalAchat;
        private App.Tools.AppNumericTextBox txtSousTotal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNumeroVente;
        private System.Windows.Forms.ComboBox cbxTypeVente;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbxRemisePourcentage;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.BindingSource archiveVenteBOBindingSource;
        private System.Windows.Forms.Label label19;
        private App.Tools.AppNumericTextBox txtRemiseMontant;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateVenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heureVenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleArtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeVenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixVenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qteVenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remisePourcentageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remiseMontantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalVenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleCatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroVenteDataGridViewTextBoxColumn;
    }
}