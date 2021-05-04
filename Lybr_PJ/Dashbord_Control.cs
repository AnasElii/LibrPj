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
    public partial class Dashbord_Control : UserControl
    {
        Connexion c;
        DataTable dataTable;

        public Dashbord_Control()
        {
            InitializeComponent();
        }

        private void Dashbord_Control_Load(object sender, EventArgs e)
        {
            c = new Connexion();

            //Fill Late table
            dataTable = c.showDataTable("SELECT TOP 5 * FROM dbo.Borrow ORDER BY date_beg DESC");
            DG_Late.DataSource = dataTable;

            //Fill Book table
            dataTable.Clear();
            dataTable = c.showDataTable("SELECT TOP 5 * FROM dbo.Book ORDER BY date_added DESC");
            DG_Book.DataSource = dataTable;

            //Fill Autor table
            dataTable.Clear();
            dataTable = c.showDataTable("SELECT TOP 5 * FROM dbo.Autor");
            DG_Autor.DataSource = dataTable;
        }
    }
}
