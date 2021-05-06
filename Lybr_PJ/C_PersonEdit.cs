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
    public partial class C_PersonEdit : UserControl
    {
        public C_PersonEdit()
        {
            InitializeComponent();
        }
        Person person;
        public void aDD()
        {
            try
            {
                person = new Person();
                person.Firstname = _TFirstName.Text;
                person.LastName = _TLastName.Text;
                person.BirthDate = _TDatebirth.Value;
                person.Phone = _TPhone.Text;
                person.Password = _Tpass.Text;
                person.Email = _TEmail.Text;
                person.Pertype = _Tpertype.Checked;
                person.Image = _TPimage.Image;

                Person.AddPersson(person);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void _TPimage_Click(object sender, EventArgs e)
        {
            //chage image
        }
    }
}
