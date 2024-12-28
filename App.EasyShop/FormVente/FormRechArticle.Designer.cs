namespace App.EasyShop.FormVente
{
    partial class FormRechArticle
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdRecherche = new System.Windows.Forms.Button();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.gridArticle = new System.Windows.Forms.DataGridView();
            this.idArtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelleArtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixAchatArtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixVenteArtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coutSortieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seuilArtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qteStockArtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articleBOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmdSelect = new System.Windows.Forms.Button();
            this.cmdFermer = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridArticle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleBOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdRecherche);
            this.groupBox1.Controls.Add(this.txtRecherche);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 74);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recherche rapide";
            // 
            // cmdRecherche
            // 
            this.cmdRecherche.Image = global::App.EasyShop.Properties.Resources.Search_2;
            this.cmdRecherche.Location = new System.Drawing.Point(267, 16);
            this.cmdRecherche.Name = "cmdRecherche";
            this.cmdRecherche.Size = new System.Drawing.Size(57, 49);
            this.cmdRecherche.TabIndex = 2;
            this.cmdRecherche.UseVisualStyleBackColor = true;
            this.cmdRecherche.Click += new System.EventHandler(this.cmdRecherche_Click);
            // 
            // txtRecherche
            // 
            this.txtRecherche.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRecherche.Location = new System.Drawing.Point(16, 31);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(236, 20);
            this.txtRecherche.TabIndex = 0;
            // 
            // gridArticle
            // 
            this.gridArticle.AllowUserToAddRows = false;
            this.gridArticle.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.gridArticle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridArticle.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridArticle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridArticle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridArticle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idArtDataGridViewTextBoxColumn,
            this.libelleArtDataGridViewTextBoxColumn,
            this.prixAchatArtDataGridViewTextBoxColumn,
            this.prixVenteArtDataGridViewTextBoxColumn,
            this.coutSortieDataGridViewTextBoxColumn,
            this.seuilArtDataGridViewTextBoxColumn,
            this.qteStockArtDataGridViewTextBoxColumn,
            this.categorieDataGridViewTextBoxColumn});
            this.gridArticle.DataSource = this.articleBOBindingSource;
            this.gridArticle.Location = new System.Drawing.Point(12, 104);
            this.gridArticle.Name = "gridArticle";
            this.gridArticle.ReadOnly = true;
            this.gridArticle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridArticle.Size = new System.Drawing.Size(338, 150);
            this.gridArticle.TabIndex = 8;
            this.gridArticle.DoubleClick += new System.EventHandler(this.gridArticle_DoubleClick);
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
            this.libelleArtDataGridViewTextBoxColumn.HeaderText = "Articles";
            this.libelleArtDataGridViewTextBoxColumn.Name = "libelleArtDataGridViewTextBoxColumn";
            this.libelleArtDataGridViewTextBoxColumn.ReadOnly = true;
            this.libelleArtDataGridViewTextBoxColumn.Width = 180;
            // 
            // prixAchatArtDataGridViewTextBoxColumn
            // 
            this.prixAchatArtDataGridViewTextBoxColumn.DataPropertyName = "PrixAchatArt";
            this.prixAchatArtDataGridViewTextBoxColumn.HeaderText = "PrixAchatArt";
            this.prixAchatArtDataGridViewTextBoxColumn.Name = "prixAchatArtDataGridViewTextBoxColumn";
            this.prixAchatArtDataGridViewTextBoxColumn.ReadOnly = true;
            this.prixAchatArtDataGridViewTextBoxColumn.Visible = false;
            // 
            // prixVenteArtDataGridViewTextBoxColumn
            // 
            this.prixVenteArtDataGridViewTextBoxColumn.DataPropertyName = "PrixVenteArt";
            this.prixVenteArtDataGridViewTextBoxColumn.HeaderText = "PrixVenteArt";
            this.prixVenteArtDataGridViewTextBoxColumn.Name = "prixVenteArtDataGridViewTextBoxColumn";
            this.prixVenteArtDataGridViewTextBoxColumn.ReadOnly = true;
            this.prixVenteArtDataGridViewTextBoxColumn.Visible = false;
            // 
            // coutSortieDataGridViewTextBoxColumn
            // 
            this.coutSortieDataGridViewTextBoxColumn.DataPropertyName = "CoutSortie";
            this.coutSortieDataGridViewTextBoxColumn.HeaderText = "CoutSortie";
            this.coutSortieDataGridViewTextBoxColumn.Name = "coutSortieDataGridViewTextBoxColumn";
            this.coutSortieDataGridViewTextBoxColumn.ReadOnly = true;
            this.coutSortieDataGridViewTextBoxColumn.Visible = false;
            // 
            // seuilArtDataGridViewTextBoxColumn
            // 
            this.seuilArtDataGridViewTextBoxColumn.DataPropertyName = "SeuilArt";
            this.seuilArtDataGridViewTextBoxColumn.HeaderText = "SeuilArt";
            this.seuilArtDataGridViewTextBoxColumn.Name = "seuilArtDataGridViewTextBoxColumn";
            this.seuilArtDataGridViewTextBoxColumn.ReadOnly = true;
            this.seuilArtDataGridViewTextBoxColumn.Visible = false;
            // 
            // qteStockArtDataGridViewTextBoxColumn
            // 
            this.qteStockArtDataGridViewTextBoxColumn.DataPropertyName = "QteStockArt";
            this.qteStockArtDataGridViewTextBoxColumn.HeaderText = "QteStockArt";
            this.qteStockArtDataGridViewTextBoxColumn.Name = "qteStockArtDataGridViewTextBoxColumn";
            this.qteStockArtDataGridViewTextBoxColumn.ReadOnly = true;
            this.qteStockArtDataGridViewTextBoxColumn.Visible = false;
            // 
            // categorieDataGridViewTextBoxColumn
            // 
            this.categorieDataGridViewTextBoxColumn.DataPropertyName = "Categorie";
            this.categorieDataGridViewTextBoxColumn.HeaderText = "Catégorie";
            this.categorieDataGridViewTextBoxColumn.Name = "categorieDataGridViewTextBoxColumn";
            this.categorieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // articleBOBindingSource
            // 
            this.articleBOBindingSource.DataSource = typeof(App.BusinessObject.ArticleBO);
            // 
            // cmdSelect
            // 
            this.cmdSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSelect.Image = global::App.EasyShop.Properties.Resources.button_ok;
            this.cmdSelect.Location = new System.Drawing.Point(12, 266);
            this.cmdSelect.Name = "cmdSelect";
            this.cmdSelect.Size = new System.Drawing.Size(73, 40);
            this.cmdSelect.TabIndex = 9;
            this.toolTip.SetToolTip(this.cmdSelect, "Sélectionner");
            this.cmdSelect.UseVisualStyleBackColor = true;
            this.cmdSelect.Click += new System.EventHandler(this.cmdSelect_Click);
            // 
            // cmdFermer
            // 
            this.cmdFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFermer.Image = global::App.EasyShop.Properties.Resources.exit;
            this.cmdFermer.Location = new System.Drawing.Point(277, 266);
            this.cmdFermer.Name = "cmdFermer";
            this.cmdFermer.Size = new System.Drawing.Size(73, 40);
            this.cmdFermer.TabIndex = 10;
            this.toolTip.SetToolTip(this.cmdFermer, "Fermer");
            this.cmdFermer.UseVisualStyleBackColor = true;
            this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
            // 
            // FormRechArticle
            // 
            this.AcceptButton = this.cmdRecherche;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 312);
            this.Controls.Add(this.cmdFermer);
            this.Controls.Add(this.cmdSelect);
            this.Controls.Add(this.gridArticle);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormRechArticle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recherche rapide";
            this.Load += new System.EventHandler(this.FormRechArticle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridArticle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleBOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdRecherche;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.DataGridView gridArticle;
        private System.Windows.Forms.Button cmdSelect;
        private System.Windows.Forms.Button cmdFermer;
        private System.Windows.Forms.BindingSource articleBOBindingSource;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleArtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixAchatArtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixVenteArtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coutSortieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seuilArtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qteStockArtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorieDataGridViewTextBoxColumn;
    }
}