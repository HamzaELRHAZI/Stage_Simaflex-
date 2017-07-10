using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_SimaFlex_MP_Stock
{
    public partial class frmMgsTissutestEF : Form
    {
        public frmMgsTissutestEF()
        {
            InitializeComponent();


        }

        private void frmMgsTissutestEF_Load(object sender, EventArgs e)
        {

            //// Create the Context
            //EntityConnection conn = new EntityConnection("name= ModelWFAEFContainer");
            //ObjectContext context = new ObjectContext(conn);
            var ctx = new ModelStockContainer();
            var query = ctx.ArticlesSet.Where(c => c.IdArticles >= 0);
            articlesBindingSource.DataSource = query.ToList();

            //EntityConnection conn = new EntityConnection("name= ModelStockContainer");
            //ObjectContext context = new ObjectContext(conn);
            // customerBindingSource.DataSource = query.ToList();

        }
    }

   


    
}
