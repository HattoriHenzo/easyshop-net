namespace GestionBoutique.FormCommande
{
    partial class FormEditCommande
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
            this.txtPrixUnitaire = new ToolsLib.AppNumericTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNumCommande = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cmdQuitter = new System.Windows.Forms.Button();
            this.cmdModifierCommande = new System.Windows.Forms.Button();
            this.cmdNouveauFournisseur = new System.Windows.Forms.Button();
            this.cmdSupprimer = new System.Windows.Forms.Button();
            this.cmdNouveauArticle = new System.Windows.Forms.Button();
            this.cmdValider = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuantite = new ToolsLib.AppNumericTextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cbxFournisseur = new System.Windows.Forms.ComboBox();
            this.cbxArticle = new System.Windows.Forms.ComboBox();
            this.gridDetailsCommande = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdModifier = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetailsCommande)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPrixUnitaire
            // 
            this.txtPrixUnitaire.Location = new System.Drawing.Point(90, 96);
            this.txtPrixUnitaire.Name = "txtPrixUnitaire";
            this.txtPrixUnitaire.Size = new System.Drawing.Size(143, 20);
            this.txtPrixUnitaire.TabIndex = 10;
            this.txtPrixUnitaire.Text = "0";
            this.txtPrixUnitaire.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrixUnitaire.Value = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNumCommande);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 66);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Commande";
            // 
            // txtNumCommande
            // 
            this.txtNumCommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumCommande.Location = new System.Drawing.Point(17, 27);
            this.txtNumCommande.Name = "txtNumCommande";
            this.txtNumCommande.ReadOnly = true;
            this.txtNumCommande.Size = new System.Drawing.Size(109, 21);
            this.txtNumCommande.TabIndex = 0;
            // 
            // cmdQuitter
            // 
            this.cmdQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdQuitter.Image = global::GestionBoutique.Properties.Resources.exit;
            this.cmdQuitter.Location = new System.Drawing.Point(629, 282);
            this.cmdQuitter.Name = "cmdQuitter";
            this.cmdQuitter.Size = new System.Drawing.Size(64, 40);
            this.cmdQuitter.TabIndex = 14;
            this.toolTip.SetToolTip(this.cmdQuitter, "Quitte la fenêtre");
            this.cmdQuitter.UseVisualStyleBackColor = true;
            this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
            // 
            // cmdModifierCommande
            // 
            this.cmdModifierCommande.Image = global::GestionBoutique.Properties.Resources.button_ok;
            this.cmdModifierCommande.Location = new System.Drawing.Point(389, 282);
            this.cmdModifierCommande.Name = "cmdModifierCommande";
            this.cmdModifierCommande.Size = new System.Drawing.Size(64, 40);
            this.cmdModifierCommande.TabIndex = 15;
            this.toolTip.SetToolTip(this.cmdModifierCommande, "Vous permez de valider la commande");
            this.cmdModifierCommande.UseVisualStyleBackColor = true;
            this.cmdModifierCommande.Click += new System.EventHandler(this.cmdModifierCommande_Click);
            // 
            // cmdNouveauFournisseur
            // 
            this.cmdNouveauFournisseur.Location = new System.Drawing.Point(239, 129);
            this.cmdNouveauFournisseur.Name = "cmdNouveauFournisseur";
            this.cmdNouveauFournisseur.Size = new System.Drawing.Size(29, 23);
            this.cmdNouveauFournisseur.TabIndex = 7;
            this.cmdNouveauFournisseur.Text = "...";
            this.toolTip.SetToolTip(this.cmdNouveauFournisseur, "Ajouter un fournisseur");
            this.cmdNouveauFournisseur.UseVisualStyleBackColor = true;
            this.cmdNouveauFournisseur.Click += new System.EventHandler(this.cmdNouveauFournisseur_Click);
            // 
            // cmdSupprimer
            // 
            this.cmdSupprimer.Image = global::GestionBoutique.Properties.Resources.button_cancel;
            this.cmdSupprimer.Location = new System.Drawing.Point(306, 219);
            this.cmdSupprimer.Name = "cmdSupprimer";
            this.cmdSupprimer.Size = new System.Drawing.Size(64, 40);
            this.cmdSupprimer.TabIndex = 11;
            this.toolTip.SetToolTip(this.cmdSupprimer, "Supprimer");
            this.cmdSupprimer.UseVisualStyleBackColor = true;
            this.cmdSupprimer.Click += new System.EventHandler(this.cmdSupprimer_Click);
            // 
            // cmdNouveauArticle
            // 
            this.cmdNouveauArticle.Location = new System.Drawing.Point(239, 30);
            this.cmdNouveauArticle.Name = "cmdNouveauArticle";
            this.cmdNouveauArticle.Size = new System.Drawing.Size(29, 23);
            this.cmdNouveauArticle.TabIndex = 7;
            this.cmdNouveauArticle.Text = "...";
            this.toolTip.SetToolTip(this.cmdNouveauArticle, "Ajouter un article");
            this.cmdNouveauArticle.UseVisualStyleBackColor = true;
            this.cmdNouveauArticle.Click += new System.EventHandler(this.cmdNouveauArticle_Click);
            // 
            // cmdValider
            // 
            this.cmdValider.Image = global::GestionBoutique.Properties.Resources.edit_add;
            this.cmdValider.Location = new System.Drawing.Point(307, 127);
            this.cmdValider.Name = "cmdValider";
            this.cmdValider.Size = new System.Drawing.Size(64, 40);
            this.cmdValider.TabIndex = 12;
            this.toolTip.SetToolTip(this.cmdValider, "Valider");
            this.cmdValider.UseVisualStyleBackColor = true;
            this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Prix d\'achat";
            // 
            // txtQuantite
            // 
            this.txtQuantite.Location = new System.Drawing.Point(90, 63);
            this.txtQuantite.Name = "txtQuantite";
            this.txtQuantite.Size = new System.Drawing.Size(143, 20);
            this.txtQuantite.TabIndex = 8;
            this.txtQuantite.Text = "0";
            this.txtQuantite.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQuantite.Value = "0";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(216, 30);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(154, 59);
            this.txtDescription.TabIndex = 17;
            // 
            // cbxFournisseur
            // 
            this.cbxFournisseur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFournisseur.FormattingEnabled = true;
            this.cbxFournisseur.Location = new System.Drawing.Point(90, 129);
            this.cbxFournisseur.Name = "cbxFournisseur";
            this.cbxFournisseur.Size = new System.Drawing.Size(143, 21);
            this.cbxFournisseur.TabIndex = 5;
            // 
            // cbxArticle
            // 
            this.cbxArticle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxArticle.FormattingEnabled = true;
            this.cbxArticle.Location = new System.Drawing.Point(90, 30);
            this.cbxArticle.Name = "cbxArticle";
            this.cbxArticle.Size = new System.Drawing.Size(143, 21);
            this.cbxArticle.TabIndex = 6;
            this.cbxArticle.SelectedValueChanged += new System.EventHandler(this.cbxArticle_SelectedValueChanged);
            this.cbxArticle.Click += new System.EventHandler(this.cbxArticle_Click);
            // 
            // gridDetailsCommande
            // 
            this.gridDetailsCommande.AllowUserToAddRows = false;
            this.gridDetailsCommande.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.gridDetailsCommande.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridDetailsCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDetailsCommande.Location = new System.Drawing.Point(389, 28);
            this.gridDetailsCommande.MultiSelect = false;
            this.gridDetailsCommande.Name = "gridDetailsCommande";
            this.gridDetailsCommande.ReadOnly = true;
            this.gridDetailsCommande.RowTemplate.Height = 20;
            this.gridDetailsCommande.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDetailsCommande.Size = new System.Drawing.Size(304, 245);
            this.gridDetailsCommande.TabIndex = 13;
            this.gridDetailsCommande.SelectionChanged += new System.EventHandler(this.gridDetailsCommande_SelectionChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPrixUnitaire);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtQuantite);
            this.groupBox2.Controls.Add(this.cmdNouveauFournisseur);
            this.groupBox2.Controls.Add(this.cmdNouveauArticle);
            this.groupBox2.Controls.Add(this.cbxFournisseur);
            this.groupBox2.Controls.Add(this.cbxArticle);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(13, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 171);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Article et Fournisseur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fournisseur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantité";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Article";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Desc.";
            // 
            // cmdModifier
            // 
            this.cmdModifier.Image = global::GestionBoutique.Properties.Resources.edit_remove;
            this.cmdModifier.Location = new System.Drawing.Point(307, 173);
            this.cmdModifier.Name = "cmdModifier";
            this.cmdModifier.Size = new System.Drawing.Size(64, 40);
            this.cmdModifier.TabIndex = 19;
            this.cmdModifier.UseVisualStyleBackColor = true;
            this.cmdModifier.Click += new System.EventHandler(this.cmdModifier_Click);
            // 
            // FormEditCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdQuitter;
            this.ClientSize = new System.Drawing.Size(705, 329);
            this.Controls.Add(this.cmdModifier);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdQuitter);
            this.Controls.Add(this.cmdModifierCommande);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.cmdSupprimer);
            this.Controls.Add(this.gridDetailsCommande);
            this.Controls.Add(this.cmdValider);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormEditCommande";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modification d\'une commande";
            this.Load += new System.EventHandler(this.FormEditCommande_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetailsCommande)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolsLib.AppNumericTextBox txtPrixUnitaire;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNumCommande;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button cmdQuitter;
        private System.Windows.Forms.Button cmdModifierCommande;
        private System.Windows.Forms.Button cmdNouveauFournisseur;
        private System.Windows.Forms.Button cmdSupprimer;
        private System.Windows.Forms.Button cmdNouveauArticle;
        private System.Windows.Forms.Button cmdValider;
        private System.Windows.Forms.Label label4;
        private ToolsLib.AppNumericTextBox txtQuantite;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cbxFournisseur;
        private System.Windows.Forms.ComboBox cbxArticle;
        private System.Windows.Forms.DataGridView gridDetailsCommande;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdModifier;
    }
}