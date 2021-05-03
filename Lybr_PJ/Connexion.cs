using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace x_prj_biblio
{
    public class Connexion
    {
        private SqlConnection con;
        private SqlCommand cmd;
        public DataTable dt;
        public SqlDataReader dr;
        public Boolean Connecter()
        {
            try
            {
                string ch = "Data Source=SQL5104.site4now.net;Initial Catalog=db_a736ef_01;User Id=db_a736ef_01_admin;Password=dbo_01_1996";
                con = new SqlConnection(ch);
                con.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void Deconnecter()
        {
            con.Close();
        }
        public int executer(String chaine_sql)
        {
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = chaine_sql;
            return cmd.ExecuteNonQuery();
        }
        public void executer_liste_connecté(String chaine_sql)
        {
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = chaine_sql;
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
        }
        public String executer_valeur(String chaine_sql)
        {
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = chaine_sql;
            return cmd.ExecuteScalar().ToString();
        }

    }
}
