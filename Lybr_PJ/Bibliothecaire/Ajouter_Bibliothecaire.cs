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
    public partial class Ajouter_Bibliothecaire : Form
    {
        //Bibliothecaire b;
        public Ajouter_Bibliothecaire()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-7VH5RFE;Initial Catalog=Bibliotheque_DB;Integrated Security=True");
            cnx.Open();
            SqlCommand cmd = new SqlCommand("insert into Bibliothecaire(NomBibl,PrenomBibl,AdresseBibl,TelephoneBibl,Utilisateur,MotDePass,Permission) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "'," + textBox4.Text + ",'" + textBox5.Text + "','" + textBox6.Text + "','" + comboBox1.SelectedItem.ToString() + "')", cnx);
            cmd.ExecuteNonQuery();
            cnx.Close();
            MessageBox.Show("Ajoute Avec Succe", "Ajouter Bibliothecaire", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Ajouter_Bibliothecaire_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("user");
            comboBox1.Items.Add("admin");
        }
    }
}






