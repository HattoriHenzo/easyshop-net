namespace App.EasyShop.FormCommande
{
    partial class FormNewEditCommande
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
            this.chkValide = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescriptionCommande = new System.Windows.Forms.TextBox();
            this.dtpDateCommande = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumCommande = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cmdQuitter = new System.Windows.Forms.Button();
            this.cmdValider = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkValide);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDescriptionCommande);
            this.groupBox1.Controls.Add(this.dtpDateCommande);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNumCommande);
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 264);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Commande";
            // 
            // chkValide
            // 
            this.chkValide.AutoSize = true;
            this.chkValide.Location = new System.Drawing.Point(32, 234);
            this.chkValide.Name = "chkValide";
            this.chkValide.Size = new System.Drawing.Size(62, 17);
            this.chkValide.TabIndex = 7;
            this.chkValide.Text = "Annuler";
            this.chkValide.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description";
            // 
            // txtDescriptionCommande
            // 
            this.txtDescriptionCommande.Location = new System.Drawing.Point(32, 145);
            this.txtDescriptionCommande.Multiline = true;
            this.txtDescriptionCommande.Name = "txtDescriptionCommande";
            this.txtDescriptionCommande.Size = new System.Drawing.Size(183, 72);
            this.txtDescriptionCommande.TabIndex = 4;
            // 
            // dtpDateCommande
            // 
            this.dtpDateCommande.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateCommande.Location = new System.Drawing.Point(120, 78);
            this.dtpDateCommande.Name = "dtpDateCommande";
            this.dtpDateCommande.Size = new System.Drawing.Size(95, 20);
            this.dtpDateCommande.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "N° Commande";
            // 
            // txtNumCommande
            // 
            this.txtNumCommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumCommande.Location = new System.Drawing.Point(120, 34);
            this.txtNumCommande.Name = "txtNumCommande";
            this.txtNumCommande.ReadOnly = true;
            this.txtNumCommande.Size = new System.Drawing.Size(95, 21);
            this.txtNumCommande.TabIndex = 0;
            // 
            // cmdQuitter
            // 
            this.cmdQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdQuitter.Image = global::App.EasyShop.Properties.Resources.exit;
            this.cmdQuitter.Location = new System.Drawing.Point(136, 292);
            this.cmdQuitter.Name = "cmdQuitter";
            this.cmdQuitter.Size = new System.Drawing.Size(73, 40);
            this.cmdQuitter.TabIndex = 4;
            this.toolTip.SetToolTip(this.cmdQuitter, "Fermer");
            this.cmdQuitter.UseVisualStyleBackColor = true;
            this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
            // 
            // cmdValider
            // 
            this.cmdValider.Image = global::App.EasyShop.Properties.Resources.button_ok;
            this.cmdValider.Location = new System.Drawing.Point(57, 292);
            this.cmdValider.Name = "cmdValider";
            this.cmdValider.Size = new System.Drawing.Size(73, 40);
            this.cmdValider.TabIndex = 5;
            this.cmdValider.UseVisualStyleBackColor = true;
            this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click_1);
            // 
            // FormNewEditCommande
            // 
            this.AcceptButton = this.cmdValider;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdQuitter;
            this.ClientSize = new System.Drawing.Size(264, 342);
            this.Controls.Add(this.cmdValider);
            this.Controls.Add(this.cmdQuitter);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormNewEditCommande";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormNewCommande_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNewCommande_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNumCommande;
        private System.Windows.Forms.Button cmdQuitter;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescriptionCommande;
        private System.Windows.Forms.DateTimePicker dtpDateCommande;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdValider;
        private System.Windows.Forms.CheckBox chkValide;
    }
}