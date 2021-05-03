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
    public partial class Modifier_Supprimer_BORROWING : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=SQL5104.site4now.net;Initial Catalog=db_a736ef_01;User Id=db_a736ef_01_admin;Password=dbo_01_1996");
        SqlCommand cmd;
        DataTable dt = new DataTable();
        SqlDataReader dr;
        public Modifier_Supprimer_BORROWING()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd = new SqlCommand("delete Borrow where br_id = " + comboBox1.SelectedItem.ToString() + "", cnx);
            cmd.ExecuteNonQuery();
            cnx.Close();
            MessageBox.Show("Supprimer Avec Succe", "Supprimer Borrow", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Modifier_Supprimer_BORROWING_Load(object sender, EventArgs e)
        {
            cnx.Open();
            cmd = new SqlCommand("select br_id from Borrow ", cnx);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["br_id"].ToString());

            }
            dr.Close();
            cnx.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.CommandText = "select * from Borrow where br_id=" + comboBox1.Text.ToString() + "";
            cmd.Connection = cnx;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string book = dr.GetValue(1).ToString();
                string adherent = dr.GetValue(2).ToString();
                string date_emprunt = dr.GetValue(3).ToString();
                string date_return = dr.GetValue(4).ToString();
                string fresh = dr.GetValue(5).ToString();
                textBox3.Text = book;
                textBox2.Text = adherent;
                dateTimePicker1.Text = date_emprunt;
                dateTimePicker2.Text = date_return;
                textBox1.Text = fresh;

            }
            dr.Close();
            cnx.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
