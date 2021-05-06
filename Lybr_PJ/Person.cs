using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace x_prj_biblio
{
    class Person
    {
        private static string _id;
        private static string _email;
        private string password;
        private string firstname;
        private string lastname;
        private DateTime birthdate;
        private DateTime dateins;
        private string phone;
        private static string _image_id;

        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }

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

        public string Nom
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

        public String Image_Id
        {
            get { return _image_id; }
            set { _image_id = value; }
        }

        public Person()
        {
            
        }

        public Person(string email, string pswrd, string firstname, string lastname, DateTime birthdate, string phone):this()
        {
            this.password = pswrd;
            this.firstname = firstname;
            this.lastname = lastname;
            this.birthdate = birthdate;
            this.phone = phone;
        }

        public static DataTable GetPerson()
        {
            return LoginForm.con.showDataTable("select * from [dbo].[_getPerson]");
        }


    }
}
