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
        private String nom;
        private DateTime datenes;
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

        public DateTime Datenes
        {
            get { return datenes; }
            set { datenes = value; }
        }

        public Autor()
        {
            c = new Connexion();
        }

        public Autor(string nom, DateTime datenes)
        {
            this.nom = nom;            
            this.datenes = datenes;
        }
    }
}
}
