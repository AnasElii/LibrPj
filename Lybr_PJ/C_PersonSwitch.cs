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
    public partial class C_PersonSwitch : UserControl
    {
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

        private void pic_edit_Click(object sender, EventArgs e)
        {
            if (pic_add.Visible == false)
            {
                //Method Edit
                Console.WriteLine("Edit");
                c_Person1.Actualiser();
                
            }
            pic_add.Visible = false;
            c_PersonEdit1.BringToFront();
            pic_back.BringToFront();
            Hide_pic();
        }

        private void pic_add_Click(object sender, EventArgs e)
        {
            if (pic_edit.Visible == false)
            {
                //Method Add
                Console.WriteLine("Add");
                c_PersonEdit1.aDD();
                c_Person1.Actualiser();
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

        private void C_PersonSwitch_Load(object sender, EventArgs e)
        {

        }
    }
}
