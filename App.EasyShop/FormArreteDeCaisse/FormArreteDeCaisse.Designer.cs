namespace App.EasyShop.FormArreteDeCaisse
{
    partial class FormArreteDeCaisse
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
            this.dtpDateJour = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdSupprimer = new System.Windows.Forms.Button();
            this.cmdDeb = new System.Windows.Forms.Button();
            this.cmdModifier = new System.Windows.Forms.Button();
            this.cmdValider = new System.Windows.Forms.Button();
            this.txtObservation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConformite = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMontantCaisse = new App.Tools.AppNumericTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMontantBase = new App.Tools.AppNumericTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdDebloquer = new System.Windows.Forms.Button();
            this.cmdQuitter = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.arreteDeCaisseBOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridAC = new System.Windows.Forms.DataGridView();
            this.idACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heureACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montantEnCaisseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montantBaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conformeACDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.observationACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdRech = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDu = new System.Windows.Forms.DateTimePicker();
            this.dtpAu = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arreteDeCaisseBOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAC)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date du jour";
            // 
            // dtpDateJour
            // 
            this.dtpDateJour.Enabled = false;
            this.dtpDateJour.Location = new System.Drawing.Point(115, 33);
            this.dtpDateJour.Name = "dtpDateJour";
            this.dtpDateJour.Size = new System.Drawing.Size(177, 20);
            this.dtpDateJour.TabIndex = 9;
            this.dtpDateJour.ValueChanged += new System.EventHandler(this.dtpDateJour_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdSupprimer);
            this.groupBox1.Controls.Add(this.cmdDeb);
            this.groupBox1.Controls.Add(this.cmdModifier);
            this.groupBox1.Controls.Add(this.cmdValider);
            this.groupBox1.Controls.Add(this.txtObservation);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtConformite);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMontantCaisse);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMontantBase);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(15, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 282);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arrêté de caisse";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmdSupprimer
            // 
            this.cmdSupprimer.Image = global::App.EasyShop.Properties.Resources.button_cancel;
            this.cmdSupprimer.Location = new System.Drawing.Point(208, 230);
            this.cmdSupprimer.Name = "cmdSupprimer";
            this.cmdSupprimer.Size = new System.Drawing.Size(73, 40);
            this.cmdSupprimer.TabIndex = 12;
            this.cmdSupprimer.UseVisualStyleBackColor = true;
            this.cmdSupprimer.Click += new System.EventHandler(this.cmdSupprimer_Click);
            // 
            // cmdDeb
            // 
            this.cmdDeb.Location = new System.Drawing.Point(260, 67);
            this.cmdDeb.Name = "cmdDeb";
            this.cmdDeb.Size = new System.Drawing.Size(27, 23);
            this.cmdDeb.TabIndex = 11;
            this.cmdDeb.Text = "...";
            this.toolTip.SetToolTip(this.cmdDeb, "Débloquer et saisir le montant");
            this.cmdDeb.UseVisualStyleBackColor = true;
            this.cmdDeb.Click += new System.EventHandler(this.cmdDeb_Click);
            // 
            // cmdModifier
            // 
            this.cmdModifier.Image = global::App.EasyShop.Properties.Resources.edit;
            this.cmdModifier.Location = new System.Drawing.Point(129, 230);
            this.cmdModifier.Name = "cmdModifier";
            this.cmdModifier.Size = new System.Drawing.Size(73, 40);
            this.cmdModifier.TabIndex = 2;
            this.toolTip.SetToolTip(this.cmdModifier, "Modifier");
            this.cmdModifier.UseVisualStyleBackColor = true;
            this.cmdModifier.Click += new System.EventHandler(this.cmdModifier_Click);
            // 
            // cmdValider
            // 
            this.cmdValider.Image = global::App.EasyShop.Properties.Resources.button_ok;
            this.cmdValider.Location = new System.Drawing.Point(50, 230);
            this.cmdValider.Name = "cmdValider";
            this.cmdValider.Size = new System.Drawing.Size(73, 40);
            this.cmdValider.TabIndex = 2;
            this.toolTip.SetToolTip(this.cmdValider, "Ajouter");
            this.cmdValider.UseVisualStyleBackColor = true;
            this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
            // 
            // txtObservation
            // 
            this.txtObservation.Location = new System.Drawing.Point(100, 142);
            this.txtObservation.Multiline = true;
            this.txtObservation.Name = "txtObservation";
            this.txtObservation.ReadOnly = true;
            this.txtObservation.Size = new System.Drawing.Size(154, 70);
            this.txtObservation.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Observations";
            // 
            // txtConformite
            // 
            this.txtConformite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConformite.Location = new System.Drawing.Point(100, 105);
            this.txtConformite.Name = "txtConformite";
            this.txtConformite.ReadOnly = true;
            this.txtConformite.Size = new System.Drawing.Size(154, 20);
            this.txtConformite.TabIndex = 10;
            this.txtConformite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Conformité";
            // 
            // txtMontantCaisse
            // 
            this.txtMontantCaisse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontantCaisse.Location = new System.Drawing.Point(100, 69);
            this.txtMontantCaisse.Name = "txtMontantCaisse";
            this.txtMontantCaisse.ReadOnly = true;
            this.txtMontantCaisse.Size = new System.Drawing.Size(154, 20);
            this.txtMontantCaisse.TabIndex = 0;
            this.txtMontantCaisse.Text = "0,00";
            this.txtMontantCaisse.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMontantCaisse.Value = "0";
            this.txtMontantCaisse.TextChanged += new System.EventHandler(this.txtMontantCaisse_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mont. caisse";
            // 
            // txtMontantBase
            // 
            this.txtMontantBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontantBase.Location = new System.Drawing.Point(100, 34);
            this.txtMontantBase.Name = "txtMontantBase";
            this.txtMontantBase.ReadOnly = true;
            this.txtMontantBase.Size = new System.Drawing.Size(154, 20);
            this.txtMontantBase.TabIndex = 1;
            this.txtMontantBase.Text = "0,00";
            this.txtMontantBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMontantBase.Value = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mont. base";
            // 
            // cmdDebloquer
            // 
            this.cmdDebloquer.Image = global::App.EasyShop.Properties.Resources.password;
            this.cmdDebloquer.Location = new System.Drawing.Point(336, 322);
            this.cmdDebloquer.Name = "cmdDebloquer";
            this.cmdDebloquer.Size = new System.Drawing.Size(73, 40);
            this.cmdDebloquer.TabIndex = 10;
            this.toolTip.SetToolTip(this.cmdDebloquer, "Débloquer");
            this.cmdDebloquer.UseVisualStyleBackColor = true;
            this.cmdDebloquer.Click += new System.EventHandler(this.cmdDebloquer_Click);
            // 
            // cmdQuitter
            // 
            this.cmdQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdQuitter.Image = global::App.EasyShop.Properties.Resources.exit;
            this.cmdQuitter.Location = new System.Drawing.Point(631, 322);
            this.cmdQuitter.Name = "cmdQuitter";
            this.cmdQuitter.Size = new System.Drawing.Size(73, 40);
            this.cmdQuitter.TabIndex = 4;
            this.toolTip.SetToolTip(this.cmdQuitter, "Fermer");
            this.cmdQuitter.UseVisualStyleBackColor = true;
            this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
            // 
            // arreteDeCaisseBOBindingSource
            // 
            this.arreteDeCaisseBOBindingSource.DataSource = typeof(App.BusinessObject.ArreteDeCaisseBO);
            // 
            // gridAC
            // 
            this.gridAC.AllowUserToAddRows = false;
            this.gridAC.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.gridAC.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridAC.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridAC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idACDataGridViewTextBoxColumn,
            this.dateACDataGridViewTextBoxColumn,
            this.heureACDataGridViewTextBoxColumn,
            this.montantEnCaisseDataGridViewTextBoxColumn,
            this.montantBaseDataGridViewTextBoxColumn,
            this.conformeACDataGridViewCheckBoxColumn,
            this.observationACDataGridViewTextBoxColumn});
            this.gridAC.DataSource = this.arreteDeCaisseBOBindingSource;
            this.gridAC.Location = new System.Drawing.Point(336, 89);
            this.gridAC.Name = "gridAC";
            this.gridAC.ReadOnly = true;
            this.gridAC.RowTemplate.Height = 20;
            this.gridAC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAC.Size = new System.Drawing.Size(368, 222);
            this.gridAC.TabIndex = 11;
            this.gridAC.SelectionChanged += new System.EventHandler(this.gridAC_SelectionChanged);
            // 
            // idACDataGridViewTextBoxColumn
            // 
            this.idACDataGridViewTextBoxColumn.DataPropertyName = "IdAC";
            this.idACDataGridViewTextBoxColumn.HeaderText = "IdAC";
            this.idACDataGridViewTextBoxColumn.Name = "idACDataGridViewTextBoxColumn";
            this.idACDataGridViewTextBoxColumn.ReadOnly = true;
            this.idACDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateACDataGridViewTextBoxColumn
            // 
            this.dateACDataGridViewTextBoxColumn.DataPropertyName = "DateAC";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dateACDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.dateACDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateACDataGridViewTextBoxColumn.Name = "dateACDataGridViewTextBoxColumn";
            this.dateACDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // heureACDataGridViewTextBoxColumn
            // 
            this.heureACDataGridViewTextBoxColumn.DataPropertyName = "HeureAC";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.heureACDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.heureACDataGridViewTextBoxColumn.HeaderText = "Heure";
            this.heureACDataGridViewTextBoxColumn.Name = "heureACDataGridViewTextBoxColumn";
            this.heureACDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // montantEnCaisseDataGridViewTextBoxColumn
            // 
            this.montantEnCaisseDataGridViewTextBoxColumn.DataPropertyName = "MontantEnCaisse";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "# ### ###";
            dataGridViewCellStyle5.NullValue = "0";
            this.montantEnCaisseDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.montantEnCaisseDataGridViewTextBoxColumn.HeaderText = "Montant Caisse";
            this.montantEnCaisseDataGridViewTextBoxColumn.Name = "montantEnCaisseDataGridViewTextBoxColumn";
            this.montantEnCaisseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // montantBaseDataGridViewTextBoxColumn
            // 
            this.montantBaseDataGridViewTextBoxColumn.DataPropertyName = "MontantBase";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "# ### ###";
            dataGridViewCellStyle6.NullValue = "0";
            this.montantBaseDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.montantBaseDataGridViewTextBoxColumn.HeaderText = "Montant Base";
            this.montantBaseDataGridViewTextBoxColumn.Name = "montantBaseDataGridViewTextBoxColumn";
            this.montantBaseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // conformeACDataGridViewCheckBoxColumn
            // 
            this.conformeACDataGridViewCheckBoxColumn.DataPropertyName = "ConformeAC";
            this.conformeACDataGridViewCheckBoxColumn.HeaderText = "Conforme";
            this.conformeACDataGridViewCheckBoxColumn.Name = "conformeACDataGridViewCheckBoxColumn";
            this.conformeACDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // observationACDataGridViewTextBoxColumn
            // 
            this.observationACDataGridViewTextBoxColumn.DataPropertyName = "ObservationAC";
            this.observationACDataGridViewTextBoxColumn.HeaderText = "Observation";
            this.observationACDataGridViewTextBoxColumn.Name = "observationACDataGridViewTextBoxColumn";
            this.observationACDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cmdRech
            // 
            this.cmdRech.Image = global::App.EasyShop.Properties.Resources.Search;
            this.cmdRech.Location = new System.Drawing.Point(278, 15);
            this.cmdRech.Name = "cmdRech";
            this.cmdRech.Size = new System.Drawing.Size(73, 40);
            this.cmdRech.TabIndex = 12;
            this.cmdRech.UseVisualStyleBackColor = true;
            this.cmdRech.Click += new System.EventHandler(this.cmdRech_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dtpDu);
            this.groupBox2.Controls.Add(this.dtpAu);
            this.groupBox2.Controls.Add(this.cmdRech);
            this.groupBox2.Location = new System.Drawing.Point(336, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 64);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recherche";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(141, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Au";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Du";
            // 
            // dtpDu
            // 
            this.dtpDu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDu.Location = new System.Drawing.Point(34, 27);
            this.dtpDu.Name = "dtpDu";
            this.dtpDu.Size = new System.Drawing.Size(101, 20);
            this.dtpDu.TabIndex = 13;
            // 
            // dtpAu
            // 
            this.dtpAu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAu.Location = new System.Drawing.Point(165, 27);
            this.dtpAu.Name = "dtpAu";
            this.dtpAu.Size = new System.Drawing.Size(101, 20);
            this.dtpAu.TabIndex = 0;
            // 
            // FormArreteDeCaisse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdQuitter;
            this.ClientSize = new System.Drawing.Size(716, 376);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gridAC);
            this.Controls.Add(this.cmdDebloquer);
            this.Controls.Add(this.cmdQuitter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpDateJour);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormArreteDeCaisse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arrêté de caisse";
            this.Load += new System.EventHandler(this.FormArreteDeCaisse_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arreteDeCaisseBOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAC)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDateJour;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private App.Tools.AppNumericTextBox txtMontantCaisse;
        private System.Windows.Forms.Label label3;
        private App.Tools.AppNumericTextBox txtMontantBase;
        private System.Windows.Forms.TextBox txtObservation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdModifier;
        private System.Windows.Forms.Button cmdValider;
        private System.Windows.Forms.TextBox txtConformite;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdQuitter;
        private System.Windows.Forms.Button cmdDebloquer;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.BindingSource arreteDeCaisseBOBindingSource;
        private System.Windows.Forms.DataGridView gridAC;
        private System.Windows.Forms.Button cmdDeb;
        private System.Windows.Forms.Button cmdRech;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpAu;
        private System.Windows.Forms.DateTimePicker dtpDu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn idACDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateACDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heureACDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montantEnCaisseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montantBaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn conformeACDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observationACDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button cmdSupprimer;
    }
}