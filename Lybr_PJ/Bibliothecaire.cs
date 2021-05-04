using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace x_prj_biblio
{
    public class Bibliothecaire
    {
        private String CodeBibl;
        private String NomBibl;
        private String PrenomBibl;
        private String AdresseBibl;
        private int TelephoneBibl;
        private String Utilisateur;
        private String MotDePass;
        private String Permission;
        private Connexion con;
        public Bibliothecaire(Connexion con)
        {
            this.con = con;
        }
        public Bibliothecaire(String CodeBibl, String NomBibl, String PrenomBibl, String AdresseBibl, int TelephoneBibl, String Utilisateur, String MotDePass,String Permission, Connexion con)
        {
            this.CodeBibl = CodeBibl;
            this.NomBibl = NomBibl;
            this.PrenomBibl = PrenomBibl;
            this.AdresseBibl = AdresseBibl;
            this.TelephoneBibl = TelephoneBibl;
            this.Utilisateur = Utilisateur;
            this.MotDePass = MotDePass;
            this.Permission = Permission;
            this.con = con;
        }
        public Bibliothecaire(String CodeBibl, String NomBibl, Connexion con)
        {
            this.CodeBibl = CodeBibl;
            this.NomBibl = NomBibl;
            this.con = con;
        }
        public Bibliothecaire( String CodeBibl, Connexion con)
        {
            this.CodeBibl = CodeBibl;
            this.con = con;
        }
        public Connexion Getconnexion()
        {
            return con;
        }
        public String GetCodebibl()
        {
            return CodeBibl;
        }
        public Boolean existence_Codebibl() //existence de la clé primaire si le count renvoie 0 alors le code n’existe pas
        {
            if (con.executer_valeur("select count(*) from Bibliothecaire where CodeBibl='" + CodeBibl + "'") == "0")
                return false;
            else
                return true;
        }
        public int ajout() //ajout
        {
            return con.Add_Value("insert into Bibliothecaire values('" + CodeBibl + "','" + NomBibl + "','" + PrenomBibl + "','" + AdresseBibl + "','" + TelephoneBibl + "','" + Utilisateur + "','" + MotDePass + "','" + Permission + "')");
        }
    }
}