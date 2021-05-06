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
    public partial class Writer_Control : UserControl
    {
        DataTable dataTable;
        Image image;
        int index;

        private Connexion c;
        private Books b;

        public Writer_Control()
        {
            InitializeComponent();
        }

        private void Gerer_Autor_Control_Load(object sender, EventArgs e)
        {
            dataGridRefresh();
        }

        void dataGridRefresh()
        {
            dataTable = c.showDataTable(string.Format(@"SELECT * FROM dbo.Autor"));
            DG_writer.DataSource = dataTable;

        }

        private void DG_writer_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            index = e.RowIndex;

            tb_writer.Text = DG_writer["autor_name", index].Value.ToString();
            mtb_Bdate.Text = DateTime.Parse(DG_writer["birth_date", index].Value.ToString()).ToString();

        }

        private void Add_Book_Click(object sender, EventArgs e)
        {

        }
    }
}
