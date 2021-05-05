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
using System.IO;

namespace x_prj_biblio
{
    public partial class LoginForm : Form
    {
        StreamWriter streamWriter;
        StreamReader streamReader;
        private List<string> infList;
        DataTable dataTable;

        public static Connexion c;
        private Login l;
        private Person p;
        private Dashboard d;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            bt_Shide.TabStop = false;
            bt_Shide.FlatStyle = FlatStyle.Flat;
            bt_Shide.FlatAppearance.BorderSize = 0;

            if (File.Exists("info"))
            {
                getInfo();
                cb_Rme.Checked = true;
                bt_Login.Select();
            }
        }

        private void saveInfo()
        {
            streamWriter = new StreamWriter("info");
            infList = new List<string>();
            infList.Add(tb_Uname.Text);
            infList.Add(tb_Pword.Text);
            foreach(string inf in infList)
            {
                streamWriter.WriteLine(inf);
            }
            streamWriter.Flush();
        }

        private void getInfo()
        {            
            streamReader = new StreamReader("info");
            infList = new List<string>();

            do
            {
                infList.Add(streamReader.ReadLine());
            } while (infList[infList.Count - 1] != null);

            streamReader.Close();

            tb_Uname.Text= infList[0];
            tb_Pword.Text = infList[1];
        }

        private void button_quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void button_quitter_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void bt_Login_Click(object sender, EventArgs e)
        {
            p = new Person();
            l = new Login();
            c = new Connexion();

            l.Email = tb_Uname.Text;
            l.PassWord = tb_Pword.Text;

            string messag = l.CheckLogin().Trim();
            Console.WriteLine(messag);

            if (messag.Equals("50500##Connected"))
            {
                this.Hide();

                dataTable = c.showDataTable(string.Format(@"SELECT [per_id],[image_id] FROM dbo.Person  WHERE email = '{0}'", tb_Uname.Text));
                p.ID = dataTable.Rows[0]["per_id"].ToString();
                p.Image_Id = dataTable.Rows[0]["image_id"].ToString();                

                if (cb_Rme.Checked)
                {
                    saveInfo();                    
                }
                d = new Dashboard();
                d.Show();
                
            }
            else if(messag.Equals("50404##user undifounded"))
            {
                tb_Uname.BackColor = Color.FromArgb(255, 173, 173);
                
            }
            else
            {
                tb_Pword.BackColor = Color.FromArgb(255, 173, 173);
            }
        }

        private void tb_Uname_Click(object sender, EventArgs e)
        {
            if(tb_Uname.BackColor == Color.FromArgb(255, 173, 173))
            {
                tb_Uname.BackColor = Color.White;
                tb_Uname.SelectAll();
            }
        }

        private void tb_Pword_Click(object sender, EventArgs e)
        {
            if (tb_Pword.BackColor == Color.FromArgb(255, 173, 173))
            {
                tb_Pword.BackColor = Color.White;
                tb_Pword.SelectAll();

            }
        }

        private void tb_Pword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                bt_Login_Click(sender, e);
            }
        }

        private void tb_Uname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                tb_Pword.Select();
            }
        }
    }
}
