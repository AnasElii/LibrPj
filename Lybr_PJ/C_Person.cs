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
        Person person;
        
        public void Actualiser()
        {
            con = new Connexion();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Person.GetPerson();

        }

        public void dELETE()
        {
            Person.DeletePersson((int)dataGridView1[0,dataGridView1.SelectedRows[0].Index].Value);
            Actualiser();
        }

        private void C_Person_Load(object sender, EventArgs e)
        {
            Actualiser();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            person = Person.GetPersonById((int)dataGridView1[0, e.RowIndex].Value);
            DataTable data = new DataTable("personXML");
            data.Columns.Add("per_id");
            data.Columns.Add("first_name");
            data.Columns.Add("last_name");
            data.Columns.Add("date_ins");
            data.Columns.Add("birth_date");
            data.Columns.Add("phone");
            data.Columns.Add("per_password");
            data.Columns.Add("email");
            data.Columns.Add("per_type");
            DataRow row = data.NewRow();

            row[0] = person.ID;
            row[1] = person.Firstname;
            row[2] = person.LastName;
            row[3] = person.Dateins;
            row[4] = person.BirthDate;
            row[5] = person.Phone;
            row[6] = person.Password;
            row[7] = person.Email;
            row[8] = person.Pertype;
            data.Rows.Add(row);
            data.WriteXml("persson.xml");
        }
    }
}
