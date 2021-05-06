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
    public partial class Dashboard : Form
    {        
        private static DataTable _dataTable;
        private SqlCommand cmd;
        private SqlDataReader reader;
        private Image profImage;

        Connexion c ;
        private Person p;

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            
            lb_dateTime.Text = DateTime.Now.ToString();

            Side_btn_col.Height = bt_Dboard.Height;
            Side_btn_col.Top = bt_Dboard.Top;
            dashbord_Control1.BringToFront();

            userInfo();

        }
        
        //-----Profile Info Change

        private void userInfo()
        {            
            p = new Person();
            c = new Connexion();

            _dataTable = c.showDataTable(string.Format(@"SELECT * FROM dbo.Person  WHERE per_id = {0}", p.ID));

            lb_Uname.Text = _dataTable.Rows[0]["first_name"]+ " " + _dataTable.Rows[0]["last_name"];

            pic_user.Image = getImage();
        }

        private Image getImage()
        {
            p = new Person();
            c.Con.Open();
            

            string selectQuery = string.Format(@"SELECT image FROM dbo.Images WHERE id = '{0}'", _dataTable.Rows[0]["image_id"]);

            //Select Image

            cmd = new SqlCommand(selectQuery, c.Con);
            reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                byte[] imgData = (byte[])reader[0];
                using (MemoryStream ms = new MemoryStream(imgData))
                {
                    profImage = Image.FromStream(ms);
                    //image.Save(@"C:\YupitWork.jpg");
                }
            }
                        
            return profImage;
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
            Side_btn_col.Height = bt_Dboard.Height;
            Side_btn_col.Top = bt_Dboard.Top;
            dashbord_Control1.BringToFront();

            bt_Dboard.BackColor = Color.FromArgb(230, 60, 56);
            bt_Book.BackColor = Color.Transparent;
        }

        private void bt_Book_Click(object sender, EventArgs e)
        {
            Side_btn_col.Height = bt_Book.Height;
            Side_btn_col.Top = bt_Book.Top;
            books_Control1.BringToFront();

            bt_Book.BackColor = Color.FromArgb(230, 60, 56);
            bt_Dboard.BackColor = Color.Transparent;
        }

<<<<<<< Updated upstream
=======
        private void tb_Person_Click(object sender, EventArgs e)
        {
            Side_btn_col.Height = tb_Person.Height;
            Side_btn_col.Top = tb_Person.Top;
            c_PersonSwitch1.BringToFront();


>>>>>>> Stashed changes
        private void bt_Writer_Click(object sender, EventArgs e)
        {
            Side_btn_col.Height = bt_Writer.Height;
            Side_btn_col.Top = bt_Writer.Top;
            alL_Control1.BringToFront();

            Side_btn_col.BackColor = Color.FromArgb(230, 60, 56);
            Side_btn_col.BackColor = Color.Transparent;
        }
    }
}
