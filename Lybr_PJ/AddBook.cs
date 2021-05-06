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

        Connexion c ;
        Books b;

        public AddBook()
        {
            InitializeComponent();
        }

        private void AddBook_Load(object sender, EventArgs e)
        {
            c = new Connexion();
            b = new Books();

            SelectfromTable("SELECT * FROM Autor", "autor_name", cb_Writer);
            SelectfromTable("SELECT * FROM EDITOR", "EDITOR_name",cb_Publisher);
            SelectfromTable("SELECT * FROM Category", "nom",cb_cate);
            SelectfromTable("SELECT * FROM Zon", "nom",cb_zon);
                

            if (b.ID != null)
            {

                dataTable = c.showDataTable(String.Format(@"SELECT * FROM dbo.book WHERE book_id = '{0}'", b.ID));
                
                using (MemoryStream ms = new MemoryStream(c.getImage(int.Parse(dataTable.Rows[0]["image_id"].ToString()))))
                {
                    image = Image.FromStream(ms);
                    pic_book.Image = image;
                }

                tb_Title.Text = dataTable.Rows[0]["title"].ToString(); 
                tb_ISBN.Text = dataTable.Rows[0]["book_isbn"].ToString(); 
                tb_Pnum.Text = dataTable.Rows[0]["page_number"].ToString(); 
                tb_Amount.Text = dataTable.Rows[0]["quantity"].ToString(); 
                mtb_datePub.Text = DateTime.Parse(dataTable.Rows[0]["date_created"].ToString()).ToString("dd:mm:yyyy");

                cb_Writer.Text = c.executer_valeur(string.Format(@"SELECT autor_name FROM Autor WHERE [aut_id] = '{0}'",dataTable.Rows[0]["aut_id"].ToString()));
                cb_Publisher.Text = c.executer_valeur(string.Format(@"SELECT EDITOR_name FROM EDITOR WHERE [EDITOR_id] = '{0}'", dataTable.Rows[0]["id_editor"].ToString()));
                cb_cate.Text = c.executer_valeur(string.Format(@"SELECT nom FROM category WHERE [id] = '{0}'", dataTable.Rows[0]["category"].ToString()));
                cb_zon.Text = c.executer_valeur(string.Format(@"SELECT nom FROM Zon WHERE [id] = '{0}'", dataTable.Rows[0]["zon_id"].ToString()));

                But_Ok.Text = "Update";
            }
        }

        void CleanCach()
        {            
            tb_Title.Text ="";
            tb_ISBN.Text = "";
            tb_Pnum.Text = "";
            tb_Amount.Text = "";
            mtb_datePub.Text = "";

            cb_Writer.Text = "";
            cb_Publisher.Text = "";
            cb_cate.Text = "";
            cb_zon.Text = "";                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      
        }
        
        void SelectfromTable(string sqlString, string name,ComboBox cb)
        {
            dataTable = c.showDataTable(sqlString);
            cb.DataSource = dataTable;
            cb.DisplayMember = name;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void But_Ok_Click(object sender, EventArgs e)
        {
            b = new Books();
             
            b.Title = tb_Title.Text;
            b.ISBN = tb_ISBN.Text;
            b.Writer = cb_Writer.Text;
            b.Publisher = cb_Publisher.Text;
            b.Add_time = DateTime.Parse(mtb_datePub.Text);
            b.Quantity = int.Parse(tb_Amount.Text);
            b.Puge_number = int.Parse(tb_Pnum.Text);
            b.Category = cb_cate.Text;
            b.ZON = int.Parse(cb_zon.Text);
            b.Imag = imgData;

            if (b.ID != null)            
                b.Update();
            else
                b.Add();
            CleanCach();

        }

        private void B_cancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CleanCach();


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
