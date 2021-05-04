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

        private Connexion c;

        public Books_Control()
        {
            InitializeComponent();
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
    }
}
