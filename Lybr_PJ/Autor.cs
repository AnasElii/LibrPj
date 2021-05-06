using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace x_prj_biblio
{
    class Autor
    {
        private static string id;
        private string nom;
        private DateTime birth_date;

        Connexion c;

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public DateTime Birth_Date
        {
            get { return birth_date; }
            set { birth_date = value; }
        }

        public Autor()
        {
            c = new Connexion();
        }

        public Autor(String nom, DateTime birth_date)
        {
            this.nom = nom;
            this.birth_date = birth_date;
        }

        public void ajout() //ajout
        {

        }

        public void lister() //lister
        {

        }
    }
}

