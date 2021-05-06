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
        private byte[] image;

        
        private SqlCommand cmd;

        Connexion c ;



        public int ID
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

        public Byte[] Image
        {
            get { return image; }
            set { image = value; }
        }
        public Person()
        {
            c = new Connexion();
        }
        public Person(int id,string email, string pswrd, string firstname, string lastname, DateTime dateins, DateTime birthdate, string phone,bool pertype,byte[] image):this()
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
            return LoginForm.con.Add_Value("EXECUTE I_PERSSON '"+person.firstname+"','"+person.lastname+"','"+person.birthdate+"','"+person.phone+"','"+person.password+"','"+person._email+"',"+person.pertype+",0x"+ String.Join<byte>("", person.image));
        }
        public static int DeletePersson(int per_id)
        {
            return LoginForm.con.Add_Value("EXECUTE D_PERSSON "+per_id);
        }
        public static Person GetPersonById(int perID)
        {
            DataTable data = LoginForm.con.showDataTable("exec GetPersonByID "+perID);
            Person person = new Person();
            person.ID = (int)data.Rows[0].ItemArray[0];
            person.Firstname = data.Rows[0].ItemArray[1].ToString();
            person.LastName = data.Rows[0].ItemArray[2].ToString();
            person.Dateins = Convert.ToDateTime(data.Rows[0].ItemArray[3]);
            person.BirthDate = Convert.ToDateTime(data.Rows[0].ItemArray[4]);
            person.Phone = data.Rows[0].ItemArray[5].ToString();
            person.Password = data.Rows[0].ItemArray[6].ToString();
            person.Email = data.Rows[0].ItemArray[7].ToString();
            person.Pertype = Convert.ToBoolean(data.Rows[0].ItemArray[8]);
            //person.image = data.Rows[0].ItemArray[9];
            var age = data.Rows[0].ItemArray[9];



            return person;
        }

    }
}
