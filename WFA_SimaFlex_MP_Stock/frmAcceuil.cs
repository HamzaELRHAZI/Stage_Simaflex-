using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_SimaFlex_MP_Stock
{
    public partial class frmAcceuil : Form
    {
        public frmAcceuil()
        {
            InitializeComponent();

        }

        private void btnEntrerMgsTissu_Click(object sender, EventArgs e)
        {
            
            this.Hide();
          
            MessageBox.Show("Accès au magasin du stock des articles Tissu");
            frmMgsTissu frmMgsTissu= new frmMgsTissu();
            frmMgsTissu.Show();  
                                                        
            
        }

        private void frmAcceuil_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrerMgsCarton_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMgsCarton frmMgsCarton = new frmMgsCarton();
            
           
           
            MessageBox.Show("Accès au magasin du stock des articles Carton");
            
            frmMgsCarton.Show();
              

        }

        private void btnEntrerMgsRuban_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMgsRuban frmMgsRuban = new frmMgsRuban();



            MessageBox.Show("Accès au magasin du stock des articles Ruban");

            frmMgsRuban.Show();
        }

        private void btnGestionCommandes_Click(object sender, EventArgs e)
        {
            frmGestionnaireCommandes frmGestionnaireCommandes = new frmGestionnaireCommandes();

            this.Hide();
          



            MessageBox.Show("Accès au Gestionnaire de Commandes d'approvisionnement");

            frmGestionnaireCommandes.Show();
        }
    }
}
