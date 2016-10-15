using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Linq;
using System.Web;

namespace Project.Models
{
    public class Register
    {
        private string GetDBConnectionString()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString.ToString();
        }

        public void UserRegister(Models.UserDetail User)
        {
            string sql = @" Insert INTO dbo.UserDetail
						 (
							UserAccount,UserPassword,UserName,UserSex,UserEmail
						 )
						VALUES
						(
							@UserAccount,@UserPassword,@UserName,@UserSex,@UserEmail
                        )
						";
            
            using (SqlConnection conn = new SqlConnection(this.GetDBConnectionString()))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.Add(new SqlParameter("@UserAccount", User.UserAccount));
                cmd.Parameters.Add(new SqlParameter("@UserPassword", User.UserPassword));
                cmd.Parameters.Add(new SqlParameter("@UserName", User.UserName));
                cmd.Parameters.Add(new SqlParameter("@UserSex", User.UserSex));
                cmd.Parameters.Add(new SqlParameter("@UserEmail", User.UserEmail));
                cmd.ExecuteNonQuery();


                conn.Close();
            }

            
        }
    }
}