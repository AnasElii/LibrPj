using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace x_prj_biblio
{
    class Person
    {
        private int _id;
        private string _email;
        private string password;
        private string firstname;
        private string lastname;
        private DateTime birthdate;
        private DateTime dateins;
        private string phone;
        private bool pertype;
        private Image image;

        public int ID
        private SqlCommand cmd;

        Connexion c ;


        private SqlCommand cmd;

        Connexion c ;


        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public bool Pertype { get { return pertype; } set { pertype = value; } }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }

        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public DateTime BirthDate
        {
            get { return birthdate; }
            set { birthdate = value; }
        }

        public DateTime Dateins
        {
            get { return dateins; }
            set { dateins = DateTime.Today; }
        }

        public String Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public Image Image
        {
            get { return image; }
            set { image = value; }
        }
        public Person()
        {
            c = new Connexion();
        }

        public Person(int id,string email, string pswrd, string firstname, string lastname, DateTime dateins, DateTime birthdate, string phone,bool pertype,Image image):this()
        {
            this._id = id;
            this._email = email;
            this.password = pswrd;
            this.firstname = firstname;
            this.lastname = lastname;
            this.birthdate = birthdate;
            this.dateins = dateins;
            this.phone = phone;
            this.image = image;
        }

        public static DataTable GetPerson()
        {
            return LoginForm.con.showDataTable("select * from [dbo].[_getPerson]");
        }

        public static int AddPersson(Person person)
        {
            return LoginForm.con.Add_Value("EXECUTE I_PERSSON '"+person.firstname+"','"+person.lastname+"','"+person.birthdate+"','"+person.phone+"','"+person.password+"','"+person._email+"',"+person.pertype+","+person.image);
            
            /*
            cmd = new SqlCommand("dbo.I_Persson", c.Con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@id_editor", SqlDbType.Int);
            cmd.Parameters.Add("@aut_id", SqlDbType.Int);
            cmd.Parameters.Add("@zon_id", SqlDbType.Int);
            cmd.Parameters.Add("@book_isbn", SqlDbType.VarChar, 50);
            cmd.Parameters.Add("@title", SqlDbType.VarChar, 50);
            cmd.Parameters.Add("@page_number", SqlDbType.Int);
            cmd.Parameters.Add("@date_added", SqlDbType.Date);
            cmd.Parameters.Add("@date_created", SqlDbType.Date);
            cmd.Parameters.Add("@quantity", SqlDbType.Int);
            cmd.Parameters.Add("@category", SqlDbType.VarChar, 20);
            cmd.Parameters.Add("@image", SqlDbType.VarBinary);

            cmd.Parameters["@aut_id"].Value = a_ID;
            cmd.Parameters["@id_editor"].Value = p_ID;
            cmd.Parameters["@zon_id"].Value = zon;
            cmd.Parameters["@book_isbn"].Value = isbn;
            cmd.Parameters["@title"].Value = title;
            cmd.Parameters["@page_number"].Value = page_number;
            cmd.Parameters["@date_created"].Value = date_created;
            cmd.Parameters["@date_added"].Value = DateTime.Now;
            cmd.Parameters["@quantity"].Value = quantity;
            cmd.Parameters["@category"].Value = category;
            cmd.Parameters["@image"].Value = imgData;

            cmd.ExecuteNonQuery();

            */


        }

    }
}
