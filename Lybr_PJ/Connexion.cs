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
        private static SqlConnection _con;
        private SqlCommand _cmd;
        private DataTable _dataTable;
        private SqlDataAdapter _dataAdapter;

        string ch;

        public SqlConnection Con
        {
            get
            {
                return _con;
            }
        }

        public Connexion()
        {
            ch = "Data Source=SQL5104.site4now.net;Initial Catalog=db_a736ef_01;User Id=db_a736ef_01_admin;Password=dbo_01_1996";
            _con = new SqlConnection(ch);
        }                  
             
        ////////////// ----- Show table ----- /////////////
        public DataTable showDataTable(string Sqlcommand)
        {            
            _con.Open();

            _cmd = new SqlCommand(Sqlcommand, _con);

            _dataTable = new DataTable();
            _cmd.ExecuteNonQuery();

            _dataAdapter = new SqlDataAdapter(_cmd);
            _dataAdapter.Fill(_dataTable);

            _con.Close();
            
            return _dataTable;
        }

        ////////////// ----- Show table Using Proc ID ----- //////////////
        public DataTable showParamDataTable(string Sqlcommand, string idName)
        {          

            _con.Open();

            SqlCommand _cmd = new SqlCommand(Sqlcommand, _con);
            _cmd.CommandType = CommandType.StoredProcedure;

            _cmd.Parameters.Add(idName, SqlDbType.UniqueIdentifier);

            _cmd.Parameters[idName].Value = Guid.Parse("");

            _dataTable = new DataTable();
            _cmd.ExecuteNonQuery();

            _dataAdapter = new SqlDataAdapter(_cmd);
            _dataAdapter.Fill(_dataTable);

            _con.Close();

            return _dataTable;
        }

        public int Add_Value(String sqlstring)
        {
            _con.Open();

            _cmd = new SqlCommand(sqlstring,_con);            
            int numb = _cmd.ExecuteNonQuery();

            Con.Close();

            return numb;
        }

        public String executer_valeur(String sqlstring)
        {
            
            _con.Open();

            _cmd = new SqlCommand();
            _cmd.Connection = _con;
            _cmd.CommandText = sqlstring;

            string str = _cmd.ExecuteScalar().ToString();

            _con.Close();

            return str;
        }

    }
}
