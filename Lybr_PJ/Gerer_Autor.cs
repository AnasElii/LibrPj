using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace x_prj_biblio
{
    public partial class Gerer_Autor : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=SQL5104.site4now.net;Initial Catalog=db_a736ef_01;User Id=db_a736ef_01_admin;Password=dbo_01_1996");
        SqlCommand cmd;
        DataTable dt = new DataTable();
        SqlDataReader dr;
        public Gerer_Autor()
        {
            InitializeComponent();
        }

        private void Gerer_Autor_Load(object sender, EventArgs e)
        {
            cnx.Close();
            cnx.Open();
            cmd = new SqlCommand("select * from Autor", cnx);
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView_Autor.DataSource = dt;
            cnx.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ajouter_Autor Ajouter_Autor = new Ajouter_Autor();
            Ajouter_Autor.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cnx.Close();
            cnx.Open();
            cmd = new SqlCommand("select * from Autor", cnx);
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView_Autor.DataSource = dt;
            cnx.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Supprimer_Autor supprimer_Autor = new Supprimer_Autor();
            supprimer_Autor.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Supprimer_Autor supprimer_Autor = new Supprimer_Autor();
            supprimer_Autor.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}
