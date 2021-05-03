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
    public partial class Edit_Delete_Book : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=SQL5104.site4now.net;Initial Catalog=db_a736ef_01;User Id=db_a736ef_01_admin;Password=dbo_01_1996");
        SqlCommand cmd;
        DataTable dt = new DataTable();
        //SqlDataReader dr;
        public Edit_Delete_Book()
        {
            InitializeComponent();
        }

        private void B_edit_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd = new SqlCommand("update Book set book_editor ='" + "' where book_id='" + C_B_Code.Text.ToString() + T_B_editour.Text + "' , title= '" + B_title.Text+ "' , puge_number= '" +T_B_Number_page.Text+ "' , book_quan= '" + T_B_Quantity.Text+ "' , category= '" +T_B_Category.Text+ "' where aut_id='" + comboBox1.Text.ToString() + "'add_time'" + dateTimePicker1.Value.ToString("dd-MM-yyyy") + "'", cnx);
            cmd.ExecuteNonQuery();
            cnx.Close();
            MessageBox.Show("Modifier Avec Succe", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void B_remove_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd = new SqlCommand("delete Book where book_id = " + C_B_Code.SelectedItem.ToString() + "", cnx);
            cmd.ExecuteNonQuery();
            cnx.Close();
            MessageBox.Show("Supprimer Avec Succe", "Supprimer Emprunt", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}