namespace App.EasyShop.FormInventaire
{
    partial class FormValeurStock
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
            this.gridDateInventaire = new System.Windows.Forms.DataGridView();
            this.gridValeurStock = new System.Windows.Forms.DataGridView();
            this.cmdQuitter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValeurStock = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cmdImprimer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDateInventaire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridValeurStock)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridDateInventaire);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 163);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valeur du stock au";
            // 
            // gridDateInventaire
            // 
            this.gridDateInventaire.AllowUserToAddRows = false;
            this.gridDateInventaire.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.gridDateInventaire.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridDateInventaire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDateInventaire.Location = new System.Drawing.Point(15, 26);
            this.gridDateInventaire.Name = "gridDateInventaire";
            this.gridDateInventaire.ReadOnly = true;
            this.gridDateInventaire.RowTemplate.Height = 20;
            this.gridDateInventaire.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDateInventaire.Size = new System.Drawing.Size(206, 120);
            this.gridDateInventaire.TabIndex = 0;
            this.gridDateInventaire.SelectionChanged += new System.EventHandler(this.gridDateInventaire_SelectionChanged);
            // 
            // gridValeurStock
            // 
            this.gridValeurStock.AllowUserToAddRows = false;
            this.gridValeurStock.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            this.gridValeurStock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridValeurStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridValeurStock.Location = new System.Drawing.Point(12, 214);
            this.gridValeurStock.Name = "gridValeurStock";
            this.gridValeurStock.ReadOnly = true;
            this.gridValeurStock.RowTemplate.Height = 20;
            this.gridValeurStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridValeurStock.Size = new System.Drawing.Size(568, 309);
            this.gridValeurStock.TabIndex = 1;
            // 
            // cmdQuitter
            // 
            this.cmdQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdQuitter.Image = global::App.EasyShop.Properties.Resources.exit;
            this.cmdQuitter.Location = new System.Drawing.Point(505, 533);
            this.cmdQuitter.Name = "cmdQuitter";
            this.cmdQuitter.Size = new System.Drawing.Size(75, 40);
            this.cmdQuitter.TabIndex = 3;
            this.toolTip.SetToolTip(this.cmdQuitter, "Quitter");
            this.cmdQuitter.UseVisualStyleBackColor = true;
            this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Valeur du Stock";
            // 
            // txtValeurStock
            // 
            this.txtValeurStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValeurStock.Location = new System.Drawing.Point(447, 169);
            this.txtValeurStock.Name = "txtValeurStock";
            this.txtValeurStock.ReadOnly = true;
            this.txtValeurStock.Size = new System.Drawing.Size(133, 20);
            this.txtValeurStock.TabIndex = 5;
            this.txtValeurStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmdImprimer
            // 
            this.cmdImprimer.Image = global::App.EasyShop.Properties.Resources.printer1;
            this.cmdImprimer.Location = new System.Drawing.Point(12, 533);
            this.cmdImprimer.Name = "cmdImprimer";
            this.cmdImprimer.Size = new System.Drawing.Size(75, 40);
            this.cmdImprimer.TabIndex = 2;
            this.toolTip.SetToolTip(this.cmdImprimer, "Imprimer");
            this.cmdImprimer.UseVisualStyleBackColor = true;
            this.cmdImprimer.Click += new System.EventHandler(this.cmdImprimer_Click);
            // 
            // FormValeurStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdQuitter;
            this.ClientSize = new System.Drawing.Size(592, 581);
            this.Controls.Add(this.txtValeurStock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdQuitter);
            this.Controls.Add(this.cmdImprimer);
            this.Controls.Add(this.gridValeurStock);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormValeurStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Valeur stock";
            this.Load += new System.EventHandler(this.FormValeurStock_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDateInventaire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridValeurStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gridValeurStock;
        private System.Windows.Forms.Button cmdImprimer;
        private System.Windows.Forms.Button cmdQuitter;
        private System.Windows.Forms.DataGridView gridDateInventaire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValeurStock;
        private System.Windows.Forms.ToolTip toolTip;
    }
}