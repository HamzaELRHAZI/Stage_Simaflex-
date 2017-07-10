namespace WFA_SimaFlex_MP_Stock
{
    partial class frmGestionnaireCommandes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionnaireCommandes));
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnMgsTissuToAcceuil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQuit
            // 
            this.btnQuit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuit.BackgroundImage")));
            this.btnQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuit.Location = new System.Drawing.Point(155, 88);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(103, 104);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnMgsTissuToAcceuil
            // 
            this.btnMgsTissuToAcceuil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMgsTissuToAcceuil.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnMgsTissuToAcceuil.Location = new System.Drawing.Point(12, 198);
            this.btnMgsTissuToAcceuil.Name = "btnMgsTissuToAcceuil";
            this.btnMgsTissuToAcceuil.Size = new System.Drawing.Size(159, 57);
            this.btnMgsTissuToAcceuil.TabIndex = 11;
            this.btnMgsTissuToAcceuil.Text = "Retour à l\'Acceuil";
            this.btnMgsTissuToAcceuil.UseVisualStyleBackColor = true;
            this.btnMgsTissuToAcceuil.Click += new System.EventHandler(this.btnMgsTissuToAcceuil_Click);
            // 
            // frmGestionnaireCommandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnMgsTissuToAcceuil);
            this.Controls.Add(this.btnQuit);
            this.Name = "frmGestionnaireCommandes";
            this.Text = "frmGestionnaireCommandes";
            this.Load += new System.EventHandler(this.frmGestionnaireCommandes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnMgsTissuToAcceuil;
    }
}