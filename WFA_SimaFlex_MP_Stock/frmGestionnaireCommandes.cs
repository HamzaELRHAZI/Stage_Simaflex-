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
    public partial class frmGestionnaireCommandes : Form
    {
        public frmGestionnaireCommandes()
        {
            InitializeComponent();
        }

        private void frmGestionnaireCommandes_Load(object sender, EventArgs e)
        {

            this.ControlBox = false;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMgsTissuToAcceuil_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAcceuil frmAcceuil = new frmAcceuil();
            frmAcceuil.Show();
        }
    }
}
