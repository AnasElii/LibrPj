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
            //Actualiser();
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
            data.Columns.Add("image");
            data.Rows.Add();
            data.Rows[0].ItemArray[0] = person.ID;
            data.Rows[0].ItemArray[1] = person.Firstname;
            data.Rows[0].ItemArray[2] = person.LastName;
            data.Rows[0].ItemArray[3] = person.Dateins;
            data.Rows[0].ItemArray[4] = person.BirthDate;
            data.Rows[0].ItemArray[5] = person.Phone;
            data.Rows[0].ItemArray[6] = person.Password;
            data.Rows[0].ItemArray[7] = person.Email;
            data.Rows[0].ItemArray[8] = person.Pertype;
            data.Rows[0].ItemArray[9] = person.Image;
            data.WriteXmlSchema("persson.xml");
            data.WriteXml("persson1.xml");
        }
    }
}
