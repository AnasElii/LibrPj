using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace x_prj_biblio
{
    public partial class C_PersonSwitch : UserControl
    {
        Person person;
        Connexion con = LoginForm.con;
        public C_PersonSwitch()
        {
            InitializeComponent();
        }
        public void Hide_pic()
        {
            pic_print.Visible = false;
            pic_delete.Visible = false;
        }
        public void ElseHide_pic()
        {
            pic_print.Visible = true;
            pic_edit.Visible = true;
            pic_delete.Visible = true;
            pic_add.Visible = true;
        }
        private void pic_back_Click(object sender, EventArgs e)
        {
            c_Person1.BringToFront();
            ElseHide_pic();
        }
        private void C_PersonSwitch_Load(object sender, EventArgs e)
        {
            c_Person1.dataGridView1.CellClick += DataGridView1_CellClick;
            c_Person1.Actualiser();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
            person = Person.GetPersonById((int)c_Person1.dataGridView1[0, e.RowIndex].Value);
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

        private void pic_edit_Click(object sender, EventArgs e)
        {

            if (pic_add.Visible != false) {
                if (c_Person1.dataGridView1.SelectedRows.Count>0)
                {
                    person = new Person();
                    person = person.ReadFileXML();
                    c_PersonEdit1._TID.Text = person.ID.ToString();
                    c_PersonEdit1._TFirstName.Text = person.Firstname;
                    c_PersonEdit1._TLastName.Text = person.LastName;
                    c_PersonEdit1._TPhone.Text = person.Phone;
                    c_PersonEdit1._Tpertype.Checked = person.Pertype;
                    c_PersonEdit1._Tpass.Text = person.Password;
                    c_PersonEdit1._TEmail.Text = person.Email;
                    using (MemoryStream ms = new MemoryStream(person.Image))
                    {
                        c_PersonEdit1._TPimage.Image = Image.FromStream(ms);
                    }
                    pic_add.Visible = false;
                    c_PersonEdit1.BringToFront();
                    pic_back.BringToFront();
                    Hide_pic();
                }
                else
                {
                    MessageBox.Show("select person");
                }
            }
            else
            {
                ///persson edit
                if (c_PersonEdit1.Edit()>0)
                {
                    MessageBox.Show("Effected");
                    c_Person1.Actualiser();
                }
                else
                {
                    MessageBox.Show("Faild");
                }
            }
        }

        private void pic_add_Click(object sender, EventArgs e)
        {
            if (pic_edit.Visible == false)
            {
                //Method Add
                Console.WriteLine("Add");
                if (c_PersonEdit1.aDD() > 0)
                {
                    c_Person1.Actualiser();
                    MessageBox.Show("Effected");
                }
                else
                {
                    MessageBox.Show("Faild");
                }
            }
            pic_edit.Visible = false;
            c_PersonEdit1.BringToFront();
            pic_back.BringToFront();
            Hide_pic();

        }

        private void pic_delete_Click(object sender, EventArgs e)
        {
            ///delete
            c_Person1.dELETE();
        }

        private void pic_print_Click(object sender, EventArgs e)
        {
            //print
        }

        private void c_Person1_Load(object sender, EventArgs e)
        {
            
        }

        
    }
}
