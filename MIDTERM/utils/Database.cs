using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIDTERM.utils
{
    internal class Database
    {
        private string getConntection()
        {
            string conn_string = "Data Source=WINDOWS-11\\SQLEXPRESS;" +
                          "Initial Catalog=DBMS_OU;Integrated Security=True;" +
                          "TrustServerCertificate=True";
            return conn_string;
        }

        public bool check_login(string login, string password, string loginType)
        {   // check if user login is in database
            bool check = false;
            string type = "Admin_system";
            if (loginType == "Client")
                type = "User_system";

            string myread = "declare @check_exist as bit = 0 if exists " +
                            "(select * from " + type + " where " +
                            "userlogin = @login and passwordlogin = @password) " +
                            "begin set @check_exist = 1 end " +
                            "select @check_exist";
            using (var connection = new SqlConnection(getConntection()))
            using (var command = new SqlCommand(myread, connection))
            using (var adapter = new SqlDataAdapter(command))
            {
                connection.Open();
                command.Parameters.AddWithValue("@login", login);
                command.Parameters.AddWithValue("@password", password);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    check = (bool)reader[0];
                    break;
                }
                connection.Close();
            }
            return check;
        }
    }
}
