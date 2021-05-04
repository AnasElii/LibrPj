using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace x_prj_biblio
{
    public class Auto
    {
        private String autor_name;
        private String birth_date;
        private Connexion con;

        public Auto(Connexion con)
        {
            this.con = con;
        }
        public Auto(String autor_name, String birth_date, Connexion con)
        {
            this.autor_name = autor_name;
            this.birth_date = birth_date;
            this.con = con;
        }
        public Connexion Getconnexion()
        {
            return con;
        }
        public int ajout() //ajout
        {
            return con.Add_Value("insert into Autor (autor_name,birth_date) values('" + autor_name + "','" + birth_date + "')");
        }

        public void lister() //lister
        {
            con.showDataTable("select * from Autor");
        }
    }
}
