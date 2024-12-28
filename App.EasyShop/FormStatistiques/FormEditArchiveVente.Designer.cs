namespace GestionBoutique.FormStatistiques
{
    partial class FormEditArchiveVente
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalVente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQteVente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrixVente = new System.Windows.Forms.TextBox();
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
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTotalVente);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtQteVente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPrixVente);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCategorie);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 268);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modification";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Articles";
            // 
            // txtTotalVente
            // 
            this.txtTotalVente.Location = new System.Drawing.Point(109, 229);
            this.txtTotalVente.Name = "txtTotalVente";
            this.txtTotalVente.Size = new System.Drawing.Size(138, 20);
            this.txtTotalVente.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Total";
            // 
            // txtQteVente
            // 
            this.txtQteVente.Location = new System.Drawing.Point(109, 190);
            this.txtQteVente.Name = "txtQteVente";
            this.txtQteVente.Size = new System.Drawing.Size(138, 20);
            this.txtQteVente.TabIndex = 5;
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
            this.label5.Location = new System.Drawing.Point(26, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantité";
            // 
            // txtPrixVente
            // 
            this.txtPrixVente.Location = new System.Drawing.Point(109, 151);
            this.txtPrixVente.Name = "txtPrixVente";
            this.txtPrixVente.Size = new System.Drawing.Size(138, 20);
            this.txtPrixVente.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Prix vente";
            // 
            // txtCategorie
            // 
            this.txtCategorie.Location = new System.Drawing.Point(109, 112);
            this.txtCategorie.Name = "txtCategorie";
            this.txtCategorie.Size = new System.Drawing.Size(138, 20);
            this.txtCategorie.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Catégorie";
            // 
            // cbxArticles
            // 
            this.cbxArticles.FormattingEnabled = true;
            this.cbxArticles.Location = new System.Drawing.Point(121, 82);
            this.cbxArticles.Name = "cbxArticles";
            this.cbxArticles.Size = new System.Drawing.Size(138, 21);
            this.cbxArticles.TabIndex = 6;
            // 
            // dtpDateVente
            // 
            this.dtpDateVente.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateVente.Location = new System.Drawing.Point(121, 43);
            this.dtpDateVente.Name = "dtpDateVente";
            this.dtpDateVente.Size = new System.Drawing.Size(138, 20);
            this.dtpDateVente.TabIndex = 5;
            // 
            // cmdModifier
            // 
            this.cmdModifier.Image = global::GestionBoutique.Properties.Resources.button_ok;
            this.cmdModifier.Location = new System.Drawing.Point(84, 295);
            this.cmdModifier.Name = "cmdModifier";
            this.cmdModifier.Size = new System.Drawing.Size(60, 40);
            this.cmdModifier.TabIndex = 7;
            this.toolTip.SetToolTip(this.cmdModifier, "Modifier");
            this.cmdModifier.UseVisualStyleBackColor = true;
            // 
            // cmdFermer
            // 
            this.cmdFermer.Image = global::GestionBoutique.Properties.Resources.exit;
            this.cmdFermer.Location = new System.Drawing.Point(153, 295);
            this.cmdFermer.Name = "cmdFermer";
            this.cmdFermer.Size = new System.Drawing.Size(60, 40);
            this.cmdFermer.TabIndex = 8;
            this.toolTip.SetToolTip(this.cmdFermer, "Fermer");
            this.cmdFermer.UseVisualStyleBackColor = true;
            this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
            // 
            // FormEditArchiveVente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 342);
            this.Controls.Add(this.cmdFermer);
            this.Controls.Add(this.cmdModifier);
            this.Controls.Add(this.cbxArticles);
            this.Controls.Add(this.dtpDateVente);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormEditArchiveVente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifier une vente";
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
        private System.Windows.Forms.TextBox txtTotalVente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQteVente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrixVente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdModifier;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button cmdFermer;

    }
}