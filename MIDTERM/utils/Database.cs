using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MIDTERM.utils
{
    public partial class Database
    {
        private string logged_id = "";
        private string getConntection()
        {
            string conn_string = "Data Source=DESKTOP-V50GS4K;" +
                          "Initial Catalog=DBMS_OU;Integrated Security=True;" +
                          "TrustServerCertificate=True";
            return conn_string;
        }
        public void get_loggedID(string login, string password, string loginType)
        {   // get logged ID session
            string type = "Admin_system", columns = "admin_id";
            if (loginType == "Client")
            {
                type = "User_system";
                columns = "national_id";
            }

            string myread = "select " + columns + " from " + type + " where " +
                            "userlogin = @login and passwordlogin = @password ";
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
                    logged_id = reader[0].ToString();
                    break;
                }
                connection.Close();
            }
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
                get_loggedID(login, password, loginType);
                connection.Close();
            }
            return check;
        }
        public DataSet display_userAll()
        { // display all user to datagridview
            string myread = "select * from user_system";
            SqlDataAdapter dataload = new SqlDataAdapter(myread, getConntection());
            DataSet dataset = new DataSet();
            dataload.Fill(dataset, "user_system");
            return dataset;
        }

        public DataSet display_plantAll()
        {
            // display all plants to datagridview
            string myread = "select * from plant";
            SqlDataAdapter dataload = new SqlDataAdapter(myread, getConntection());
            DataSet dataset = new DataSet();
            dataload.Fill(dataset, "plant");
            return dataset;
        }
        public DataSet display_userSearch(string national_id)
        { // display searched user to datagridview
            string myread = "select * from user_system where national_id LIKE @national_id";
            using (var connection = new SqlConnection(getConntection()))
            using (var command = new SqlCommand(myread, connection))
            using (var adapter = new SqlDataAdapter(command))
            {
                connection.Open();
                command.Parameters.AddWithValue("@national_id", "%" + national_id + "%");
                var dataset = new DataSet();
                adapter.Fill(dataset, "user_system");
                connection.Close();
                return dataset;
            }
        }

        public DataSet display_plantSearch(string plant_name)
        { // display searched plant to datagridview
            string myread = "select * from plant where plant_name LIKE @plant_name";
            using (var connection = new SqlConnection(getConntection()))
            using (var command = new SqlCommand(myread, connection))
            using (var adapter = new SqlDataAdapter(command))
            {
                connection.Open();
                command.Parameters.AddWithValue("@plant_name", "%" + plant_name + "%");
                var dataset = new DataSet();
                adapter.Fill(dataset, "plant");
                connection.Close();
                return dataset;
            }
        }

        private bool check_user_exist(string national_id)
        { // check if user exist for adding and updating
            bool check = false;
            string myread = "declare @check_exist as bit = 0 if exists " +
                            "(select * from user_system where " +
                            "national_id = @national_id) " +
                            "begin set @check_exist = 1 end " +
                            "select @check_exist";
            using (var connection = new SqlConnection(getConntection()))
            using (var command = new SqlCommand(myread, connection))
            using (var adapter = new SqlDataAdapter(command))
            {
                connection.Open();
                command.Parameters.AddWithValue("@national_id", national_id);
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

        private bool check_plant_exist(string plant_name)
        { // check if user exist for adding and updating
            bool check = false;
            string myread = "declare @check_exist as bit = 0 if exists " +
                            "(select * from plant where " +
                            "plant_name = @plant_name) " +
                            "begin set @check_exist = 1 end " +
                            "select @check_exist";
            using (var connection = new SqlConnection(getConntection()))
            using (var command = new SqlCommand(myread, connection))
            using (var adapter = new SqlDataAdapter(command))
            {
                connection.Open();
                command.Parameters.AddWithValue("@plant_name", plant_name);
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
        public bool add_newUser(string national_id, string fullname, 
                                string userlogin, string passwordlogin, 
                                string gender, string address, string dateofbirth)
        { // add new user
            if (!check_user_exist(national_id))
            {
                SqlConnection sqlConnection = new SqlConnection(getConntection());
                sqlConnection.Open();
                string myread = "insert into User_System(National_ID, userlogin, " +
                                                        "passwordlogin, Admin_ID, " +
                                                        "FullName, DateOfBirth, " +
                                                        "AddressUser, Gender)" +
                                "Values(@national_id, @userlogin, @passwordlogin, @Admin_ID, " +
                                "@FullName, @DateOfBirth, @AddressUser, @Gender)";
                SqlCommand mycom = new SqlCommand(myread, sqlConnection);
                mycom.Parameters.AddWithValue("@national_id", national_id);
                mycom.Parameters.AddWithValue("@userlogin", userlogin);
                mycom.Parameters.AddWithValue("@passwordlogin", passwordlogin);
                mycom.Parameters.AddWithValue("@Admin_ID", logged_id);
                mycom.Parameters.AddWithValue("@FullName", fullname);
                mycom.Parameters.AddWithValue("@DateOfBirth", dateofbirth);
                mycom.Parameters.AddWithValue("@AddressUser", address);
                mycom.Parameters.AddWithValue("@Gender", gender);
                mycom.ExecuteNonQuery();
                sqlConnection.Close();
                return true;
            }
            return false;
        }

        public bool add_newPlant(string plant_name,
                                double temperature, double water_level,
                                double fertilizer_level)
        { // add new plant
            if (!check_plant_exist(plant_name))
            {
                SqlConnection sqlConnection = new SqlConnection(getConntection());
                sqlConnection.Open();
                string myread = "insert into plant(admin_id, plant_name, " +
                                                        "temperature, water_level, " +
                                                        "fertilizer_level)" +
                                "Values(@admin_id, @plant_name, @temperature, @water_level, @fertilizer_level)";
                SqlCommand mycom = new SqlCommand(myread, sqlConnection);
                mycom.Parameters.AddWithValue("@admin_id", logged_id);
                mycom.Parameters.AddWithValue("@plant_name", plant_name);
                mycom.Parameters.AddWithValue("@temperature", temperature);
                mycom.Parameters.AddWithValue("@water_level", water_level);
                mycom.Parameters.AddWithValue("@fertilizer_level", fertilizer_level);
                mycom.ExecuteNonQuery();
                sqlConnection.Close();
                return true;
            }
            return false;
        }

        public bool update_currentUser(string national_id, string fullname,
                                string userlogin, string passwordlogin,
                                string gender, string address, string dateofbirth, int id_selected)
        {// update user information
            if (check_user_exist(national_id))
            {
                SqlConnection sqlConnection = new SqlConnection(getConntection());
                sqlConnection.Open();
                string myread = "update User_System set " +
                                "national_id = @national_id, userlogin = @userlogin, " +
                                "passwordlogin = @passwordlogin, Admin_ID = @Admin_ID, " +
                                "FullName = @FullName, DateOfBirth = @DateOfBirth, " +
                                "AddressUser = @AddressUser, Gender = @Gender " +
                                "where userID = @userID";
                SqlCommand mycom = new SqlCommand(myread, sqlConnection);
                mycom.Parameters.AddWithValue("@national_id", national_id);
                mycom.Parameters.AddWithValue("@userlogin", userlogin);
                mycom.Parameters.AddWithValue("@passwordlogin", passwordlogin);
                mycom.Parameters.AddWithValue("@Admin_ID", logged_id);
                mycom.Parameters.AddWithValue("@FullName", fullname);
                mycom.Parameters.AddWithValue("@DateOfBirth", dateofbirth);
                mycom.Parameters.AddWithValue("@AddressUser", address);
                mycom.Parameters.AddWithValue("@Gender", gender);
                mycom.Parameters.AddWithValue("@userID", id_selected.ToString());
                mycom.ExecuteNonQuery();
                sqlConnection.Close();
                return true;
            }
            return false;
        }

        public bool update_currentPlant(string plant_name,
                                double temperature, double water_level,
                                double fertilizer_level, int id_selected)
        {// update plant information
            if (check_plant_exist(plant_name))
            {
                SqlConnection sqlConnection = new SqlConnection(getConntection());
                sqlConnection.Open();
                string myread = "update plant set " +
                                "admin_id = @admin_id, plant_name = @plant_name, temperature = @temperature, " +
                                "water_level = @water_level, fertilizer_level = @fertilizer_level " +
                                "where plant_ID = @plant_ID";
                SqlCommand mycom = new SqlCommand(myread, sqlConnection);
                mycom.Parameters.AddWithValue("@admin_id", logged_id);
                mycom.Parameters.AddWithValue("@plant_name", plant_name);
                mycom.Parameters.AddWithValue("@temperature", temperature);
                mycom.Parameters.AddWithValue("@water_level", water_level);
                mycom.Parameters.AddWithValue("@fertilizer_level", fertilizer_level);
                mycom.Parameters.AddWithValue("@plant_ID", id_selected.ToString());
                mycom.ExecuteNonQuery();
                sqlConnection.Close();
                return true;
            }
            return false;
        }

        public bool delete_currentUser(string national_id)
        { // delete user information
            if (check_user_exist(national_id))
            {
                SqlConnection sqlConnection = new SqlConnection(getConntection());
                sqlConnection.Open();
                string myread = "delete from user_system where national_id = @nationalID";
                SqlCommand mycom = new SqlCommand(myread, sqlConnection);
                mycom.Parameters.AddWithValue("@nationalID", national_id);
                mycom.ExecuteNonQuery();
                sqlConnection.Close();
                return true;
            }
            return false;
        }

        public bool delete_currentPlant(string plant_name)
        { // delete plant information
            if (check_plant_exist(plant_name))
            {
                SqlConnection sqlConnection = new SqlConnection(getConntection());
                sqlConnection.Open();
                string myread = "delete from plant where plant_name = @plant_name";
                SqlCommand mycom = new SqlCommand(myread, sqlConnection);
                mycom.Parameters.AddWithValue("@plant_name", plant_name);
                mycom.ExecuteNonQuery();
                sqlConnection.Close();
                return true;
            }
            return false;
        }
    }
}
