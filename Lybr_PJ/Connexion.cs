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
        private SqlConnection _con;
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
        {
            try
            {
                if (_con.State != ConnectionState.Open)
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
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Number + " " + ex.Message);
                return new DataTable();
            }
        }

        ////////////// ----- Show table Using Proc ID ----- //////////////
        public DataTable showParamDataTable(string Sqlcommand, string idName)
        {

            try
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
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Number + " " + ex.Message);
                return new DataTable();
            }

        }

        ////////////// ----- get Image ----- //////////////
        public byte[] getImage(int imagId)
        {
            try
            {
                _con.Open();
                string selectQuery = string.Format(@"SELECT image FROM dbo.Images WHERE id = {0}", imagId);
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
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Number+" "+ex.Message);
                return new byte[0];
            }
        }



        ////////////// ----- Add Value ----- //////////////
        public int Add_Value(String sqlstring)
        {
            try
            {
                _con.Open();
                cmd = new SqlCommand(sqlstring, _con);
                int numb = cmd.ExecuteNonQuery();
                _con.Close();
                return numb;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Number+" "+ex.Message);
                return 0;
            }
        }

        ////////////// ----- Executer Valeur ----- //////////////
        public String executer_valeur(String sqlstring)
        {
            try
            {
                _con.Open();
                cmd = new SqlCommand();
                cmd.Connection = _con;
                cmd.CommandText = sqlstring;
                string str = cmd.ExecuteScalar().ToString();
                _con.Close();
                return str;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Number +" "+ex.Message);
                return "";
            }
        }
        ////////////// ----- Connection Open ----- //////////////
        public void Open()
        {
            try
            {
                _con.Open();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
