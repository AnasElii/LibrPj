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
    public partial class Books_Control : UserControl
    {
        DataTable dataTable;         
        Image image;
        int index;

        private Connexion c;
        private Books b;

        public Books_Control()
        {
            InitializeComponent();
        }

        private void Books_Control_Load(object sender, EventArgs e)
        {            
            c = new Connexion();

            tb_Search.Text = "Book title";
            tb_Search.ForeColor = Color.Gray;

            dataGridRefresh();


            tb_Title.ReadOnly = true;
            tb_Writer.ReadOnly = true;
            tb_DatePub.ReadOnly = true;
            tb_Zon.ReadOnly = true;

        }

        void dataGridRefresh()
        {
            dataTable = c.showDataTable(string.Format(@"Select * FROM dbo.Book"));
            DG_book.DataSource = dataTable;

        }

        string getAutorName(string autorId)
        {
            c = new Connexion();       
            return c.executer_valeur(string.Format(@"SELECT [autor_name] FROM Autor WHERE [aut_id] = '{0}'", autorId));
        }

        int getZonNumber(string zonId)
        {            
            c = new Connexion();
            return int.Parse(c.executer_valeur(string.Format(@"SELECT * FROM dbo.Zon WHERE  [id] = '{0}'", zonId)));
        }               

        

        private void tb_Search_Click(object sender, EventArgs e)
        {
            if(tb_Search.Text == "Book title")
            {
                tb_Search.Text = String.Empty;
            }
        }

        private void Add_Book_Click(object sender, EventArgs e)
        {

        }

        private void Add_Book_Click_1(object sender, EventArgs e)
        {
            b = new Books();
            b.ID = null;

            addBook1.BringToFront();
            addBook1.Visible = true;
            dataGridRefresh();            
        }

        private void DG_book_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            c = new Connexion();
            index = e.RowIndex;

            using (MemoryStream ms = new MemoryStream(c.getImage(int.Parse(DG_book["image_id", index].Value.ToString()))))
            {
                image = Image.FromStream(ms);
                pic_book.Image = image;
            }

            tb_Title.Text = DG_book["title", index].Value.ToString();
            tb_Writer.Text = getAutorName(DG_book["aut_id", index].Value.ToString());
            tb_DatePub.Text = DG_book["date_created", index].Value.ToString();
            tb_Writer.Text = DG_book["date_created", index].Value.ToString();
            tb_Zon.Text = getZonNumber(DG_book["zon_id", index].Value.ToString()).ToString();
        }

        
        private void Delete_Book_Click(object sender, EventArgs e)
        {            
            b = new Books();

            b.ID = DG_book["book_id", index].Value.ToString();

            b.Delete();

            dataGridRefresh();
        }

        private void DG_book_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }

        private void Edit_Book_Click(object sender, EventArgs e)
        {
            b = new Books();

            b.ID = DG_book["book_id", index].Value.ToString();

            addBook1.BringToFront();
            addBook1.Visible = true;

            dataGridRefresh();
        }
    }
}
