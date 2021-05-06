using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace x_prj_biblio
{
    class Borrow
    {
        private static string _id;
        private DateTime datebeg;
        private DateTime dateend;
        private float fresh;

        private SqlCommand cmd;

        Connexion c = LoginForm.c;
        private Person p;
        private Books b;

        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public DateTime DateBeg
        {
            get { return datebeg; }
            set { datebeg = value; }
        }

        public DateTime DateEnd
        {
            get { return dateend; }
            set { dateend = value; }
        }

        public float Fresh
        {
            get { return fresh; }
            set { fresh = value; }
        }

        public Borrow()
        {
            p = new Person();
            b = new Books();
        }

        public Borrow(String id, DateTime datebeg, DateTime dateend, float fresh)
        {            
            this.datebeg = datebeg;
            this.dateend = dateend;
            this.fresh = fresh;
        }
    }
}
