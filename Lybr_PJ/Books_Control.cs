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
        public Books_Control()
        {
            InitializeComponent();
        }

        private void Books_Control_Load(object sender, EventArgs e)
        {
            tb_Search.Text = "Book title";
            tb_Search.ForeColor = Color.Gray;

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
