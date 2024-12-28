namespace App.EasyShop.FormArticle
{
    partial class FormNewEditArticle
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
            this.grpTitre = new System.Windows.Forms.GroupBox();
            this.txtPrixEnDemiGros = new App.Tools.AppNumericTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtQteEnGros = new App.Tools.AppNumericTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrixEnGros = new App.Tools.AppNumericTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtArticle = new System.Windows.Forms.TextBox();
            this.cmdNewCategorie = new System.Windows.Forms.Button();
            this.cbxCategorie = new System.Windows.Forms.ComboBox();
            this.txtSeuil = new App.Tools.AppNumericTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQteStock = new App.Tools.AppNumericTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrixAchat = new App.Tools.AppNumericTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrixVente = new App.Tools.AppNumericTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cmdQuitter = new System.Windows.Forms.Button();
            this.cmdAjouter = new System.Windows.Forms.Button();
            this.grpTitre.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTitre
            // 
            this.grpTitre.Controls.Add(this.txtPrixEnDemiGros);
            this.grpTitre.Controls.Add(this.label9);
            this.grpTitre.Controls.Add(this.txtQteEnGros);
            this.grpTitre.Controls.Add(this.label8);
            this.grpTitre.Controls.Add(this.txtPrixEnGros);
            this.grpTitre.Controls.Add(this.label7);
            this.grpTitre.Controls.Add(this.txtArticle);
            this.grpTitre.Controls.Add(this.cmdNewCategorie);
            this.grpTitre.Controls.Add(this.cbxCategorie);
            this.grpTitre.Controls.Add(this.txtSeuil);
            this.grpTitre.Controls.Add(this.label2);
            this.grpTitre.Controls.Add(this.txtQteStock);
            this.grpTitre.Controls.Add(this.label6);
            this.grpTitre.Controls.Add(this.txtPrixAchat);
            this.grpTitre.Controls.Add(this.label5);
            this.grpTitre.Controls.Add(this.label3);
            this.grpTitre.Controls.Add(this.txtPrixVente);
            this.grpTitre.Controls.Add(this.label4);
            this.grpTitre.Location = new System.Drawing.Point(20, 15);
            this.grpTitre.Margin = new System.Windows.Forms.Padding(4);
            this.grpTitre.Name = "grpTitre";
            this.grpTitre.Padding = new System.Windows.Forms.Padding(4);
            this.grpTitre.Size = new System.Drawing.Size(349, 498);
            this.grpTitre.TabIndex = 0;
            this.grpTitre.TabStop = false;
            this.grpTitre.Text = "Nouvel Article";
            // 
            // txtPrixEnDemiGros
            // 
            this.txtPrixEnDemiGros.Location = new System.Drawing.Point(119, 212);
            this.txtPrixEnDemiGros.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrixEnDemiGros.Name = "txtPrixEnDemiGros";
            this.txtPrixEnDemiGros.Size = new System.Drawing.Size(200, 22);
            this.txtPrixEnDemiGros.TabIndex = 5;
            this.txtPrixEnDemiGros.Text = "0,00";
            this.txtPrixEnDemiGros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrixEnDemiGros.Value = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 219);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Prix demi gros";
            // 
            // txtQteEnGros
            // 
            this.txtQteEnGros.Location = new System.Drawing.Point(119, 300);
            this.txtQteEnGros.Margin = new System.Windows.Forms.Padding(4);
            this.txtQteEnGros.Name = "txtQteEnGros";
            this.txtQteEnGros.Size = new System.Drawing.Size(200, 22);
            this.txtQteEnGros.TabIndex = 7;
            this.txtQteEnGros.Text = "0,00";
            this.txtQteEnGros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQteEnGros.Value = "0";
            this.txtQteEnGros.TextChanged += new System.EventHandler(this.txtQteEnGros_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 309);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Qté en gros";
            // 
            // txtPrixEnGros
            // 
            this.txtPrixEnGros.Location = new System.Drawing.Point(119, 256);
            this.txtPrixEnGros.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrixEnGros.Name = "txtPrixEnGros";
            this.txtPrixEnGros.Size = new System.Drawing.Size(200, 22);
            this.txtPrixEnGros.TabIndex = 6;
            this.txtPrixEnGros.Text = "0,00";
            this.txtPrixEnGros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrixEnGros.Value = "0";
            this.txtPrixEnGros.TextChanged += new System.EventHandler(this.txtPrixEnGros_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 262);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Prix en gros";
            // 
            // txtArticle
            // 
            this.txtArticle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtArticle.Location = new System.Drawing.Point(119, 39);
            this.txtArticle.Margin = new System.Windows.Forms.Padding(4);
            this.txtArticle.Name = "txtArticle";
            this.txtArticle.Size = new System.Drawing.Size(200, 22);
            this.txtArticle.TabIndex = 0;
            // 
            // cmdNewCategorie
            // 
            this.cmdNewCategorie.Location = new System.Drawing.Point(288, 78);
            this.cmdNewCategorie.Margin = new System.Windows.Forms.Padding(4);
            this.cmdNewCategorie.Name = "cmdNewCategorie";
            this.cmdNewCategorie.Size = new System.Drawing.Size(32, 28);
            this.cmdNewCategorie.TabIndex = 2;
            this.cmdNewCategorie.Text = "...";
            this.toolTip.SetToolTip(this.cmdNewCategorie, "Ajouter une nouvelle catégorie");
            this.cmdNewCategorie.UseVisualStyleBackColor = true;
            this.cmdNewCategorie.Click += new System.EventHandler(this.cmdNewCategorie_Click);
            // 
            // cbxCategorie
            // 
            this.cbxCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategorie.FormattingEnabled = true;
            this.cbxCategorie.Location = new System.Drawing.Point(119, 79);
            this.cbxCategorie.Margin = new System.Windows.Forms.Padding(4);
            this.cbxCategorie.Name = "cbxCategorie";
            this.cbxCategorie.Size = new System.Drawing.Size(160, 24);
            this.cbxCategorie.TabIndex = 1;
            // 
            // txtSeuil
            // 
            this.txtSeuil.Location = new System.Drawing.Point(119, 345);
            this.txtSeuil.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeuil.Name = "txtSeuil";
            this.txtSeuil.Size = new System.Drawing.Size(200, 22);
            this.txtSeuil.TabIndex = 8;
            this.txtSeuil.Text = "0,00";
            this.txtSeuil.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSeuil.Value = "0";
            this.txtSeuil.TextChanged += new System.EventHandler(this.txtSeuil_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prix d\'achat*";
            // 
            // txtQteStock
            // 
            this.txtQteStock.Location = new System.Drawing.Point(119, 389);
            this.txtQteStock.Margin = new System.Windows.Forms.Padding(4);
            this.txtQteStock.Name = "txtQteStock";
            this.txtQteStock.Size = new System.Drawing.Size(200, 22);
            this.txtQteStock.TabIndex = 9;
            this.txtQteStock.Text = "0,00";
            this.txtQteStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQteStock.Value = "0";
            this.txtQteStock.TextChanged += new System.EventHandler(this.txtQteStock_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 89);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Catégorie*";
            // 
            // txtPrixAchat
            // 
            this.txtPrixAchat.Location = new System.Drawing.Point(119, 123);
            this.txtPrixAchat.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrixAchat.Name = "txtPrixAchat";
            this.txtPrixAchat.Size = new System.Drawing.Size(200, 22);
            this.txtPrixAchat.TabIndex = 3;
            this.txtPrixAchat.Text = "0,00";
            this.txtPrixAchat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrixAchat.Value = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 394);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Qté en stock*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Prix vente*";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtPrixVente
            // 
            this.txtPrixVente.Location = new System.Drawing.Point(119, 167);
            this.txtPrixVente.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrixVente.Name = "txtPrixVente";
            this.txtPrixVente.Size = new System.Drawing.Size(200, 22);
            this.txtPrixVente.TabIndex = 4;
            this.txtPrixVente.Text = "0,00";
            this.txtPrixVente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrixVente.Value = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 350);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Seuil d\'alerte*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Article*";
            // 
            // cmdQuitter
            // 
            this.cmdQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdQuitter.Image = global::App.EasyShop.Properties.Resources.exit;
            this.cmdQuitter.Location = new System.Drawing.Point(203, 521);
            this.cmdQuitter.Margin = new System.Windows.Forms.Padding(4);
            this.cmdQuitter.Name = "cmdQuitter";
            this.cmdQuitter.Size = new System.Drawing.Size(97, 49);
            this.cmdQuitter.TabIndex = 11;
            this.toolTip.SetToolTip(this.cmdQuitter, "Fermer");
            this.cmdQuitter.UseVisualStyleBackColor = true;
            this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
            // 
            // cmdAjouter
            // 
            this.cmdAjouter.Image = global::App.EasyShop.Properties.Resources.button_ok;
            this.cmdAjouter.Location = new System.Drawing.Point(97, 521);
            this.cmdAjouter.Margin = new System.Windows.Forms.Padding(4);
            this.cmdAjouter.Name = "cmdAjouter";
            this.cmdAjouter.Size = new System.Drawing.Size(97, 49);
            this.cmdAjouter.TabIndex = 10;
            this.toolTip.SetToolTip(this.cmdAjouter, "Valider");
            this.cmdAjouter.UseVisualStyleBackColor = true;
            this.cmdAjouter.Click += new System.EventHandler(this.cmdAjouter_Click);
            // 
            // FormNewEditArticle
            // 
            this.AcceptButton = this.cmdAjouter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdQuitter;
            this.ClientSize = new System.Drawing.Size(395, 582);
            this.Controls.Add(this.cmdQuitter);
            this.Controls.Add(this.cmdAjouter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpTitre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormNewEditArticle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter un article";
            this.Load += new System.EventHandler(this.FormNewArticle_Load);
            this.grpTitre.ResumeLayout(false);
            this.grpTitre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTitre;
        private App.Tools.AppNumericTextBox txtQteStock;
        private System.Windows.Forms.Label label5;
        private App.Tools.AppNumericTextBox txtSeuil;
        private System.Windows.Forms.Label label4;
        private App.Tools.AppNumericTextBox txtPrixVente;
        private System.Windows.Forms.Label label3;
        private App.Tools.AppNumericTextBox txtPrixAchat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdAjouter;
        private System.Windows.Forms.Button cmdQuitter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxCategorie;
        private System.Windows.Forms.Button cmdNewCategorie;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TextBox txtArticle;
        private System.Windows.Forms.Label label7;
        private App.Tools.AppNumericTextBox txtPrixEnGros;
        private App.Tools.AppNumericTextBox txtQteEnGros;
        private System.Windows.Forms.Label label8;
        private App.Tools.AppNumericTextBox txtPrixEnDemiGros;
        private System.Windows.Forms.Label label9;
    }
}