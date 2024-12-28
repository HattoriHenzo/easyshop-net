namespace App.EasyShop.FormArticle
{
    partial class FormDisplayArticles
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridArticle = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nouveauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.entréesSortiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdRecherche = new System.Windows.Forms.Button();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cmdConversion = new System.Windows.Forms.Button();
            this.cmdQuitter = new System.Windows.Forms.Button();
            this.cmdImprimer = new System.Windows.Forms.Button();
            this.cmdRechByCategorie = new System.Windows.Forms.Button();
            this.cmdSorties = new System.Windows.Forms.Button();
            this.cmdSupprimer = new System.Windows.Forms.Button();
            this.cmdModifier = new System.Windows.Forms.Button();
            this.cmdNouveau = new System.Windows.Forms.Button();
            this.txtEtatArticle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxCategorie = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreArticle = new System.Windows.Forms.TextBox();
            this.txtperemption = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxoptions = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.articleBOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idArtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelleArtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qteStockArtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seuilArtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixAchatArtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixVenteArtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixEnDemiGrosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixEnGrosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qteEnGrosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coutSortieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateEnreg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Utilisateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridArticle)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articleBOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridArticle
            // 
            this.gridArticle.AllowUserToAddRows = false;
            this.gridArticle.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.gridArticle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridArticle.AutoGenerateColumns = false;
            this.gridArticle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
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
            this.qteStockArtDataGridViewTextBoxColumn,
            this.seuilArtDataGridViewTextBoxColumn,
            this.prixAchatArtDataGridViewTextBoxColumn,
            this.prixVenteArtDataGridViewTextBoxColumn,
            this.prixEnDemiGrosDataGridViewTextBoxColumn,
            this.prixEnGrosDataGridViewTextBoxColumn,
            this.qteEnGrosDataGridViewTextBoxColumn,
            this.coutSortieDataGridViewTextBoxColumn,
            this.categorieDataGridViewTextBoxColumn,
            this.IdUser,
            this.DateEnreg,
            this.Utilisateur});
            this.gridArticle.ContextMenuStrip = this.contextMenuStrip;
            this.gridArticle.DataSource = this.articleBOBindingSource;
            this.gridArticle.Location = new System.Drawing.Point(16, 123);
            this.gridArticle.Margin = new System.Windows.Forms.Padding(4);
            this.gridArticle.MultiSelect = false;
            this.gridArticle.Name = "gridArticle";
            this.gridArticle.ReadOnly = true;
            this.gridArticle.RowHeadersWidth = 51;
            this.gridArticle.RowTemplate.Height = 20;
            this.gridArticle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridArticle.Size = new System.Drawing.Size(1155, 399);
            this.gridArticle.TabIndex = 3;
            this.gridArticle.SelectionChanged += new System.EventHandler(this.gridArticle_SelectionChanged);
            this.gridArticle.DoubleClick += new System.EventHandler(this.gridArticle_DoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauToolStripMenuItem,
            this.toolStripSeparator2,
            this.modifierToolStripMenuItem,
            this.toolStripSeparator1,
            this.entréesSortiesToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(182, 94);
            // 
            // nouveauToolStripMenuItem
            // 
            this.nouveauToolStripMenuItem.Image = global::App.EasyShop.Properties.Resources.edit_add;
            this.nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
            this.nouveauToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.nouveauToolStripMenuItem.Text = "Nouveau";
            this.nouveauToolStripMenuItem.Click += new System.EventHandler(this.nouveauToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(178, 6);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Image = global::App.EasyShop.Properties.Resources.edit;
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // entréesSortiesToolStripMenuItem
            // 
            this.entréesSortiesToolStripMenuItem.Image = global::App.EasyShop.Properties.Resources.reload;
            this.entréesSortiesToolStripMenuItem.Name = "entréesSortiesToolStripMenuItem";
            this.entréesSortiesToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.entréesSortiesToolStripMenuItem.Text = "Entrées/Sorties";
            this.entréesSortiesToolStripMenuItem.Click += new System.EventHandler(this.entréesSortiesToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdRecherche);
            this.groupBox1.Controls.Add(this.txtRecherche);
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(371, 87);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recherche";
            // 
            // cmdRecherche
            // 
            this.cmdRecherche.Image = global::App.EasyShop.Properties.Resources.Search_2;
            this.cmdRecherche.Location = new System.Drawing.Point(284, 17);
            this.cmdRecherche.Margin = new System.Windows.Forms.Padding(4);
            this.cmdRecherche.Name = "cmdRecherche";
            this.cmdRecherche.Size = new System.Drawing.Size(71, 60);
            this.cmdRecherche.TabIndex = 2;
            this.toolTip.SetToolTip(this.cmdRecherche, "Cliquer ici pour lancer la recherche");
            this.cmdRecherche.UseVisualStyleBackColor = true;
            this.cmdRecherche.Click += new System.EventHandler(this.cmdRecherche_Click);
            // 
            // txtRecherche
            // 
            this.txtRecherche.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRecherche.Location = new System.Drawing.Point(21, 38);
            this.txtRecherche.Margin = new System.Windows.Forms.Padding(4);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(252, 22);
            this.txtRecherche.TabIndex = 0;
            this.toolTip.SetToolTip(this.txtRecherche, "Taper le nom de l\'article recherché");
            // 
            // cmdConversion
            // 
            this.cmdConversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConversion.Location = new System.Drawing.Point(968, 538);
            this.cmdConversion.Margin = new System.Windows.Forms.Padding(4);
            this.cmdConversion.Name = "cmdConversion";
            this.cmdConversion.Size = new System.Drawing.Size(97, 49);
            this.cmdConversion.TabIndex = 18;
            this.cmdConversion.Text = "€";
            this.cmdConversion.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTip.SetToolTip(this.cmdConversion, "Conversion en Euro");
            this.cmdConversion.UseVisualStyleBackColor = true;
            this.cmdConversion.Click += new System.EventHandler(this.cmdConversion_Click);
            // 
            // cmdQuitter
            // 
            this.cmdQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdQuitter.Image = global::App.EasyShop.Properties.Resources.exit;
            this.cmdQuitter.Location = new System.Drawing.Point(1073, 538);
            this.cmdQuitter.Margin = new System.Windows.Forms.Padding(4);
            this.cmdQuitter.Name = "cmdQuitter";
            this.cmdQuitter.Size = new System.Drawing.Size(97, 49);
            this.cmdQuitter.TabIndex = 7;
            this.toolTip.SetToolTip(this.cmdQuitter, "Fermer");
            this.cmdQuitter.UseVisualStyleBackColor = true;
            this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
            // 
            // cmdImprimer
            // 
            this.cmdImprimer.Image = global::App.EasyShop.Properties.Resources.printer1;
            this.cmdImprimer.Location = new System.Drawing.Point(420, 538);
            this.cmdImprimer.Margin = new System.Windows.Forms.Padding(4);
            this.cmdImprimer.Name = "cmdImprimer";
            this.cmdImprimer.Size = new System.Drawing.Size(97, 49);
            this.cmdImprimer.TabIndex = 17;
            this.toolTip.SetToolTip(this.cmdImprimer, "Imprimer la liste des articles");
            this.cmdImprimer.UseVisualStyleBackColor = true;
            this.cmdImprimer.Click += new System.EventHandler(this.cmdImprimer_Click);
            // 
            // cmdRechByCategorie
            // 
            this.cmdRechByCategorie.Image = global::App.EasyShop.Properties.Resources.Search;
            this.cmdRechByCategorie.Location = new System.Drawing.Point(255, 17);
            this.cmdRechByCategorie.Margin = new System.Windows.Forms.Padding(4);
            this.cmdRechByCategorie.Name = "cmdRechByCategorie";
            this.cmdRechByCategorie.Size = new System.Drawing.Size(71, 60);
            this.cmdRechByCategorie.TabIndex = 4;
            this.toolTip.SetToolTip(this.cmdRechByCategorie, "Recherche par catégorie");
            this.cmdRechByCategorie.UseVisualStyleBackColor = true;
            this.cmdRechByCategorie.Click += new System.EventHandler(this.cmdRechByCategorie_Click);
            // 
            // cmdSorties
            // 
            this.cmdSorties.Image = global::App.EasyShop.Properties.Resources.reload;
            this.cmdSorties.Location = new System.Drawing.Point(319, 538);
            this.cmdSorties.Margin = new System.Windows.Forms.Padding(4);
            this.cmdSorties.Name = "cmdSorties";
            this.cmdSorties.Size = new System.Drawing.Size(97, 49);
            this.cmdSorties.TabIndex = 8;
            this.toolTip.SetToolTip(this.cmdSorties, "Entrée/Sortie");
            this.cmdSorties.UseVisualStyleBackColor = true;
            this.cmdSorties.Click += new System.EventHandler(this.cmdSorties_Click);
            // 
            // cmdSupprimer
            // 
            this.cmdSupprimer.Image = global::App.EasyShop.Properties.Resources.button_cancel;
            this.cmdSupprimer.Location = new System.Drawing.Point(217, 538);
            this.cmdSupprimer.Margin = new System.Windows.Forms.Padding(4);
            this.cmdSupprimer.Name = "cmdSupprimer";
            this.cmdSupprimer.Size = new System.Drawing.Size(97, 49);
            this.cmdSupprimer.TabIndex = 6;
            this.toolTip.SetToolTip(this.cmdSupprimer, "Supprimer");
            this.cmdSupprimer.UseVisualStyleBackColor = true;
            this.cmdSupprimer.Click += new System.EventHandler(this.cmdSupprimer_Click);
            // 
            // cmdModifier
            // 
            this.cmdModifier.Image = global::App.EasyShop.Properties.Resources.edit;
            this.cmdModifier.Location = new System.Drawing.Point(116, 538);
            this.cmdModifier.Margin = new System.Windows.Forms.Padding(4);
            this.cmdModifier.Name = "cmdModifier";
            this.cmdModifier.Size = new System.Drawing.Size(97, 49);
            this.cmdModifier.TabIndex = 5;
            this.toolTip.SetToolTip(this.cmdModifier, "Modifier");
            this.cmdModifier.UseVisualStyleBackColor = true;
            this.cmdModifier.Click += new System.EventHandler(this.cmdModifier_Click);
            // 
            // cmdNouveau
            // 
            this.cmdNouveau.Image = global::App.EasyShop.Properties.Resources.edit_add;
            this.cmdNouveau.Location = new System.Drawing.Point(15, 538);
            this.cmdNouveau.Margin = new System.Windows.Forms.Padding(4);
            this.cmdNouveau.Name = "cmdNouveau";
            this.cmdNouveau.Size = new System.Drawing.Size(97, 49);
            this.cmdNouveau.TabIndex = 4;
            this.toolTip.SetToolTip(this.cmdNouveau, "Nouveau");
            this.cmdNouveau.UseVisualStyleBackColor = true;
            this.cmdNouveau.Click += new System.EventHandler(this.cmdNouveau_Click);
            // 
            // txtEtatArticle
            // 
            this.txtEtatArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEtatArticle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEtatArticle.Location = new System.Drawing.Point(909, 78);
            this.txtEtatArticle.Margin = new System.Windows.Forms.Padding(4);
            this.txtEtatArticle.Name = "txtEtatArticle";
            this.txtEtatArticle.ReadOnly = true;
            this.txtEtatArticle.Size = new System.Drawing.Size(260, 23);
            this.txtEtatArticle.TabIndex = 14;
            this.txtEtatArticle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(808, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Etat du stock";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdRechByCategorie);
            this.groupBox2.Controls.Add(this.cbxCategorie);
            this.groupBox2.Location = new System.Drawing.Point(409, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(341, 87);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recherche par Catégorie";
            // 
            // cbxCategorie
            // 
            this.cbxCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategorie.DropDownWidth = 180;
            this.cbxCategorie.FormattingEnabled = true;
            this.cbxCategorie.Location = new System.Drawing.Point(20, 38);
            this.cbxCategorie.Margin = new System.Windows.Forms.Padding(4);
            this.cbxCategorie.Name = "cbxCategorie";
            this.cbxCategorie.Size = new System.Drawing.Size(223, 24);
            this.cbxCategorie.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(580, 556);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nombre d\'Articles";
            // 
            // txtNombreArticle
            // 
            this.txtNombreArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreArticle.Location = new System.Drawing.Point(724, 551);
            this.txtNombreArticle.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreArticle.Name = "txtNombreArticle";
            this.txtNombreArticle.ReadOnly = true;
            this.txtNombreArticle.Size = new System.Drawing.Size(104, 23);
            this.txtNombreArticle.TabIndex = 16;
            this.txtNombreArticle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtperemption
            // 
            this.txtperemption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtperemption.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtperemption.Location = new System.Drawing.Point(909, 47);
            this.txtperemption.Margin = new System.Windows.Forms.Padding(4);
            this.txtperemption.Name = "txtperemption";
            this.txtperemption.ReadOnly = true;
            this.txtperemption.Size = new System.Drawing.Size(260, 23);
            this.txtperemption.TabIndex = 19;
            this.txtperemption.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(793, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Etat peremption";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbxoptions
            // 
            this.cbxoptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxoptions.DropDownWidth = 180;
            this.cbxoptions.FormattingEnabled = true;
            this.cbxoptions.Items.AddRange(new object[] {
            "En cours de peremption"});
            this.cbxoptions.Location = new System.Drawing.Point(958, 15);
            this.cbxoptions.Margin = new System.Windows.Forms.Padding(4);
            this.cbxoptions.Name = "cbxoptions";
            this.cbxoptions.Size = new System.Drawing.Size(211, 24);
            this.cbxoptions.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(790, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Filtre niveau peremption";
            // 
            // articleBOBindingSource
            // 
            this.articleBOBindingSource.DataSource = typeof(App.BusinessObject.ArticleBO);
            // 
            // idArtDataGridViewTextBoxColumn
            // 
            this.idArtDataGridViewTextBoxColumn.DataPropertyName = "IdArt";
            this.idArtDataGridViewTextBoxColumn.HeaderText = "IdArt";
            this.idArtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idArtDataGridViewTextBoxColumn.Name = "idArtDataGridViewTextBoxColumn";
            this.idArtDataGridViewTextBoxColumn.ReadOnly = true;
            this.idArtDataGridViewTextBoxColumn.Visible = false;
            this.idArtDataGridViewTextBoxColumn.Width = 125;
            // 
            // libelleArtDataGridViewTextBoxColumn
            // 
            this.libelleArtDataGridViewTextBoxColumn.DataPropertyName = "LibelleArt";
            this.libelleArtDataGridViewTextBoxColumn.HeaderText = "Article";
            this.libelleArtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.libelleArtDataGridViewTextBoxColumn.Name = "libelleArtDataGridViewTextBoxColumn";
            this.libelleArtDataGridViewTextBoxColumn.ReadOnly = true;
            this.libelleArtDataGridViewTextBoxColumn.Width = 200;
            // 
            // qteStockArtDataGridViewTextBoxColumn
            // 
            this.qteStockArtDataGridViewTextBoxColumn.DataPropertyName = "QteStockArt";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.qteStockArtDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.qteStockArtDataGridViewTextBoxColumn.HeaderText = "Quantité en stock";
            this.qteStockArtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.qteStockArtDataGridViewTextBoxColumn.Name = "qteStockArtDataGridViewTextBoxColumn";
            this.qteStockArtDataGridViewTextBoxColumn.ReadOnly = true;
            this.qteStockArtDataGridViewTextBoxColumn.Width = 125;
            // 
            // seuilArtDataGridViewTextBoxColumn
            // 
            this.seuilArtDataGridViewTextBoxColumn.DataPropertyName = "SeuilArt";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.seuilArtDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.seuilArtDataGridViewTextBoxColumn.HeaderText = "Seuil";
            this.seuilArtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.seuilArtDataGridViewTextBoxColumn.Name = "seuilArtDataGridViewTextBoxColumn";
            this.seuilArtDataGridViewTextBoxColumn.ReadOnly = true;
            this.seuilArtDataGridViewTextBoxColumn.Width = 125;
            // 
            // prixAchatArtDataGridViewTextBoxColumn
            // 
            this.prixAchatArtDataGridViewTextBoxColumn.DataPropertyName = "PrixAchatArt";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.prixAchatArtDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.prixAchatArtDataGridViewTextBoxColumn.HeaderText = "Prix d\'achat";
            this.prixAchatArtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prixAchatArtDataGridViewTextBoxColumn.Name = "prixAchatArtDataGridViewTextBoxColumn";
            this.prixAchatArtDataGridViewTextBoxColumn.ReadOnly = true;
            this.prixAchatArtDataGridViewTextBoxColumn.Width = 125;
            // 
            // prixVenteArtDataGridViewTextBoxColumn
            // 
            this.prixVenteArtDataGridViewTextBoxColumn.DataPropertyName = "PrixVenteArt";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.prixVenteArtDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.prixVenteArtDataGridViewTextBoxColumn.HeaderText = "Prix en détail";
            this.prixVenteArtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prixVenteArtDataGridViewTextBoxColumn.Name = "prixVenteArtDataGridViewTextBoxColumn";
            this.prixVenteArtDataGridViewTextBoxColumn.ReadOnly = true;
            this.prixVenteArtDataGridViewTextBoxColumn.Width = 125;
            // 
            // prixEnDemiGrosDataGridViewTextBoxColumn
            // 
            this.prixEnDemiGrosDataGridViewTextBoxColumn.DataPropertyName = "PrixEnDemiGros";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.prixEnDemiGrosDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.prixEnDemiGrosDataGridViewTextBoxColumn.HeaderText = "Prix en démi gros";
            this.prixEnDemiGrosDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prixEnDemiGrosDataGridViewTextBoxColumn.Name = "prixEnDemiGrosDataGridViewTextBoxColumn";
            this.prixEnDemiGrosDataGridViewTextBoxColumn.ReadOnly = true;
            this.prixEnDemiGrosDataGridViewTextBoxColumn.Width = 125;
            // 
            // prixEnGrosDataGridViewTextBoxColumn
            // 
            this.prixEnGrosDataGridViewTextBoxColumn.DataPropertyName = "PrixEnGros";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.prixEnGrosDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.prixEnGrosDataGridViewTextBoxColumn.HeaderText = "Prix en gros";
            this.prixEnGrosDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prixEnGrosDataGridViewTextBoxColumn.Name = "prixEnGrosDataGridViewTextBoxColumn";
            this.prixEnGrosDataGridViewTextBoxColumn.ReadOnly = true;
            this.prixEnGrosDataGridViewTextBoxColumn.Width = 125;
            // 
            // qteEnGrosDataGridViewTextBoxColumn
            // 
            this.qteEnGrosDataGridViewTextBoxColumn.DataPropertyName = "QteEnGros";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.qteEnGrosDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.qteEnGrosDataGridViewTextBoxColumn.HeaderText = "Quantité en gros";
            this.qteEnGrosDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.qteEnGrosDataGridViewTextBoxColumn.Name = "qteEnGrosDataGridViewTextBoxColumn";
            this.qteEnGrosDataGridViewTextBoxColumn.ReadOnly = true;
            this.qteEnGrosDataGridViewTextBoxColumn.Width = 125;
            // 
            // coutSortieDataGridViewTextBoxColumn
            // 
            this.coutSortieDataGridViewTextBoxColumn.DataPropertyName = "CoutSortie";
            this.coutSortieDataGridViewTextBoxColumn.HeaderText = "CoutSortie";
            this.coutSortieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.coutSortieDataGridViewTextBoxColumn.Name = "coutSortieDataGridViewTextBoxColumn";
            this.coutSortieDataGridViewTextBoxColumn.ReadOnly = true;
            this.coutSortieDataGridViewTextBoxColumn.Visible = false;
            this.coutSortieDataGridViewTextBoxColumn.Width = 125;
            // 
            // categorieDataGridViewTextBoxColumn
            // 
            this.categorieDataGridViewTextBoxColumn.DataPropertyName = "Categorie";
            this.categorieDataGridViewTextBoxColumn.HeaderText = "Catégorie";
            this.categorieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categorieDataGridViewTextBoxColumn.Name = "categorieDataGridViewTextBoxColumn";
            this.categorieDataGridViewTextBoxColumn.ReadOnly = true;
            this.categorieDataGridViewTextBoxColumn.Width = 125;
            // 
            // IdUser
            // 
            this.IdUser.DataPropertyName = "IdUser";
            this.IdUser.HeaderText = "IdUser";
            this.IdUser.MinimumWidth = 6;
            this.IdUser.Name = "IdUser";
            this.IdUser.ReadOnly = true;
            this.IdUser.Width = 125;
            // 
            // DateEnreg
            // 
            this.DateEnreg.DataPropertyName = "DateEnreg";
            this.DateEnreg.HeaderText = "DateEnreg";
            this.DateEnreg.MinimumWidth = 6;
            this.DateEnreg.Name = "DateEnreg";
            this.DateEnreg.ReadOnly = true;
            this.DateEnreg.Width = 125;
            // 
            // Utilisateur
            // 
            this.Utilisateur.HeaderText = "Utilisateur";
            this.Utilisateur.MinimumWidth = 6;
            this.Utilisateur.Name = "Utilisateur";
            this.Utilisateur.ReadOnly = true;
            this.Utilisateur.Width = 125;
            // 
            // FormDisplayArticles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdQuitter;
            this.ClientSize = new System.Drawing.Size(1187, 598);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxoptions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtperemption);
            this.Controls.Add(this.cmdConversion);
            this.Controls.Add(this.cmdImprimer);
            this.Controls.Add(this.txtNombreArticle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtEtatArticle);
            this.Controls.Add(this.cmdSorties);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmdSupprimer);
            this.Controls.Add(this.cmdModifier);
            this.Controls.Add(this.cmdQuitter);
            this.Controls.Add(this.cmdNouveau);
            this.Controls.Add(this.gridArticle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormDisplayArticles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste des articles";
            this.Load += new System.EventHandler(this.FormDisplayArticles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridArticle)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.articleBOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridArticle;
        private System.Windows.Forms.Button cmdNouveau;
        private System.Windows.Forms.Button cmdModifier;
        private System.Windows.Forms.Button cmdSupprimer;
        private System.Windows.Forms.Button cmdQuitter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdRecherche;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button cmdSorties;
        private System.Windows.Forms.TextBox txtEtatArticle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbxCategorie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreArticle;
        private System.Windows.Forms.Button cmdRechByCategorie;
        private System.Windows.Forms.Button cmdImprimer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem nouveauToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem entréesSortiesToolStripMenuItem;
        private System.Windows.Forms.BindingSource articleBOBindingSource;
        private System.Windows.Forms.Button cmdConversion;
        private System.Windows.Forms.TextBox txtperemption;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxoptions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleArtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qteStockArtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seuilArtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixAchatArtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixVenteArtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixEnDemiGrosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixEnGrosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qteEnGrosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coutSortieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateEnreg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Utilisateur;
    }
}