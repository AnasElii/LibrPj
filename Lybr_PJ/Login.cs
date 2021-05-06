﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace x_prj_biblio
{
    class Login
    {
        private string username;
        private string email;
        private string password;
        protected SqlCommand cmd;

        Connexion c = LoginForm.c;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string UserName
        {
            get { return username; }
            set { username = value; }
        }

        public string PassWord
        {
            get { return password; }
            set { password = value; }
        }

        public Login()
        {            
        }
        
        public string CheckLogin()
        {
            c.Con.Open();

            cmd = new SqlCommand("[dbo].[Admin_Login]",c.Con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@Email", SqlDbType.VarChar, 30);
            cmd.Parameters.Add("@Password", SqlDbType.VarChar, 30);

            cmd.Parameters.Add("@responseMessage", SqlDbType.VarChar, 150);
            cmd.Parameters["@responseMessage"].Direction = ParameterDirection.Output;

            cmd.Parameters["@Email"].Value = email;
            cmd.Parameters["@Password"].Value = password;

            cmd.ExecuteNonQuery();
                        
            c.Con.Close();

            return cmd.Parameters["@responseMessage"].Value.ToString();

        }

    }
}
