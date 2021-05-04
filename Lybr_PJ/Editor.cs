using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace x_prj_biblio
{
    class Editor
    {
        private static string id;
        private String nom;
        private DateTime datecred;
        private SqlCommand cmd;

        private Connexion c;

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

        public DateTime DateCre
        {
            get { return datecred; }
            set { datecred = value; }
        }

        public Editor()
        {
            c = new Connexion();
        }

        public Editor(string nom, DateTime datecred)
        {
            this.nom = nom;            
            this.datecred = datecred;
        }
    }
}
