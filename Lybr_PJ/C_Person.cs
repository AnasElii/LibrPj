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
    public partial class C_Person : UserControl
    {
        public C_Person()
        {
            InitializeComponent();
        }
        Connexion con = LoginForm.con;
        public void Actualiser()
        {
            con = new Connexion();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Person.GetPerson();
        }
        private void C_Person_Load(object sender, EventArgs e)
        {
            //Actualiser();
        }
    }
}
