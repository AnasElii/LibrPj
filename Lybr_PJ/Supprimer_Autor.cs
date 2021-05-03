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
    public partial class Supprimer_Autor : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=SQL5104.site4now.net;Initial Catalog=db_a736ef_01;User Id=db_a736ef_01_admin;Password=dbo_01_1996");
        SqlCommand cmd;
        DataTable dt = new DataTable();
        SqlDataReader dr;
        public Supprimer_Autor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd = new SqlCommand("delete Autor where aut_id = " + comboBox1.SelectedItem.ToString() + "", cnx);
            cmd.ExecuteNonQuery();
            cnx.Close();
            MessageBox.Show("Supprimer Avec Succe", "Supprimer Emprunt", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Supprimer_Autor_Load(object sender, EventArgs e)
        {
            cnx.Open();
            cmd = new SqlCommand("select aut_id from Autor ", cnx);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["aut_id"].ToString());

            }
            dr.Close();
            cnx.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.CommandText = "select * from Autor where aut_id=" + comboBox1.Text.ToString() + "";
            cmd.Connection = cnx;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string autor_name = dr.GetValue(1).ToString();
                string birth_date = dr.GetValue(2).ToString();
                Tauto_name.Text = autor_name;
                dateTimePicker1.Text = birth_date;

            }
            dr.Close();
            cnx.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd = new SqlCommand("update Autor set autor_name ='" + Tauto_name.Text + "' , birth_date= '" + dateTimePicker1.Value.ToString("dd-MM-yyyy") + "' where aut_id='" + comboBox1.Text.ToString() + "'", cnx);
            cmd.ExecuteNonQuery();
            cnx.Close();
            MessageBox.Show("Modifier Avec Succe", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
