using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace x_prj_biblio
{
    public partial class Dashboard : Form
    {
        Connexion c;
        DataTable dataTable;
        
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            c = new Connexion();

            lb_dateTime.Text = DateTime.Now.ToString();

            Side_panel.Height = bt_Dboard.Height;
            Side_panel.Top = bt_Dboard.Top;
            dashbord_Control1.BringToFront();
               

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_Dboard_Click(object sender, EventArgs e)
        {
            Side_panel.Height = bt_Dboard.Height;
            Side_panel.Top = bt_Dboard.Top;
            dashbord_Control1.BringToFront();

            bt_Dboard.BackColor = Color.FromArgb(230, 60, 56);
            bt_Book.BackColor = Color.Transparent;
        }

        private void bt_Book_Click(object sender, EventArgs e)
        {
            Side_panel.Height = bt_Book.Height;
            Side_panel.Top = bt_Book.Top;
            books_Control1.BringToFront();

            bt_Book.BackColor = Color.FromArgb(230, 60, 56);
            bt_Dboard.BackColor = Color.Transparent;
        }
    }
}
