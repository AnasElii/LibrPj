using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace x_prj_biblio
{
    class Zon
    {
        private static string _id;
        private string nom;       
        private SqlCommand cmd;

        private Connexion con;

        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        
        public Zon()
        {
            con = new Connexion();
        }

        public Zon(string nom)
        {            
            this.nom = nom;
        }
    }
}
