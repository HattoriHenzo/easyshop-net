namespace App.EasyShop.FormStatistiques
{
    partial class FormNewEditArchiveVente
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPrixAchat = new App.Tools.AppNumericTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRemiseMontant = new App.Tools.AppNumericTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxRemisePourcentage = new System.Windows.Forms.ComboBox();
            this.cbxTypeVente = new System.Windows.Forms.ComboBox();
            this.txtQteVente = new App.Tools.AppNumericTextBox();
            this.txtPrixVente = new App.Tools.AppNumericTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCategorie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxArticles = new System.Windows.Forms.ComboBox();
            this.dtpDateVente = new System.Windows.Forms.DateTimePicker();
            this.cmdModifier = new System.Windows.Forms.Button();
            this.cmdFermer = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtPrixAchat);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtRemiseMontant);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbxRemisePourcentage);
            this.groupBox1.Controls.Add(this.cbxTypeVente);
            this.groupBox1.Controls.Add(this.txtQteVente);
            this.groupBox1.Controls.Add(this.txtPrixVente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCategorie);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 366);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vente";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 267);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Prix d\'achat";
            // 
            // txtPrixAchat
            // 
            this.txtPrixAchat.Location = new System.Drawing.Point(109, 260);
            this.txtPrixAchat.Name = "txtPrixAchat";
            this.txtPrixAchat.Size = new System.Drawing.Size(138, 20);
            this.txtPrixAchat.TabIndex = 14;
            this.txtPrixAchat.Text = "0,00";
            this.txtPrixAchat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrixAchat.Value = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(253, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "CFA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Remise en CFA";
            // 
            // txtRemiseMontant
            // 
            this.txtRemiseMontant.Location = new System.Drawing.Point(109, 184);
            this.txtRemiseMontant.Name = "txtRemiseMontant";
            this.txtRemiseMontant.Size = new System.Drawing.Size(138, 20);
            this.txtRemiseMontant.TabIndex = 5;
            this.txtRemiseMontant.Text = "0,00";
            this.txtRemiseMontant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRemiseMontant.Value = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(253, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Remise en %";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Vente en";
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
            this.cbxRemisePourcentage.Location = new System.Drawing.Point(109, 142);
            this.cbxRemisePourcentage.Name = "cbxRemisePourcentage";
            this.cbxRemisePourcentage.Size = new System.Drawing.Size(138, 21);
            this.cbxRemisePourcentage.TabIndex = 4;
            // 
            // cbxTypeVente
            // 
            this.cbxTypeVente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTypeVente.FormattingEnabled = true;
            this.cbxTypeVente.Items.AddRange(new object[] {
            "DETAIL",
            "DEMI GROS",
            "GROS"});
            this.cbxTypeVente.Location = new System.Drawing.Point(109, 105);
            this.cbxTypeVente.Name = "cbxTypeVente";
            this.cbxTypeVente.Size = new System.Drawing.Size(138, 21);
            this.cbxTypeVente.TabIndex = 3;
            this.cbxTypeVente.SelectedValueChanged += new System.EventHandler(this.cbxTypeVente_SelectedValueChanged);
            // 
            // txtQteVente
            // 
            this.txtQteVente.Location = new System.Drawing.Point(109, 333);
            this.txtQteVente.Name = "txtQteVente";
            this.txtQteVente.Size = new System.Drawing.Size(138, 20);
            this.txtQteVente.TabIndex = 8;
            this.txtQteVente.Text = "0,00";
            this.txtQteVente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQteVente.Value = "0";
            // 
            // txtPrixVente
            // 
            this.txtPrixVente.Location = new System.Drawing.Point(109, 297);
            this.txtPrixVente.Name = "txtPrixVente";
            this.txtPrixVente.Size = new System.Drawing.Size(138, 20);
            this.txtPrixVente.TabIndex = 7;
            this.txtPrixVente.Text = "0,00";
            this.txtPrixVente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrixVente.Value = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Articles";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Date vente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantité";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Prix de vente";
            // 
            // txtCategorie
            // 
            this.txtCategorie.Location = new System.Drawing.Point(109, 221);
            this.txtCategorie.Name = "txtCategorie";
            this.txtCategorie.ReadOnly = true;
            this.txtCategorie.Size = new System.Drawing.Size(138, 20);
            this.txtCategorie.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Catégorie";
            // 
            // cbxArticles
            // 
            this.cbxArticles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxArticles.DropDownWidth = 180;
            this.cbxArticles.FormattingEnabled = true;
            this.cbxArticles.Location = new System.Drawing.Point(121, 79);
            this.cbxArticles.Name = "cbxArticles";
            this.cbxArticles.Size = new System.Drawing.Size(138, 21);
            this.cbxArticles.TabIndex = 2;
            this.cbxArticles.SelectedValueChanged += new System.EventHandler(this.cbxArticles_SelectedValueChanged);
            // 
            // dtpDateVente
            // 
            this.dtpDateVente.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateVente.Location = new System.Drawing.Point(121, 43);
            this.dtpDateVente.Name = "dtpDateVente";
            this.dtpDateVente.Size = new System.Drawing.Size(138, 20);
            this.dtpDateVente.TabIndex = 1;
            // 
            // cmdModifier
            // 
            this.cmdModifier.Image = global::App.EasyShop.Properties.Resources.button_ok;
            this.cmdModifier.Location = new System.Drawing.Point(81, 386);
            this.cmdModifier.Name = "cmdModifier";
            this.cmdModifier.Size = new System.Drawing.Size(73, 40);
            this.cmdModifier.TabIndex = 9;
            this.toolTip.SetToolTip(this.cmdModifier, "Modifier");
            this.cmdModifier.UseVisualStyleBackColor = true;
            this.cmdModifier.Click += new System.EventHandler(this.cmdModifier_Click);
            // 
            // cmdFermer
            // 
            this.cmdFermer.Image = global::App.EasyShop.Properties.Resources.exit;
            this.cmdFermer.Location = new System.Drawing.Point(163, 386);
            this.cmdFermer.Name = "cmdFermer";
            this.cmdFermer.Size = new System.Drawing.Size(73, 40);
            this.cmdFermer.TabIndex = 10;
            this.toolTip.SetToolTip(this.cmdFermer, "Fermer");
            this.cmdFermer.UseVisualStyleBackColor = true;
            this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
            // 
            // FormNewEditArchiveVente
            // 
            this.AcceptButton = this.cmdModifier;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 431);
            this.Controls.Add(this.cmdFermer);
            this.Controls.Add(this.cmdModifier);
            this.Controls.Add(this.cbxArticles);
            this.Controls.Add(this.dtpDateVente);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormNewEditArchiveVente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormNewEditArchiveVente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxArticles;
        private System.Windows.Forms.DateTimePicker dtpDateVente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCategorie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdModifier;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button cmdFermer;
        private App.Tools.AppNumericTextBox txtQteVente;
        private App.Tools.AppNumericTextBox txtPrixVente;
        private System.Windows.Forms.ComboBox cbxTypeVente;
        private System.Windows.Forms.ComboBox cbxRemisePourcentage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private App.Tools.AppNumericTextBox txtRemiseMontant;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private App.Tools.AppNumericTextBox txtPrixAchat;

    }
}