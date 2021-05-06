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
        private SqlCommand cmd;
        private DataTable dataTable;
        private SqlDataReader dataReader;
        private SqlDataAdapter dataAdapter;
        byte[] imgData;

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
<<<<<<< Updated upstream
=======
        {            
            _con.Open();
            _cmd = new SqlCommand(Sqlcommand, _con);
            _dataTable = new DataTable();
            DataSet set = new DataSet();
           
            _dataAdapter = new SqlDataAdapter(_cmd);
            _dataAdapter.Fill(set);
            _con.Close();
            
            return set.Tables[0];
>>>>>>> Stashed changes
        {
            if(_con.State != ConnectionState.Open)
            {
                _con.Open();
            }

            cmd = new SqlCommand(Sqlcommand, _con);

            dataTable = new DataTable();
            cmd.ExecuteNonQuery();

            dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dataTable);

            if (_con.State == ConnectionState.Open)
            {
                _con.Close();
            }

            return dataTable;
        }

        ////////////// ----- Show table Using Proc ID ----- //////////////
        public DataTable showParamDataTable(string Sqlcommand, string idName)
        {          

            _con.Open();

            SqlCommand cmd = new SqlCommand(Sqlcommand, _con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(idName, SqlDbType.UniqueIdentifier);

            cmd.Parameters[idName].Value = Guid.Parse("");

            dataTable = new DataTable();
            cmd.ExecuteNonQuery();

            dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dataTable);

            _con.Close();

            return dataTable;
<<<<<<< Updated upstream
        }

        ////////////// ----- get Image ----- //////////////
        public byte[] getImage(int imagId)
        {
            _con.Open();
            
            string selectQuery = string.Format(@"SELECT image FROM dbo.Images WHERE id = '{0}'", imagId);

            //Select Image
            
            cmd = new SqlCommand(selectQuery, _con);
            dataReader = cmd.ExecuteReader();

            if (dataReader.Read())
            {
                imgData = (byte[])dataReader[0];                
            }

            dataReader.Close();
            _con.Close();
            return imgData;
        }

=======
        }

        ////////////// ----- get Image ----- //////////////
        public byte[] getImage(int imagId)
        {
            _con.Open();
            
            string selectQuery = string.Format(@"SELECT image FROM dbo.Images WHERE id = '{0}'", imagId);

            //Select Image
            
            cmd = new SqlCommand(selectQuery, _con);
            dataReader = cmd.ExecuteReader();

            if (dataReader.Read())
            {
                imgData = (byte[])dataReader[0];                
            }

            dataReader.Close();
            _con.Close();
            return imgData;
        }

>>>>>>> Stashed changes
        ////////////// ----- Add Value ----- //////////////
        public int Add_Value(String sqlstring)
        {
            try
            {
                _con.Open();
                _cmd = new SqlCommand(sqlstring, _con);
                int numb = _cmd.ExecuteNonQuery();
                _con.Close();
                return numb;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Number+" "+ex.Message);
                return 0;
            }
            _con.Open();

            cmd = new SqlCommand(sqlstring,_con);            
            int numb = cmd.ExecuteNonQuery();

            Con.Close();

            return numb;
        }

        ////////////// ----- Executer Valeur ----- //////////////
        public String executer_valeur(String sqlstring)
        {
            
            _con.Open();

            cmd = new SqlCommand();
            cmd.Connection = _con;
            cmd.CommandText = sqlstring;

            string str = cmd.ExecuteScalar().ToString();

            _con.Close();

            return str;
        }

    }
}
