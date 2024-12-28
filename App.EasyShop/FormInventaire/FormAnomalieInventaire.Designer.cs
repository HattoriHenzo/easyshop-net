namespace App.EasyShop.FormInventaire
{
    partial class FormAnomalieInventaire
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdRech = new System.Windows.Forms.Button();
            this.dtpAu = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDu = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.gridListeInventaire = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConforme = new System.Windows.Forms.TextBox();
            this.gridAnomalies = new System.Windows.Forms.DataGridView();
            this.cmdQuitter = new System.Windows.Forms.Button();
            this.cmdImprimer = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.idInvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelleArtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtePhysInvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qteStockInvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ecartInvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observationInvDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDateInvDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idArtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventaireBOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDateInvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateInvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heureInvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observationInvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valideInvDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dateInventaireBOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridListeInventaire)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAnomalies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventaireBOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateInventaireBOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdRech);
            this.groupBox1.Controls.Add(this.dtpAu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpDu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.gridListeInventaire);
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 173);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Liste des inventaires";
            // 
            // cmdRech
            // 
            this.cmdRech.Image = global::App.EasyShop.Properties.Resources.Search;
            this.cmdRech.Location = new System.Drawing.Point(170, 65);
            this.cmdRech.Name = "cmdRech";
            this.cmdRech.Size = new System.Drawing.Size(58, 45);
            this.cmdRech.TabIndex = 5;
            this.cmdRech.UseVisualStyleBackColor = true;
            this.cmdRech.Click += new System.EventHandler(this.cmdRech_Click);
            // 
            // dtpAu
            // 
            this.dtpAu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAu.Location = new System.Drawing.Point(61, 99);
            this.dtpAu.Name = "dtpAu";
            this.dtpAu.Size = new System.Drawing.Size(100, 20);
            this.dtpAu.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Au";
            // 
            // dtpDu
            // 
            this.dtpDu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDu.Location = new System.Drawing.Point(61, 52);
            this.dtpDu.Name = "dtpDu";
            this.dtpDu.Size = new System.Drawing.Size(100, 20);
            this.dtpDu.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Du";
            // 
            // gridListeInventaire
            // 
            this.gridListeInventaire.AllowUserToAddRows = false;
            this.gridListeInventaire.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Silver;
            this.gridListeInventaire.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.gridListeInventaire.AutoGenerateColumns = false;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridListeInventaire.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.gridListeInventaire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridListeInventaire.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDateInvDataGridViewTextBoxColumn,
            this.dateInvDataGridViewTextBoxColumn,
            this.heureInvDataGridViewTextBoxColumn,
            this.observationInvDataGridViewTextBoxColumn,
            this.valideInvDataGridViewCheckBoxColumn});
            this.gridListeInventaire.DataSource = this.dateInventaireBOBindingSource;
            this.gridListeInventaire.Location = new System.Drawing.Point(241, 22);
            this.gridListeInventaire.Name = "gridListeInventaire";
            this.gridListeInventaire.ReadOnly = true;
            this.gridListeInventaire.RowTemplate.Height = 20;
            this.gridListeInventaire.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridListeInventaire.Size = new System.Drawing.Size(299, 133);
            this.gridListeInventaire.TabIndex = 0;
            this.gridListeInventaire.SelectionChanged += new System.EventHandler(this.gridListeInventaire_SelectionChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtConforme);
            this.groupBox2.Controls.Add(this.gridAnomalies);
            this.groupBox2.Location = new System.Drawing.Point(14, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(554, 286);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Anomalies";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(484, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Conforme";
            // 
            // txtConforme
            // 
            this.txtConforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConforme.Location = new System.Drawing.Point(482, 150);
            this.txtConforme.Name = "txtConforme";
            this.txtConforme.ReadOnly = true;
            this.txtConforme.Size = new System.Drawing.Size(58, 20);
            this.txtConforme.TabIndex = 1;
            this.txtConforme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gridAnomalies
            // 
            this.gridAnomalies.AllowUserToAddRows = false;
            this.gridAnomalies.AllowUserToDeleteRows = false;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Silver;
            this.gridAnomalies.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle14;
            this.gridAnomalies.AutoGenerateColumns = false;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAnomalies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.gridAnomalies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAnomalies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idInvDataGridViewTextBoxColumn,
            this.libelleArtDataGridViewTextBoxColumn,
            this.qtePhysInvDataGridViewTextBoxColumn,
            this.qteStockInvDataGridViewTextBoxColumn,
            this.ecartInvDataGridViewTextBoxColumn,
            this.observationInvDataGridViewTextBoxColumn1,
            this.idDateInvDataGridViewTextBoxColumn1,
            this.idArtDataGridViewTextBoxColumn});
            this.gridAnomalies.DataSource = this.inventaireBOBindingSource;
            this.gridAnomalies.Location = new System.Drawing.Point(16, 33);
            this.gridAnomalies.MultiSelect = false;
            this.gridAnomalies.Name = "gridAnomalies";
            this.gridAnomalies.ReadOnly = true;
            this.gridAnomalies.RowTemplate.Height = 20;
            this.gridAnomalies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAnomalies.Size = new System.Drawing.Size(454, 232);
            this.gridAnomalies.TabIndex = 0;
            this.gridAnomalies.SelectionChanged += new System.EventHandler(this.gridAnomalies_SelectionChanged);
            // 
            // cmdQuitter
            // 
            this.cmdQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdQuitter.Image = global::App.EasyShop.Properties.Resources.exit;
            this.cmdQuitter.Location = new System.Drawing.Point(496, 502);
            this.cmdQuitter.Name = "cmdQuitter";
            this.cmdQuitter.Size = new System.Drawing.Size(71, 40);
            this.cmdQuitter.TabIndex = 2;
            this.toolTip.SetToolTip(this.cmdQuitter, "Fermer");
            this.cmdQuitter.UseVisualStyleBackColor = true;
            this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
            // 
            // cmdImprimer
            // 
            this.cmdImprimer.Image = global::App.EasyShop.Properties.Resources.printer1;
            this.cmdImprimer.Location = new System.Drawing.Point(14, 502);
            this.cmdImprimer.Name = "cmdImprimer";
            this.cmdImprimer.Size = new System.Drawing.Size(71, 40);
            this.cmdImprimer.TabIndex = 3;
            this.toolTip.SetToolTip(this.cmdImprimer, "Imprimer l\'état");
            this.cmdImprimer.UseVisualStyleBackColor = true;
            this.cmdImprimer.Click += new System.EventHandler(this.cmdImprimer_Click);
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
            this.libelleArtDataGridViewTextBoxColumn.HeaderText = "Article";
            this.libelleArtDataGridViewTextBoxColumn.Name = "libelleArtDataGridViewTextBoxColumn";
            this.libelleArtDataGridViewTextBoxColumn.ReadOnly = true;
            this.libelleArtDataGridViewTextBoxColumn.Width = 140;
            // 
            // qtePhysInvDataGridViewTextBoxColumn
            // 
            this.qtePhysInvDataGridViewTextBoxColumn.DataPropertyName = "QtePhysInv";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.qtePhysInvDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle16;
            this.qtePhysInvDataGridViewTextBoxColumn.HeaderText = "Qté. Phys.";
            this.qtePhysInvDataGridViewTextBoxColumn.Name = "qtePhysInvDataGridViewTextBoxColumn";
            this.qtePhysInvDataGridViewTextBoxColumn.ReadOnly = true;
            this.qtePhysInvDataGridViewTextBoxColumn.Width = 90;
            // 
            // qteStockInvDataGridViewTextBoxColumn
            // 
            this.qteStockInvDataGridViewTextBoxColumn.DataPropertyName = "QteStockInv";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.qteStockInvDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle17;
            this.qteStockInvDataGridViewTextBoxColumn.HeaderText = "Qté. Stock";
            this.qteStockInvDataGridViewTextBoxColumn.Name = "qteStockInvDataGridViewTextBoxColumn";
            this.qteStockInvDataGridViewTextBoxColumn.ReadOnly = true;
            this.qteStockInvDataGridViewTextBoxColumn.Width = 90;
            // 
            // ecartInvDataGridViewTextBoxColumn
            // 
            this.ecartInvDataGridViewTextBoxColumn.DataPropertyName = "EcartInv";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ecartInvDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle18;
            this.ecartInvDataGridViewTextBoxColumn.HeaderText = "Ecart";
            this.ecartInvDataGridViewTextBoxColumn.Name = "ecartInvDataGridViewTextBoxColumn";
            this.ecartInvDataGridViewTextBoxColumn.ReadOnly = true;
            this.ecartInvDataGridViewTextBoxColumn.Width = 90;
            // 
            // observationInvDataGridViewTextBoxColumn1
            // 
            this.observationInvDataGridViewTextBoxColumn1.DataPropertyName = "ObservationInv";
            this.observationInvDataGridViewTextBoxColumn1.HeaderText = "Observation";
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
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dateInvDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle12;
            this.dateInvDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateInvDataGridViewTextBoxColumn.Name = "dateInvDataGridViewTextBoxColumn";
            this.dateInvDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // heureInvDataGridViewTextBoxColumn
            // 
            this.heureInvDataGridViewTextBoxColumn.DataPropertyName = "HeureInv";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.heureInvDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle13;
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
            // FormAnomalieInventaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdQuitter;
            this.ClientSize = new System.Drawing.Size(582, 552);
            this.Controls.Add(this.cmdImprimer);
            this.Controls.Add(this.cmdQuitter);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormAnomalieInventaire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Détection des anomalies";
            this.Load += new System.EventHandler(this.FormAnomalieInventaire_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridListeInventaire)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAnomalies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventaireBOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateInventaireBOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdQuitter;
        private System.Windows.Forms.DataGridView gridAnomalies;
        private System.Windows.Forms.TextBox txtConforme;
        private System.Windows.Forms.DataGridView gridListeInventaire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdImprimer;
        private System.Windows.Forms.BindingSource dateInventaireBOBindingSource;
        private System.Windows.Forms.BindingSource inventaireBOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDateInvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateInvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heureInvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observationInvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn valideInvDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DateTimePicker dtpAu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdRech;
        private System.Windows.Forms.DataGridViewTextBoxColumn idInvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleArtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtePhysInvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qteStockInvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ecartInvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observationInvDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDateInvDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArtDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolTip toolTip;
    }
}