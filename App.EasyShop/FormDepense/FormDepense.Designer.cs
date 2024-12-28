namespace App.EasyShop.FormDepense
{
    partial class FormDepense
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtObjet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdAjouter = new System.Windows.Forms.Button();
            this.gridDepenses = new System.Windows.Forms.DataGridView();
            this.idDepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depenseBOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDateDepense = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdSupprimer = new System.Windows.Forms.Button();
            this.txtMontant = new App.Tools.AppNumericTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdRecherche = new System.Windows.Forms.Button();
            this.dtpDateAu = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDateDu = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDepenseTotal = new App.Tools.AppNumericTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridDepenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depenseBOBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Objet";
            // 
            // txtObjet
            // 
            this.txtObjet.Location = new System.Drawing.Point(74, 74);
            this.txtObjet.Multiline = true;
            this.txtObjet.Name = "txtObjet";
            this.txtObjet.Size = new System.Drawing.Size(169, 70);
            this.txtObjet.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Montant";
            // 
            // cmdAjouter
            // 
            this.cmdAjouter.Location = new System.Drawing.Point(256, 160);
            this.cmdAjouter.Name = "cmdAjouter";
            this.cmdAjouter.Size = new System.Drawing.Size(68, 23);
            this.cmdAjouter.TabIndex = 4;
            this.cmdAjouter.Text = "Ajouter";
            this.cmdAjouter.UseVisualStyleBackColor = true;
            this.cmdAjouter.Click += new System.EventHandler(this.cmdAjouter_Click);
            // 
            // gridDepenses
            // 
            this.gridDepenses.AllowUserToAddRows = false;
            this.gridDepenses.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
            this.gridDepenses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gridDepenses.AutoGenerateColumns = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDepenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridDepenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDepenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDepDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.objetDataGridViewTextBoxColumn,
            this.montantDataGridViewTextBoxColumn});
            this.gridDepenses.DataSource = this.depenseBOBindingSource;
            this.gridDepenses.Location = new System.Drawing.Point(75, 200);
            this.gridDepenses.Name = "gridDepenses";
            this.gridDepenses.ReadOnly = true;
            this.gridDepenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDepenses.Size = new System.Drawing.Size(348, 212);
            this.gridDepenses.TabIndex = 5;
            this.gridDepenses.SelectionChanged += new System.EventHandler(this.gridDepenses_SelectionChanged);
            // 
            // idDepDataGridViewTextBoxColumn
            // 
            this.idDepDataGridViewTextBoxColumn.DataPropertyName = "IdDep";
            this.idDepDataGridViewTextBoxColumn.HeaderText = "IdDep";
            this.idDepDataGridViewTextBoxColumn.Name = "idDepDataGridViewTextBoxColumn";
            this.idDepDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDepDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // objetDataGridViewTextBoxColumn
            // 
            this.objetDataGridViewTextBoxColumn.DataPropertyName = "Objet";
            this.objetDataGridViewTextBoxColumn.HeaderText = "Objet";
            this.objetDataGridViewTextBoxColumn.Name = "objetDataGridViewTextBoxColumn";
            this.objetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // montantDataGridViewTextBoxColumn
            // 
            this.montantDataGridViewTextBoxColumn.DataPropertyName = "Montant";
            this.montantDataGridViewTextBoxColumn.HeaderText = "Montant";
            this.montantDataGridViewTextBoxColumn.Name = "montantDataGridViewTextBoxColumn";
            this.montantDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // depenseBOBindingSource
            // 
            this.depenseBOBindingSource.DataSource = typeof(App.BusinessObject.DepenseBO);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dtpDateDepense
            // 
            this.dtpDateDepense.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateDepense.Location = new System.Drawing.Point(75, 38);
            this.dtpDateDepense.Name = "dtpDateDepense";
            this.dtpDateDepense.Size = new System.Drawing.Size(168, 20);
            this.dtpDateDepense.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total";
            // 
            // cmdSupprimer
            // 
            this.cmdSupprimer.Location = new System.Drawing.Point(74, 425);
            this.cmdSupprimer.Name = "cmdSupprimer";
            this.cmdSupprimer.Size = new System.Drawing.Size(75, 23);
            this.cmdSupprimer.TabIndex = 10;
            this.cmdSupprimer.Text = "Supprimer";
            this.cmdSupprimer.UseVisualStyleBackColor = true;
            this.cmdSupprimer.Click += new System.EventHandler(this.cmdSupprimer_Click);
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(74, 160);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(169, 20);
            this.txtMontant.TabIndex = 3;
            this.txtMontant.Text = "0,00";
            this.txtMontant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMontant.Value = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdRecherche);
            this.groupBox1.Controls.Add(this.dtpDateAu);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtpDateDu);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(256, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 121);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recherche";
            // 
            // cmdRecherche
            // 
            this.cmdRecherche.Location = new System.Drawing.Point(43, 88);
            this.cmdRecherche.Name = "cmdRecherche";
            this.cmdRecherche.Size = new System.Drawing.Size(99, 23);
            this.cmdRecherche.TabIndex = 4;
            this.cmdRecherche.Text = "Recherche";
            this.cmdRecherche.UseVisualStyleBackColor = true;
            this.cmdRecherche.Click += new System.EventHandler(this.cmdRecherche_Click);
            // 
            // dtpDateAu
            // 
            this.dtpDateAu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateAu.Location = new System.Drawing.Point(43, 57);
            this.dtpDateAu.Name = "dtpDateAu";
            this.dtpDateAu.Size = new System.Drawing.Size(99, 20);
            this.dtpDateAu.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Au";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // dtpDateDu
            // 
            this.dtpDateDu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateDu.Location = new System.Drawing.Point(43, 27);
            this.dtpDateDu.Name = "dtpDateDu";
            this.dtpDateDu.Size = new System.Drawing.Size(99, 20);
            this.dtpDateDu.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Du";
            // 
            // txtDepenseTotal
            // 
            this.txtDepenseTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepenseTotal.Location = new System.Drawing.Point(310, 424);
            this.txtDepenseTotal.Name = "txtDepenseTotal";
            this.txtDepenseTotal.ReadOnly = true;
            this.txtDepenseTotal.Size = new System.Drawing.Size(113, 20);
            this.txtDepenseTotal.TabIndex = 12;
            this.txtDepenseTotal.Text = "0,00";
            this.txtDepenseTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDepenseTotal.Value = "0";
            // 
            // FormDepense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 456);
            this.Controls.Add(this.txtDepenseTotal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdSupprimer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpDateDepense);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gridDepenses);
            this.Controls.Add(this.cmdAjouter);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtObjet);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormDepense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Depenses";
            ((System.ComponentModel.ISupportInitialize)(this.gridDepenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depenseBOBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtObjet;
        private System.Windows.Forms.Label label2;
        private App.Tools.AppNumericTextBox txtMontant;
        private System.Windows.Forms.Button cmdAjouter;
        private System.Windows.Forms.DataGridView gridDepenses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDateDepense;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdSupprimer;
        private System.Windows.Forms.BindingSource depenseBOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montantDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDateDu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdRecherche;
        private System.Windows.Forms.DateTimePicker dtpDateAu;
        private App.Tools.AppNumericTextBox txtDepenseTotal;
    }
}