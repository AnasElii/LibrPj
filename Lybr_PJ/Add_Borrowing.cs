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
    public partial class Add_Borrowing : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=SQL5104.site4now.net;Initial Catalog=db_a736ef_01;User Id=db_a736ef_01_admin;Password=dbo_01_1996");
        SqlCommand cmd;
        DataTable dt = new DataTable();
        SqlDataReader dr;
        public Add_Borrowing()
        {
            InitializeComponent();
        }

        private void Add_Borrowing_Load(object sender, EventArgs e)
        {
            

            get_adherent();
            get_Book();

        }
        public void get_Book()
        {

            cnx.Open();
            cmd = new SqlCommand("select book_id from Book ", cnx);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr["book_id"].ToString());

            }
            dr.Close();
            cnx.Close();

        }

        public void get_adherent()
        {

            cnx.Open();
            cmd = new SqlCommand("select per_id from Person ", cnx);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox3.Items.Add(dr["per_id"].ToString());

            }
            dr.Close();
            cnx.Close();

        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cnx.Open();
            cmd = new SqlCommand("select * from Book where book_id='" + comboBox2.Text.ToString() + "'", cnx);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr["book_id"].ToString());

            }
            dr.Close();
            cnx.Close();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            cnx.Open();
            cmd = new SqlCommand("select * from Person where per_id='" + comboBox3.Text.ToString() + "'", cnx);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox3.Items.Add(dr["per_id"].ToString());

            }
            dr.Close();
            cnx.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd = new SqlCommand("insert into Borrow(book_id,per_id,date_beg,date_end,fresh) values('" + comboBox2.SelectedItem.ToString() + "','" + comboBox3.SelectedItem.ToString() + "','" + dateTimePicker1.Value.ToString("dd-MM-yyyy") + "','" + dateTimePicker2.Value.ToString("dd-MM-yyyy") + "','" +textBox1.Text+"')", cnx);
           cmd.ExecuteNonQuery();
            cnx.Close();
            MessageBox.Show("Ajoute Avec Succe", "Ajouter Emprunt", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
