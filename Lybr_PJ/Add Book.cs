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
    public partial class Add_Book : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=SQL5104.site4now.net;Initial Catalog=db_a736ef_01;User Id=db_a736ef_01_admin;Password=dbo_01_1996");
        SqlCommand cmd;
        DataTable dt = new DataTable();
        SqlDataReader dr;
        public Add_Book()
        {
            InitializeComponent();
        }

        private void But_Ok_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd = new SqlCommand("insert into Book(book_id,aut_id,book_editor,title,puge_number,book_quan,add_time,category) values('" + T1.Text + "','" + comboBox1.SelectedItem.ToString() + "','" + T3.Text + "','" + T4.Text + "','" + T5.Text + "','" + T6.Text + "','" + T7.Text +"','" + dateTimePicker1.Value.ToString("dd-MM-yyyy") + "')", cnx);
            cmd.ExecuteNonQuery();
            cnx.Close();
            MessageBox.Show("Ajoute Avec Succe", "Ajouter Emprunt", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void B_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void T_B_Number_page_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Book_Load(object sender, EventArgs e)
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
    }
}
