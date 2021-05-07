using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        public int aDD()
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
                using(MemoryStream stream = new MemoryStream())
                {
                    _TPimage.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                    person.Image = stream.ToArray();
                }
                return Person.AddPersson(person);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        public int Edit()
        {
            try
            {
                person = new Person();
                person.ID = Convert.ToInt32(_TID.Text);
                person.Firstname = _TFirstName.Text;
                person.LastName = _TLastName.Text;
                person.BirthDate = _TDatebirth.Value;
                person.Phone = _TPhone.Text;
                person.Password = _Tpass.Text;
                person.Email = _TEmail.Text;
                person.Pertype = _Tpertype.Checked;
                using (MemoryStream stream = new MemoryStream())
                {
                    _TPimage.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                    person.Image = stream.ToArray();
                }
                return Person.EditPersson(person);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        private void _TPimage_Click(object sender, EventArgs e)
        {
            //chage image
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";
            dialog.Title = "Select Photos";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _TPimage.Image =  new Bitmap(dialog.FileName);
            }
        }

        private void _Tpertype_CheckedChanged(object sender, EventArgs e)
        {
            if (_Tpertype.Checked)
            {
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                _TEmail.Visible = true;
                _Tpass.Visible = true;
            }
            else
            {
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                _TEmail.Visible = false;
                _Tpass.Visible = false;
            }
        }

        private void C_PersonEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
