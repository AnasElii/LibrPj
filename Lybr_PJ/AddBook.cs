using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace x_prj_biblio
{
    public partial class AddBook : UserControl
    {
        Image image;
        DataTable dataTable;
        SqlDataAdapter dataAdapter;
        byte[] imgData;

        Connexion c;

        public AddBook()
        {
            InitializeComponent();
        }

        private void AddBook_Load(object sender, EventArgs e)
        {
            c = new Connexion();
                        
            dataTable = c.showDataTable("SELECT * FROM Autor");            
            cb_Writer.DataSource = dataTable;
            cb_Writer.DisplayMember = "autor_name";
            
            dataTable = c.showDataTable("SELECT * FROM EDITOR");            
            cb_Publisher.DataSource = dataTable;
            cb_Publisher.DisplayMember = "EDITOR_name";

        }
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void But_Ok_Click(object sender, EventArgs e)
        {
            Books book = new Books();
            book.Title = tb_Title.Text;
            book.ISBN = tb_ISBN.Text;
            book.Writer = cb_Writer.Text;
            book.Publisher = cb_Publisher.Text;
            book.Add_time = DateTime.Parse(dtime_pulish.Text);
            book.Quantity = int.Parse(tb_Amount.Text);
            book.Puge_number = int.Parse(tb_Pnum.Text);
            book.Category = cb_cate.Text;
            book.ZON = int.Parse(tb_Zon.Text);
            book.Imag = imgData;

            book.Ajout();
        }

        private void B_cancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";
            dialog.InitialDirectory = @"C:\Users\Aninoss\Pictures";
            dialog.Title = "Select Photos";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    imgData = File.ReadAllBytes(dialog.FileName);
                    Image.GetThumbnailImageAbort myCallback = new Image.GetThumbnailImageAbort(ThumbnailCallback);
                    Bitmap myBitmap = new Bitmap(dialog.FileName);
                    image = myBitmap.GetThumbnailImage(300, 300, myCallback, IntPtr.Zero);
                    pic_book.Image = image;
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        public bool ThumbnailCallback()
        {
            return false;
        }
        
    }
}
