using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace x_prj_biblio
{
    public partial class Books_Control : UserControl
    {
        DataTable dataTable;

        private Connexion c = LoginForm.c;
        public Books_Control()
        {
            InitializeComponent();
        }

        string getAutorName(string autorId)
        {
            c = new Connexion();            
            return c.executer_valeur(string.Format(@"SELECT [autor_name] FROM Autor WHERE [aut_id] = '{0}'", autorId));
        }

        int getZonNumber(string zonId)
        {
            c = new Connexion();
            return int.Parse(c.executer_valeur(string.Format(@"SELECT * FROM dbo.Zon WHERE  [zon_id] = '{0}'", zonId)));
        }

        private void Books_Control_Load(object sender, EventArgs e)
        {
            c = new Connexion();
                        
            tb_Search.Text = "Book title";
            tb_Search.ForeColor = Color.Gray;

            dataTable = c.showDataTable(string.Format(@"Select * FROM dbo.Book"));
            DG_book.DataSource = dataTable;

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
            addBook1.BringToFront();
            addBook1.Visible = true;
        }

        private void DG_book_Click(object sender, EventArgs e)
        {
            
        }

        private void DG_book_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            tb_Title.Text = DG_book["title",index].Value.ToString();
            tb_Writer.Text = getAutorName(DG_book["aut_id", index].Value.ToString());
            tb_DatePub.Text = DG_book["date_created", index].Value.ToString();
            tb_Zon.Text = getZonNumber(DG_book["zon_id", index].Value.ToString()).ToString();
        }
    }
}
