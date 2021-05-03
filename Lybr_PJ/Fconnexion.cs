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
    public partial class Fconnexion : Form
    {
        public static Connexion C;
        public Fconnexion()
        {
            InitializeComponent();
        }

        private void button_connecter_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection("Data Source=SQL5104.site4now.net;Initial Catalog=db_a736ef_01;User Id=db_a736ef_01_admin;Password=dbo_01_1996");
            SqlDataAdapter Da = new SqlDataAdapter("select * from Bibliothecaire where Utilisateur like '" + textBox_Login.Text + "' and MotDePass like '" + textBox_Password.Text + "'", cnx);
            DataTable Dt = new DataTable();
            Dt.Clear();
            Da.Fill(Dt);
            if (Dt.Rows.Count > 0)
            {

                if (Dt.Rows[0][7].ToString() == "admin")
                {

                    Admin admin = new Admin();
                    admin.Show();

                }

                else if (Dt.Rows[0][7].ToString() == "user")
                {

                    User user = new User();
                    user.Show();

                }
                this.Hide();
            }
            else
            {
                MessageBox.Show(" Nom d'utilisateur ou le mot de passe est incorrect !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
