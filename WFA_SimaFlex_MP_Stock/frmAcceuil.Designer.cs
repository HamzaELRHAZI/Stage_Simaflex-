namespace WFA_SimaFlex_MP_Stock
{
    partial class frmAcceuil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcceuil));
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMgsCarton = new System.Windows.Forms.Panel();
            this.btnEntrerMgsCarton = new System.Windows.Forms.Button();
            this.pnlMgsTissu = new System.Windows.Forms.Panel();
            this.btnEntrerMgsTissu = new System.Windows.Forms.Button();
            this.pnlMgsRuabn = new System.Windows.Forms.Panel();
            this.btnEntrerMgsRuban = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGestionCommandes = new System.Windows.Forms.Button();
            this.pnlMgsCarton.SuspendLayout();
            this.pnlMgsTissu.SuspendLayout();
            this.pnlMgsRuabn.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightPink;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(501, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Acceuil des magasins:";
            // 
            // pnlMgsCarton
            // 
            this.pnlMgsCarton.BackColor = System.Drawing.Color.SandyBrown;
            this.pnlMgsCarton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMgsCarton.BackgroundImage")));
            this.pnlMgsCarton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMgsCarton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMgsCarton.Controls.Add(this.btnEntrerMgsCarton);
            this.pnlMgsCarton.Location = new System.Drawing.Point(507, 118);
            this.pnlMgsCarton.Name = "pnlMgsCarton";
            this.pnlMgsCarton.Size = new System.Drawing.Size(310, 284);
            this.pnlMgsCarton.TabIndex = 1;
            // 
            // btnEntrerMgsCarton
            // 
            this.btnEntrerMgsCarton.Location = new System.Drawing.Point(80, 196);
            this.btnEntrerMgsCarton.Name = "btnEntrerMgsCarton";
            this.btnEntrerMgsCarton.Size = new System.Drawing.Size(149, 59);
            this.btnEntrerMgsCarton.TabIndex = 1;
            this.btnEntrerMgsCarton.Text = "Magasin Carton";
            this.btnEntrerMgsCarton.UseVisualStyleBackColor = true;
            this.btnEntrerMgsCarton.Click += new System.EventHandler(this.btnEntrerMgsCarton_Click);
            // 
            // pnlMgsTissu
            // 
            this.pnlMgsTissu.BackColor = System.Drawing.Color.Red;
            this.pnlMgsTissu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMgsTissu.BackgroundImage")));
            this.pnlMgsTissu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMgsTissu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMgsTissu.Controls.Add(this.btnEntrerMgsTissu);
            this.pnlMgsTissu.ForeColor = System.Drawing.SystemColors.WindowText;
            this.pnlMgsTissu.Location = new System.Drawing.Point(86, 118);
            this.pnlMgsTissu.Name = "pnlMgsTissu";
            this.pnlMgsTissu.Size = new System.Drawing.Size(320, 284);
            this.pnlMgsTissu.TabIndex = 2;
            // 
            // btnEntrerMgsTissu
            // 
            this.btnEntrerMgsTissu.Location = new System.Drawing.Point(74, 196);
            this.btnEntrerMgsTissu.Name = "btnEntrerMgsTissu";
            this.btnEntrerMgsTissu.Size = new System.Drawing.Size(149, 59);
            this.btnEntrerMgsTissu.TabIndex = 0;
            this.btnEntrerMgsTissu.Text = "Magasin Tissu";
            this.btnEntrerMgsTissu.UseVisualStyleBackColor = true;
            this.btnEntrerMgsTissu.Click += new System.EventHandler(this.btnEntrerMgsTissu_Click);
            // 
            // pnlMgsRuabn
            // 
            this.pnlMgsRuabn.BackColor = System.Drawing.Color.Violet;
            this.pnlMgsRuabn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMgsRuabn.BackgroundImage")));
            this.pnlMgsRuabn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMgsRuabn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMgsRuabn.Controls.Add(this.btnEntrerMgsRuban);
            this.pnlMgsRuabn.Location = new System.Drawing.Point(902, 123);
            this.pnlMgsRuabn.Name = "pnlMgsRuabn";
            this.pnlMgsRuabn.Size = new System.Drawing.Size(305, 279);
            this.pnlMgsRuabn.TabIndex = 2;
            // 
            // btnEntrerMgsRuban
            // 
            this.btnEntrerMgsRuban.Location = new System.Drawing.Point(81, 191);
            this.btnEntrerMgsRuban.Name = "btnEntrerMgsRuban";
            this.btnEntrerMgsRuban.Size = new System.Drawing.Size(149, 59);
            this.btnEntrerMgsRuban.TabIndex = 1;
            this.btnEntrerMgsRuban.Text = "Magasin Ruban";
            this.btnEntrerMgsRuban.UseVisualStyleBackColor = true;
            this.btnEntrerMgsRuban.Click += new System.EventHandler(this.btnEntrerMgsRuban_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuit.BackgroundImage")));
            this.btnQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuit.Location = new System.Drawing.Point(1206, 553);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(103, 104);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::WFA_SimaFlex_MP_Stock.Properties.Resources.photoLogo;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.btnGestionCommandes);
            this.panel1.Location = new System.Drawing.Point(407, 447);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 180);
            this.panel1.TabIndex = 4;
            // 
            // btnGestionCommandes
            // 
            this.btnGestionCommandes.BackColor = System.Drawing.Color.PaleGreen;
            this.btnGestionCommandes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionCommandes.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnGestionCommandes.Location = new System.Drawing.Point(100, 63);
            this.btnGestionCommandes.Name = "btnGestionCommandes";
            this.btnGestionCommandes.Size = new System.Drawing.Size(310, 61);
            this.btnGestionCommandes.TabIndex = 0;
            this.btnGestionCommandes.Text = "Gestionnaire de Commandes";
            this.btnGestionCommandes.UseVisualStyleBackColor = false;
            this.btnGestionCommandes.Click += new System.EventHandler(this.btnGestionCommandes_Click);
            // 
            // frmAcceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WFA_SimaFlex_MP_Stock.Properties.Resources.Logo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1311, 658);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlMgsCarton);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.pnlMgsRuabn);
            this.Controls.Add(this.pnlMgsTissu);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAcceuil";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acceuil des Magasins";
            this.Load += new System.EventHandler(this.frmAcceuil_Load);
            this.pnlMgsCarton.ResumeLayout(false);
            this.pnlMgsTissu.ResumeLayout(false);
            this.pnlMgsRuabn.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlMgsCarton;
        private System.Windows.Forms.Panel pnlMgsTissu;
        private System.Windows.Forms.Panel pnlMgsRuabn;
        private System.Windows.Forms.Button btnEntrerMgsCarton;
        private System.Windows.Forms.Button btnEntrerMgsTissu;
        private System.Windows.Forms.Button btnEntrerMgsRuban;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGestionCommandes;
    }
}

