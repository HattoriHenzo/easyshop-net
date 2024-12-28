namespace App.EasyShop.FormArticle
{
    partial class FormStockDate
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
            this.btnRecherche = new System.Windows.Forms.Button();
            this.txtArticle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDateAu = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDateDu = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.gridStockDate = new System.Windows.Forms.DataGridView();
            this.idArtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelleArtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qteStockArtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seuilArtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixAchatArtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixVenteArtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixEnDemiGrosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixEnGrosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qteEnGrosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coutSortieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDateBOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmdActualiserStock = new System.Windows.Forms.Button();
            this.cmdQuitter = new System.Windows.Forms.Button();
            this.toolTipStockDate = new System.Windows.Forms.ToolTip(this.components);
            this.txtNombreArticle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPeriodStock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDetailsDateStock = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStockActuel = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridStockDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDateBOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRecherche);
            this.groupBox1.Controls.Add(this.txtArticle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpDateAu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpDateDu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(720, 77);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnRecherche
            // 
            this.btnRecherche.Image = global::App.EasyShop.Properties.Resources.Search;
            this.btnRecherche.Location = new System.Drawing.Point(631, 19);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(75, 42);
            this.btnRecherche.TabIndex = 6;
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
            // 
            // txtArticle
            // 
            this.txtArticle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtArticle.Location = new System.Drawing.Point(356, 31);
            this.txtArticle.Name = "txtArticle";
            this.txtArticle.Size = new System.Drawing.Size(263, 20);
            this.txtArticle.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Article";
            // 
            // dtpDateAu
            // 
            this.dtpDateAu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateAu.Location = new System.Drawing.Point(198, 32);
            this.dtpDateAu.Name = "dtpDateAu";
            this.dtpDateAu.Size = new System.Drawing.Size(95, 20);
            this.dtpDateAu.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Au";
            // 
            // dtpDateDu
            // 
            this.dtpDateDu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateDu.Location = new System.Drawing.Point(43, 32);
            this.dtpDateDu.Name = "dtpDateDu";
            this.dtpDateDu.Size = new System.Drawing.Size(100, 20);
            this.dtpDateDu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Du";
            // 
            // gridStockDate
            // 
            this.gridStockDate.AllowUserToAddRows = false;
            this.gridStockDate.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.gridStockDate.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridStockDate.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridStockDate.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridStockDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStockDate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idArtDataGridViewTextBoxColumn,
            this.libelleArtDataGridViewTextBoxColumn,
            this.qteStockArtDataGridViewTextBoxColumn,
            this.seuilArtDataGridViewTextBoxColumn,
            this.prixAchatArtDataGridViewTextBoxColumn,
            this.prixVenteArtDataGridViewTextBoxColumn,
            this.prixEnDemiGrosDataGridViewTextBoxColumn,
            this.prixEnGrosDataGridViewTextBoxColumn,
            this.qteEnGrosDataGridViewTextBoxColumn,
            this.coutSortieDataGridViewTextBoxColumn,
            this.categorieDataGridViewTextBoxColumn});
            this.gridStockDate.DataSource = this.stockDateBOBindingSource;
            this.gridStockDate.Location = new System.Drawing.Point(12, 152);
            this.gridStockDate.Name = "gridStockDate";
            this.gridStockDate.ReadOnly = true;
            this.gridStockDate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridStockDate.Size = new System.Drawing.Size(720, 285);
            this.gridStockDate.TabIndex = 1;
            this.gridStockDate.SelectionChanged += new System.EventHandler(this.gridStockDate_SelectionChanged);
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
            // qteStockArtDataGridViewTextBoxColumn
            // 
            this.qteStockArtDataGridViewTextBoxColumn.DataPropertyName = "QteStockArt";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.qteStockArtDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.qteStockArtDataGridViewTextBoxColumn.HeaderText = "Quantité en stock";
            this.qteStockArtDataGridViewTextBoxColumn.Name = "qteStockArtDataGridViewTextBoxColumn";
            this.qteStockArtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // seuilArtDataGridViewTextBoxColumn
            // 
            this.seuilArtDataGridViewTextBoxColumn.DataPropertyName = "SeuilArt";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.seuilArtDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.seuilArtDataGridViewTextBoxColumn.HeaderText = "Seuil";
            this.seuilArtDataGridViewTextBoxColumn.Name = "seuilArtDataGridViewTextBoxColumn";
            this.seuilArtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prixAchatArtDataGridViewTextBoxColumn
            // 
            this.prixAchatArtDataGridViewTextBoxColumn.DataPropertyName = "PrixAchatArt";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.prixAchatArtDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.prixAchatArtDataGridViewTextBoxColumn.HeaderText = "Prix d\'achat";
            this.prixAchatArtDataGridViewTextBoxColumn.Name = "prixAchatArtDataGridViewTextBoxColumn";
            this.prixAchatArtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prixVenteArtDataGridViewTextBoxColumn
            // 
            this.prixVenteArtDataGridViewTextBoxColumn.DataPropertyName = "PrixVenteArt";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.prixVenteArtDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.prixVenteArtDataGridViewTextBoxColumn.HeaderText = "Prix en détail";
            this.prixVenteArtDataGridViewTextBoxColumn.Name = "prixVenteArtDataGridViewTextBoxColumn";
            this.prixVenteArtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prixEnDemiGrosDataGridViewTextBoxColumn
            // 
            this.prixEnDemiGrosDataGridViewTextBoxColumn.DataPropertyName = "PrixEnDemiGros";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.prixEnDemiGrosDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.prixEnDemiGrosDataGridViewTextBoxColumn.HeaderText = "Prix en démi gros";
            this.prixEnDemiGrosDataGridViewTextBoxColumn.Name = "prixEnDemiGrosDataGridViewTextBoxColumn";
            this.prixEnDemiGrosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prixEnGrosDataGridViewTextBoxColumn
            // 
            this.prixEnGrosDataGridViewTextBoxColumn.DataPropertyName = "PrixEnGros";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.prixEnGrosDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.prixEnGrosDataGridViewTextBoxColumn.HeaderText = "Prix en gros";
            this.prixEnGrosDataGridViewTextBoxColumn.Name = "prixEnGrosDataGridViewTextBoxColumn";
            this.prixEnGrosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qteEnGrosDataGridViewTextBoxColumn
            // 
            this.qteEnGrosDataGridViewTextBoxColumn.DataPropertyName = "QteEnGros";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.qteEnGrosDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.qteEnGrosDataGridViewTextBoxColumn.HeaderText = "Quantité en gros";
            this.qteEnGrosDataGridViewTextBoxColumn.Name = "qteEnGrosDataGridViewTextBoxColumn";
            this.qteEnGrosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // coutSortieDataGridViewTextBoxColumn
            // 
            this.coutSortieDataGridViewTextBoxColumn.DataPropertyName = "CoutSortie";
            this.coutSortieDataGridViewTextBoxColumn.HeaderText = "CoutSortie";
            this.coutSortieDataGridViewTextBoxColumn.Name = "coutSortieDataGridViewTextBoxColumn";
            this.coutSortieDataGridViewTextBoxColumn.ReadOnly = true;
            this.coutSortieDataGridViewTextBoxColumn.Visible = false;
            // 
            // categorieDataGridViewTextBoxColumn
            // 
            this.categorieDataGridViewTextBoxColumn.DataPropertyName = "Categorie";
            this.categorieDataGridViewTextBoxColumn.HeaderText = "Catégorie";
            this.categorieDataGridViewTextBoxColumn.Name = "categorieDataGridViewTextBoxColumn";
            this.categorieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockDateBOBindingSource
            // 
            this.stockDateBOBindingSource.DataSource = typeof(App.BusinessObject.StockDateBO);
            // 
            // cmdActualiserStock
            // 
            this.cmdActualiserStock.Image = global::App.EasyShop.Properties.Resources.button_ok;
            this.cmdActualiserStock.Location = new System.Drawing.Point(12, 448);
            this.cmdActualiserStock.Name = "cmdActualiserStock";
            this.cmdActualiserStock.Size = new System.Drawing.Size(80, 40);
            this.cmdActualiserStock.TabIndex = 2;
            this.toolTipStockDate.SetToolTip(this.cmdActualiserStock, "Actualiser le stock");
            this.cmdActualiserStock.UseVisualStyleBackColor = true;
            this.cmdActualiserStock.Click += new System.EventHandler(this.cmdActualiserStock_Click);
            // 
            // cmdQuitter
            // 
            this.cmdQuitter.Image = global::App.EasyShop.Properties.Resources.exit;
            this.cmdQuitter.Location = new System.Drawing.Point(652, 448);
            this.cmdQuitter.Name = "cmdQuitter";
            this.cmdQuitter.Size = new System.Drawing.Size(80, 40);
            this.cmdQuitter.TabIndex = 3;
            this.toolTipStockDate.SetToolTip(this.cmdQuitter, "Fermer");
            this.cmdQuitter.UseVisualStyleBackColor = true;
            this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
            // 
            // txtNombreArticle
            // 
            this.txtNombreArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreArticle.Location = new System.Drawing.Point(523, 463);
            this.txtNombreArticle.Name = "txtNombreArticle";
            this.txtNombreArticle.ReadOnly = true;
            this.txtNombreArticle.Size = new System.Drawing.Size(79, 20);
            this.txtNombreArticle.TabIndex = 18;
            this.txtNombreArticle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(428, 470);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Nombre d\'Articles";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 470);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Stock";
            // 
            // txtPeriodStock
            // 
            this.txtPeriodStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeriodStock.Location = new System.Drawing.Point(180, 463);
            this.txtPeriodStock.Name = "txtPeriodStock";
            this.txtPeriodStock.ReadOnly = true;
            this.txtPeriodStock.Size = new System.Drawing.Size(182, 20);
            this.txtPeriodStock.TabIndex = 20;
            this.txtPeriodStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Détails de l\'article";
            // 
            // txtDetailsDateStock
            // 
            this.txtDetailsDateStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetailsDateStock.Location = new System.Drawing.Point(108, 110);
            this.txtDetailsDateStock.Name = "txtDetailsDateStock";
            this.txtDetailsDateStock.ReadOnly = true;
            this.txtDetailsDateStock.Size = new System.Drawing.Size(461, 20);
            this.txtDetailsDateStock.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(591, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Stock actuel";
            // 
            // txtStockActuel
            // 
            this.txtStockActuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockActuel.Location = new System.Drawing.Point(664, 110);
            this.txtStockActuel.Name = "txtStockActuel";
            this.txtStockActuel.ReadOnly = true;
            this.txtStockActuel.Size = new System.Drawing.Size(68, 20);
            this.txtStockActuel.TabIndex = 24;
            this.txtStockActuel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormStockDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 495);
            this.Controls.Add(this.txtStockActuel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDetailsDateStock);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPeriodStock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombreArticle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmdQuitter);
            this.Controls.Add(this.cmdActualiserStock);
            this.Controls.Add(this.gridStockDate);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormStockDate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock a date";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridStockDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDateBOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpDateDu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDateAu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRecherche;
        private System.Windows.Forms.TextBox txtArticle;
        private System.Windows.Forms.DataGridView gridStockDate;
        private System.Windows.Forms.Button cmdActualiserStock;
        private System.Windows.Forms.Button cmdQuitter;
        private System.Windows.Forms.ToolTip toolTipStockDate;
        private System.Windows.Forms.BindingSource stockDateBOBindingSource;
        private System.Windows.Forms.TextBox txtNombreArticle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleArtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qteStockArtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seuilArtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixAchatArtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixVenteArtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixEnDemiGrosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixEnGrosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qteEnGrosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coutSortieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorieDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPeriodStock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDetailsDateStock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStockActuel;
    }
}