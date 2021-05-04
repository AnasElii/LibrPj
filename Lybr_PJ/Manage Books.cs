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
    public partial class Manage_Books : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=SQL5104.site4now.net;Initial Catalog=db_a736ef_01;User Id=db_a736ef_01_admin;Password=dbo_01_1996");
        SqlCommand cmd;
        DataTable dt = new DataTable();
        SqlDataReader dr;
        public Manage_Books()
        {
            InitializeComponent();
        }

        private void Delete_Book_Click(object sender, EventArgs e)
        {
            
        }

        private void Edit_Book_Click(object sender, EventArgs e)
        {
            
        }

        private void Add_Book_Click(object sender, EventArgs e)
        {
            Add_Book add_book = new Add_Book();
            add_book.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            cnx.Close();
            cnx.Open();
            cmd.CommandText = "select * from Book where titel like '" + textBox1.Text + "' ";
            cmd.Connection = cnx;
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            dataGridView_Livre.DataSource = dt;
            dr.Close();
        }

        private void Manage_Books_Load(object sender, EventArgs e)
        {
            cnx.Close();
            cnx.Open();
            cmd = new SqlCommand("select * from Book", cnx);
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView_Livre.DataSource = dt;
            cnx.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cnx.Close();
            cnx.Open();
            cmd.CommandText = "select * from Book where Categorie like '" + textBox2.Text + "' ";
            cmd.Connection = cnx;
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            dataGridView_Livre.DataSource = dt;
            dr.Close();
        }
    }
}
