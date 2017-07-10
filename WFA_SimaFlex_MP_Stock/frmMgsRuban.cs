using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_SimaFlex_MP_Stock
{
    public partial class frmMgsRuban : Form
    {
        SqlConnection cnx = new SqlConnection("Data Source=HAMZAELRHAZI-PC\\SQLEXPRESS;Initial Catalog=SimaFlex_MP_Stock_DB;Integrated Security=True");

        public frmMgsRuban()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMgsTissuToAcceuil_Click(object sender, EventArgs e)
        {
            // à refair
            this.Close();
            frmAcceuil frmAcceuil = new frmAcceuil();
            frmAcceuil.Show();
            //  
        }

        private void frmMgsRuban_Load(object sender, EventArgs e)
        {

            this.ControlBox = false;
            //remplir la combobox des couleurs par les couleurs
            comboBox2.Items.Add("Rouge");
            comboBox2.Items.Add("Bleu");
            comboBox2.Items.Add("Jaune");
            comboBox2.Items.Add("Vert");
            comboBox2.Items.Add("Marron");
            comboBox2.Items.Add("Rose");
            comboBox2.Items.Add("Orange");
            comboBox2.Items.Add("Turquoise");
            comboBox2.Items.Add("Grenadine");
            comboBox2.Items.Add("Violet");
            comboBox2.Items.Add("Bleu Cliel");
            comboBox2.Items.Add("Bleu Marine");
            comboBox2.Items.Add("Gris");
            comboBox2.Items.Add("Blanc");
            comboBox2.Items.Add("Noir");
            comboBox2.Items.Add("Choco");
            comboBox2.Items.Add("Lilas");
            comboBox2.Items.Add("Crème");
            comboBox2.Items.Add("Fushia");
            comboBox2.Items.Add("Vert Pomme");



            dgvMgsRuban.Rows.Clear();
            // Le chargement de la data grid view par les valeurs de la base de données
            // Ouvrir la connexion avec la db
            cnx.Open();
            SqlCommand cmd = new SqlCommand
                ("select    ArticlesSet.IdArticles , ArticlesSet.Référence,ArticlesSet.Couleur,Sous_CatégoriesSet.Type_Sous_Catégorie,CommandesSet.IdCommande,FournisseursSet.IdFournisseurs,FournisseursSet.Nom  From    ArticlesSet, Sous_CatégoriesSet, CommandesSet, CatégoriesSet, FournisseursSet  Where    ArticlesSet.Catégories_IdCatégories = CatégoriesSet.IdCatégories  AND  CatégoriesSet.IdCatégories = 2  AND  CatégoriesSet.IdCatégories = Sous_CatégoriesSet.Catégories_IdCatégories AND  ArticlesSet.Commandes_IdCommande = CommandesSet.IdCommande AND  CommandesSet.Fournisseurs_IdFournisseurs = FournisseursSet.IdFournisseurs AND ArticlesSet.Sous_Catégories_IdSous_Catégories = Sous_CatégoriesSet.IdSous_Catégories ", cnx);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dgvMgsRuban.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5], dr[6]);
            }
            dr.Close();
            cnx.Close();

            // le chargement du tbxCount par le nombre des articles dans le magasin tissu

            cnx.Open();
            SqlCommand cmd1 = new SqlCommand
               ("    select  count(*)   From    ArticlesSet, Sous_CatégoriesSet, CommandesSet, CatégoriesSet, FournisseursSet  Where    ArticlesSet.Catégories_IdCatégories = CatégoriesSet.IdCatégories  AND  CatégoriesSet.IdCatégories = 2  AND  CatégoriesSet.IdCatégories = Sous_CatégoriesSet.Catégories_IdCatégories AND  ArticlesSet.Commandes_IdCommande = CommandesSet.IdCommande AND  CommandesSet.Fournisseurs_IdFournisseurs = FournisseursSet.IdFournisseurs  AND ArticlesSet.Sous_Catégories_IdSous_Catégories=Sous_CatégoriesSet.IdSous_Catégories  ; ", cnx);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                tbxCount.Text = dr1[0].ToString();
            }
            dr1.Close();
            cnx.Close();


            // Le chargement de cbxCatégorie

            cnx.Open();
            SqlCommand cmd2 = new SqlCommand("  select distinct  Sous_CatégoriesSet.Type_Sous_Catégorie from CatégoriesSet, Sous_CatégoriesSet Where Sous_CatégoriesSet.Catégories_IdCatégories= CatégoriesSet.IdCatégories AND CatégoriesSet.IdCatégories=3;", cnx);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                comboBox1.Items.Add(dr2[0]);
            }
            dr2.Close();
            cnx.Close();

            // Le chargement de cbxRéférence

            cnx.Open();
            SqlCommand cmd3 = new SqlCommand("  select distinct  ArticlesSet.Référence  From ArticlesSet, CatégoriesSet Where ArticlesSet.Catégories_IdCatégories=CatégoriesSet.IdCatégories  And CatégoriesSet.IdCatégories= 3;", cnx);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                comboBox3.Items.Add(dr3[0]);
            }
            dr3.Close();
            cnx.Close();


            //************* Le chargement de la partie Evacuation du stock**************// 

            // le chargement de la combobox cbxId

            cnx.Open();
            SqlCommand cmd4 = new SqlCommand("  select distinct  ArticlesSet.IdArticles  From ArticlesSet, CatégoriesSet Where ArticlesSet.Catégories_IdCatégories=CatégoriesSet.IdCatégories  And CatégoriesSet.IdCatégories= 2;", cnx);
            SqlDataReader dr4 = cmd4.ExecuteReader();
            while (dr4.Read())
            {
                comboBox4.Items.Add(dr4[0]);
            }
            dr4.Close();
            cnx.Close();

            // Le chargement de cbxSortieCatégorie

            cnx.Open();
            SqlCommand cmd5 = new SqlCommand("  select distinct  Sous_CatégoriesSet.Type_Sous_Catégorie from CatégoriesSet, Sous_CatégoriesSet Where Sous_CatégoriesSet.Catégories_IdCatégories= CatégoriesSet.IdCatégories AND CatégoriesSet.IdCatégories=2;", cnx);
            SqlDataReader dr5 = cmd5.ExecuteReader();
            while (dr5.Read())
            {
                comboBox5.Items.Add(dr5[0]);
            }
            dr5.Close();
            cnx.Close();

            // le chargement de la combobox cbxSortieCouleur

            cnx.Open();
            SqlCommand cmd6 = new SqlCommand("  select distinct  ArticlesSet.Couleur  From ArticlesSet, CatégoriesSet Where ArticlesSet.Catégories_IdCatégories=CatégoriesSet.IdCatégories  And CatégoriesSet.IdCatégories= 2;", cnx);
            SqlDataReader dr6 = cmd6.ExecuteReader();
            while (dr6.Read())
            {
                comboBox6.Items.Add(dr6[0]);
            }
            dr6.Close();
            cnx.Close();



            // Le chargement de cbxSortieRéférence

            cnx.Open();
            SqlCommand cmd7 = new SqlCommand("  select distinct  ArticlesSet.Référence  From ArticlesSet, CatégoriesSet Where ArticlesSet.Catégories_IdCatégories=CatégoriesSet.IdCatégories  And CatégoriesSet.IdCatégories= 2;", cnx);
            SqlDataReader dr7 = cmd7.ExecuteReader();
            while (dr7.Read())
            {
                comboBox7.Items.Add(dr7[0]);
            }
            dr7.Close();
            cnx.Close();

        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {

            // Actualiser le textbox du count 
            cnx.Open();
            SqlCommand cmd1 = new SqlCommand
               ("   select  count(*)   From    ArticlesSet, Sous_CatégoriesSet, CommandesSet, CatégoriesSet, FournisseursSet  Where    ArticlesSet.Catégories_IdCatégories = CatégoriesSet.IdCatégories  AND  CatégoriesSet.IdCatégories = 2  AND  CatégoriesSet.IdCatégories = Sous_CatégoriesSet.Catégories_IdCatégories AND  ArticlesSet.Commandes_IdCommande = CommandesSet.IdCommande AND  CommandesSet.Fournisseurs_IdFournisseurs = FournisseursSet.IdFournisseurs  AND ArticlesSet.Sous_Catégories_IdSous_Catégories=Sous_CatégoriesSet.IdSous_Catégories; ", cnx);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                tbxCount.Text = dr1[0].ToString();
            }
            dr1.Close();
            cnx.Close();



            // Actualiser la DatagridView
            dgvMgsRuban.Rows.Clear();

            // Le chargement de la data grid view par les valeurs de la base de données
            // Ouvrir la connexion avec la db
            cnx.Open();
            SqlCommand cmd = new SqlCommand
                ("select    ArticlesSet.IdArticles , ArticlesSet.Référence,ArticlesSet.Couleur,Sous_CatégoriesSet.Type_Sous_Catégorie,CommandesSet.IdCommande,FournisseursSet.IdFournisseurs,FournisseursSet.Nom  From    ArticlesSet, Sous_CatégoriesSet, CommandesSet, CatégoriesSet, FournisseursSet  Where    ArticlesSet.Catégories_IdCatégories = CatégoriesSet.IdCatégories  AND  CatégoriesSet.IdCatégories = 2  AND  CatégoriesSet.IdCatégories = Sous_CatégoriesSet.Catégories_IdCatégories AND  ArticlesSet.Commandes_IdCommande = CommandesSet.IdCommande AND  CommandesSet.Fournisseurs_IdFournisseurs = FournisseursSet.IdFournisseurs AND ArticlesSet.Sous_Catégories_IdSous_Catégories = Sous_CatégoriesSet.IdSous_Catégories ", cnx);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dgvMgsRuban.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5], dr[6]);
            }
            dr.Close();
            cnx.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";

        }
    }
}
