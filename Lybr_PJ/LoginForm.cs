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
    public partial class LoginForm : Form
    {

        public Connexion c;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button_connecter_Click(object sender, EventArgs e)
        {
            bt_Shide.TabStop = false;
            bt_Shide.FlatStyle = FlatStyle.Flat;
            bt_Shide.FlatAppearance.BorderSize = 0; 

            c = new Connexion();
            c.Con.Open();
            SqlDataAdapter Da = new SqlDataAdapter("select * from Bibliothecaire where Utilisateur like '" + tb_Uname.Text + "' and MotDePass like '" + tb_Pword.Text + "'", c.Con);
            DataTable Dt = new DataTable();
            Dt.Clear();
            Da.Fill(Dt);
            if (Dt.Rows.Count > 0)
            {

                if (Dt.Rows[0][7].ToString() == "admin")
                {

                    
                   

                }

                else if (Dt.Rows[0][7].ToString() == "user")
                {

                   

                }
                this.Hide();
            }
            else
            {
                MessageBox.Show(" Nom d'utilisateur ou le mot de passe est incorrect !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

            }
            c.Con.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button_quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        

        private void button_quitter_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_connecter_Click_1(object sender, EventArgs e)
        {

        }

        private void bt_Shide_Click_1(object sender, EventArgs e)
        {
            if (tb_Pword.UseSystemPasswordChar)
            {
                tb_Pword.UseSystemPasswordChar = false;

            }
            else
                tb_Pword.UseSystemPasswordChar = true;
        }
    }
}
