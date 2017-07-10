namespace WFA_SimaFlex_MP_Stock
{

    partial class frmMgsTissu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMgsTissu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbxExistant = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvMgsTissu = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxGestion = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.btnOkSortie = new System.Windows.Forms.Button();
            this.cbxSortieRéférence = new System.Windows.Forms.ComboBox();
            this.cbxSortieCouleur = new System.Windows.Forms.ComboBox();
            this.cbxSortieCatégorie = new System.Windows.Forms.ComboBox();
            this.cbxId = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.btnEntréeOk = new System.Windows.Forms.Button();
            this.cbxRéférence = new System.Windows.Forms.ComboBox();
            this.cbxCouleur = new System.Windows.Forms.ComboBox();
            this.cbxCatégorie = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbxCount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnMgsTissuToAcceuil = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnCount = new System.Windows.Forms.Button();
            this.gbxExistant.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMgsTissu)).BeginInit();
            this.gbxGestion.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::WFA_SimaFlex_MP_Stock.Properties.Resources.Matelas;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 115);
            this.panel1.TabIndex = 10;
            // 
            // gbxExistant
            // 
            this.gbxExistant.Controls.Add(this.panel3);
            this.gbxExistant.Controls.Add(this.panel6);
            this.gbxExistant.Controls.Add(this.dgvMgsTissu);
            this.gbxExistant.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxExistant.ForeColor = System.Drawing.SystemColors.Desktop;
            this.gbxExistant.Location = new System.Drawing.Point(431, 2);
            this.gbxExistant.Name = "gbxExistant";
            this.gbxExistant.Size = new System.Drawing.Size(910, 565);
            this.gbxExistant.TabIndex = 11;
            this.gbxExistant.TabStop = false;
            this.gbxExistant.Text = "L\'Inventaire du stock Tissu:";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::WFA_SimaFlex_MP_Stock.Properties.Resources.Logo2;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(516, 565);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(179, 57);
            this.panel3.TabIndex = 9;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.textBox1);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(0, 565);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(504, 57);
            this.panel6.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(330, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(159, 26);
            this.textBox1.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(321, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Nombre totale des articles au magasin:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvMgsTissu
            // 
            this.dgvMgsTissu.AllowUserToDeleteRows = false;
            this.dgvMgsTissu.BackgroundColor = System.Drawing.Color.LightGreen;
            this.dgvMgsTissu.ColumnHeadersHeight = 40;
            this.dgvMgsTissu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4,
            this.Column7,
            this.Column6});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMgsTissu.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMgsTissu.Location = new System.Drawing.Point(8, 34);
            this.dgvMgsTissu.Name = "dgvMgsTissu";
            this.dgvMgsTissu.ReadOnly = true;
            this.dgvMgsTissu.Size = new System.Drawing.Size(898, 525);
            this.dgvMgsTissu.TabIndex = 0;
            this.dgvMgsTissu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMgsTissu_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "IdArticles";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 110;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Référence";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Couleur";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 130;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "TypesCatégories";
            this.Column5.MinimumWidth = 10;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "IdCommandes";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 160;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "IdFournisseur";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 160;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "NomFournisseur";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 200;
            // 
            // gbxGestion
            // 
            this.gbxGestion.Controls.Add(this.panel5);
            this.gbxGestion.Controls.Add(this.panel4);
            this.gbxGestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxGestion.Location = new System.Drawing.Point(4, 123);
            this.gbxGestion.Name = "gbxGestion";
            this.gbxGestion.Size = new System.Drawing.Size(425, 503);
            this.gbxGestion.TabIndex = 12;
            this.gbxGestion.TabStop = false;
            this.gbxGestion.Text = "Entrées et Sorties du Magasin Tissu:";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.btnOkSortie);
            this.panel5.Controls.Add(this.cbxSortieRéférence);
            this.panel5.Controls.Add(this.cbxSortieCouleur);
            this.panel5.Controls.Add(this.cbxSortieCatégorie);
            this.panel5.Controls.Add(this.cbxId);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(6, 267);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(388, 228);
            this.panel5.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Pink;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(52, 191);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(250, 24);
            this.label11.TabIndex = 11;
            this.label11.Text = "Confirmer la Transaction: ";
            // 
            // btnOkSortie
            // 
            this.btnOkSortie.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOkSortie.ForeColor = System.Drawing.Color.Black;
            this.btnOkSortie.Location = new System.Drawing.Point(308, 185);
            this.btnOkSortie.Name = "btnOkSortie";
            this.btnOkSortie.Size = new System.Drawing.Size(75, 37);
            this.btnOkSortie.TabIndex = 10;
            this.btnOkSortie.Text = "OK";
            this.btnOkSortie.UseVisualStyleBackColor = true;
            // 
            // cbxSortieRéférence
            // 
            this.cbxSortieRéférence.BackColor = System.Drawing.Color.NavajoWhite;
            this.cbxSortieRéférence.FormattingEnabled = true;
            this.cbxSortieRéférence.Location = new System.Drawing.Point(230, 152);
            this.cbxSortieRéférence.Name = "cbxSortieRéférence";
            this.cbxSortieRéférence.Size = new System.Drawing.Size(145, 32);
            this.cbxSortieRéférence.TabIndex = 9;
            // 
            // cbxSortieCouleur
            // 
            this.cbxSortieCouleur.BackColor = System.Drawing.Color.NavajoWhite;
            this.cbxSortieCouleur.FormattingEnabled = true;
            this.cbxSortieCouleur.Location = new System.Drawing.Point(230, 114);
            this.cbxSortieCouleur.Name = "cbxSortieCouleur";
            this.cbxSortieCouleur.Size = new System.Drawing.Size(145, 32);
            this.cbxSortieCouleur.TabIndex = 8;
            // 
            // cbxSortieCatégorie
            // 
            this.cbxSortieCatégorie.BackColor = System.Drawing.Color.NavajoWhite;
            this.cbxSortieCatégorie.FormattingEnabled = true;
            this.cbxSortieCatégorie.Location = new System.Drawing.Point(230, 76);
            this.cbxSortieCatégorie.Name = "cbxSortieCatégorie";
            this.cbxSortieCatégorie.Size = new System.Drawing.Size(145, 32);
            this.cbxSortieCatégorie.TabIndex = 7;
            // 
            // cbxId
            // 
            this.cbxId.BackColor = System.Drawing.Color.NavajoWhite;
            this.cbxId.FormattingEnabled = true;
            this.cbxId.Location = new System.Drawing.Point(230, 38);
            this.cbxId.Name = "cbxId";
            this.cbxId.Size = new System.Drawing.Size(145, 32);
            this.cbxId.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Sienna;
            this.label9.Location = new System.Drawing.Point(4, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 24);
            this.label9.TabIndex = 5;
            this.label9.Text = "Référence:";
            // 
            // label8
            // 
            this.label8.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Sienna;
            this.label8.Location = new System.Drawing.Point(4, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 24);
            this.label8.TabIndex = 4;
            this.label8.Text = "Couleur:";
            // 
            // label7
            // 
            this.label7.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Sienna;
            this.label7.Location = new System.Drawing.Point(4, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 24);
            this.label7.TabIndex = 3;
            this.label7.Text = "Catégorie:";
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Sienna;
            this.label6.Location = new System.Drawing.Point(3, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "l\'Identifiant (IdArticles):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(360, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Evacuer Un Article Tissu du magasin:";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.btnEntréeOk);
            this.panel4.Controls.Add(this.cbxRéférence);
            this.panel4.Controls.Add(this.cbxCouleur);
            this.panel4.Controls.Add(this.cbxCatégorie);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(6, 37);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(388, 224);
            this.panel4.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(52, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(250, 24);
            this.label10.TabIndex = 8;
            this.label10.Text = "Confirmer la Transaction: ";
            // 
            // btnEntréeOk
            // 
            this.btnEntréeOk.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntréeOk.ForeColor = System.Drawing.Color.Black;
            this.btnEntréeOk.Location = new System.Drawing.Point(308, 182);
            this.btnEntréeOk.Name = "btnEntréeOk";
            this.btnEntréeOk.Size = new System.Drawing.Size(75, 37);
            this.btnEntréeOk.TabIndex = 7;
            this.btnEntréeOk.Text = "OK";
            this.btnEntréeOk.UseVisualStyleBackColor = true;
            this.btnEntréeOk.Click += new System.EventHandler(this.btnEntréeOk_Click);
            // 
            // cbxRéférence
            // 
            this.cbxRéférence.BackColor = System.Drawing.Color.LightGreen;
            this.cbxRéférence.FormattingEnabled = true;
            this.cbxRéférence.Location = new System.Drawing.Point(153, 132);
            this.cbxRéférence.Name = "cbxRéférence";
            this.cbxRéférence.Size = new System.Drawing.Size(222, 32);
            this.cbxRéférence.TabIndex = 6;
            // 
            // cbxCouleur
            // 
            this.cbxCouleur.BackColor = System.Drawing.Color.LightGreen;
            this.cbxCouleur.FormattingEnabled = true;
            this.cbxCouleur.Location = new System.Drawing.Point(153, 94);
            this.cbxCouleur.Name = "cbxCouleur";
            this.cbxCouleur.Size = new System.Drawing.Size(222, 32);
            this.cbxCouleur.TabIndex = 5;
            // 
            // cbxCatégorie
            // 
            this.cbxCatégorie.BackColor = System.Drawing.Color.LightGreen;
            this.cbxCatégorie.FormattingEnabled = true;
            this.cbxCatégorie.Location = new System.Drawing.Point(153, 56);
            this.cbxCatégorie.Name = "cbxCatégorie";
            this.cbxCatégorie.Size = new System.Drawing.Size(222, 32);
            this.cbxCatégorie.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(4, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Référence:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(4, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Couleur:";
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(4, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Catégorie:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajouter Un Article Tissu au magasin:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tbxCount);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(557, 569);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(384, 57);
            this.panel2.TabIndex = 13;
            // 
            // tbxCount
            // 
            this.tbxCount.BackColor = System.Drawing.Color.Aquamarine;
            this.tbxCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCount.Location = new System.Drawing.Point(322, 14);
            this.tbxCount.Name = "tbxCount";
            this.tbxCount.ReadOnly = true;
            this.tbxCount.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxCount.Size = new System.Drawing.Size(56, 29);
            this.tbxCount.TabIndex = 1;
            this.tbxCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxCount.TextChanged += new System.EventHandler(this.tbxCount_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label12.Location = new System.Drawing.Point(3, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(321, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Nombre totale des articles au magasin:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMgsTissuToAcceuil
            // 
            this.btnMgsTissuToAcceuil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMgsTissuToAcceuil.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnMgsTissuToAcceuil.Location = new System.Drawing.Point(1132, 569);
            this.btnMgsTissuToAcceuil.Name = "btnMgsTissuToAcceuil";
            this.btnMgsTissuToAcceuil.Size = new System.Drawing.Size(159, 59);
            this.btnMgsTissuToAcceuil.TabIndex = 14;
            this.btnMgsTissuToAcceuil.Text = "Retour à l\'Acceuil";
            this.btnMgsTissuToAcceuil.UseVisualStyleBackColor = true;
            this.btnMgsTissuToAcceuil.Click += new System.EventHandler(this.btnMgsTissuToAcceuil_Click);
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = global::WFA_SimaFlex_MP_Stock.Properties.Resources.Logo2;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel7.Location = new System.Drawing.Point(945, 569);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(181, 57);
            this.panel7.TabIndex = 15;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Location = new System.Drawing.Point(1286, 568);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 60);
            this.button3.TabIndex = 16;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel8
            // 
            this.panel8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel8.BackgroundImage")));
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel8.Location = new System.Drawing.Point(218, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(211, 115);
            this.panel8.TabIndex = 17;
            // 
            // btnCount
            // 
            this.btnCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCount.ForeColor = System.Drawing.Color.Crimson;
            this.btnCount.Location = new System.Drawing.Point(439, 568);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(112, 60);
            this.btnCount.TabIndex = 18;
            this.btnCount.Text = "Actualiser";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click_1);
            // 
            // frmMgsTissu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 629);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.btnMgsTissuToAcceuil);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gbxGestion);
            this.Controls.Add(this.gbxExistant);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMgsTissu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Magasin Tissu";
            this.Load += new System.EventHandler(this.frmMgsTissu_Load);
            this.gbxExistant.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMgsTissu)).EndInit();
            this.gbxGestion.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbxExistant;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvMgsTissu;
        private System.Windows.Forms.GroupBox gbxGestion;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnOkSortie;
        private System.Windows.Forms.ComboBox cbxSortieRéférence;
        private System.Windows.Forms.ComboBox cbxSortieCouleur;
        private System.Windows.Forms.ComboBox cbxSortieCatégorie;
        private System.Windows.Forms.ComboBox cbxId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnEntréeOk;
        private System.Windows.Forms.ComboBox cbxRéférence;
        private System.Windows.Forms.ComboBox cbxCouleur;
        private System.Windows.Forms.ComboBox cbxCatégorie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbxCount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnMgsTissuToAcceuil;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnCount;
    }
}