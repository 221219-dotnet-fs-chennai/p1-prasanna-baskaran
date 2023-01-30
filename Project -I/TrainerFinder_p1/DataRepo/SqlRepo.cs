using Serilog;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using BuisnessLogic;
using Models;
using System;
using System.Collections.Generic;

namespace DataRepo
{
    public class SqlRepo : IRepo
    {
        private readonly string connectionString;
        public SqlRepo(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public UserDetails Add(UserDetails details)
        {
            Log.Logger.Information("sqlrepo.cs at line 19 ");

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            Console.WriteLine("Connection opened");

            string query = @"insert into Prasanna.[users](user_id,email,pasword, username, gender, phoneno, Website,location,Aboutme) values (@user_id,@email,@pasword, @username, @gender, @Mobile_number, @Website,@location,@aboutme)";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@user_id", details.user_id);
            command.Parameters.AddWithValue("@pasword", details.Password);
            command.Parameters.AddWithValue("@Email", details.Email);
            command.Parameters.AddWithValue("@username", details.Username);
            command.Parameters.AddWithValue("@Location", details.Location);
            command.Parameters.AddWithValue("@gender", details.Gender);
            command.Parameters.AddWithValue("@Mobile_number", details.PhoneNo);
            command.Parameters.AddWithValue("@Website", details.Website);
            command.Parameters.AddWithValue("@aboutme", details.Aboutme);
            command.ExecuteNonQuery();




            Console.WriteLine("row(s) added successfully");
            Console.ReadLine();

            return details;
        }



        public void DeleteUser(string eMail)
        {
            Log.Logger.Information("sqlrepo.cs at line 52 ");
            throw new NotImplementedException();
        }

        public UserDetails GetAllUser(string email)
        {
            Log.Logger.Information("sqlrepo.cs at line 58 ");
            UserDetails detail = new UserDetails();
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            List<UserDetails> details = new List<UserDetails>();

            try
            {

                string query = @"Select username,gender,email,pasword, location,aboutme,phoneno,website from Prasanna.[users];";

                SqlCommand command = new SqlCommand(query, con);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    details.Add(new UserDetails()
                    {
                        Username = reader.GetString(0),
                        Gender = reader.GetString(1),
                        Email = reader.GetString(2),
                        Password = reader.GetString(3),
                        Location = reader.GetString(4),
                        Aboutme = reader.GetString(5),
                        PhoneNo = reader.GetString(6),
                        Website = reader.GetString(7)
                    });
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Query not Executed");
                throw;
            }
            return detail;
        }

        List<UserDetails> IRepo.GetAllUser()
        {
            Log.Logger.Information("sqlrepo.cs at line 100 ");
            List<UserDetails> details = new List<UserDetails>();

            SqlConnection con = new SqlConnection(connectionString);

            string query = @"Select  user_id,Username,location,aboutme,email,pasword,gender,phoneno,website from Prasanna.[users];";

            SqlDataAdapter adapter = new SqlDataAdapter(query, con);

            DataSet ds = new DataSet();
            adapter.Fill(ds);

            DataTable dtTrainer = ds.Tables[0];

            foreach (DataRow row in dtTrainer.Rows)
            {
                details.Add(new UserDetails()
                {
                    user_id = (int)row[0],
                    Username = (string)row[1],
                    Location = (string)row[2],
                    Aboutme = (string)row[3],
                    Email = (string)row[4],
                    Password = (string)row[5],
                    Gender = (string)row[6],
                    PhoneNo = (string)row[7],
                    Website = (string)row[8],

                });
            }

            return details;
        }

        public bool login(string Email)
        {
            Log.Logger.Information("sqlrepo.cs at line 135 ");
            string query = $"select email from Prasanna.[users] where email='{Email}';";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand command1 = new SqlCommand(query, con);

            SqlDataReader reader = command1.ExecuteReader();

            if (reader.Read())
            {
                reader.Close();
                Console.Write("Enter you password: ");
                string password = System.Console.ReadLine();
                string query_1 = $"select email from Prasanna.[users] where pasword='{password}';";
                SqlCommand command2 = new SqlCommand(query_1, con);
                SqlDataReader read1 = command2.ExecuteReader();
                if (read1.Read())
                {
                    Console.WriteLine("Login Success");
                    Console.ReadLine();
                    return true;
                }
                else
                {
                    Console.WriteLine("Wrong Password");
                    read1.Close();
                    return false;
                }
            }
            else
            {
                Console.WriteLine("No data found");
                Console.ReadLine();
                return false;
            }
        }

        public void UpdateUser(string tableName, string columnName, string newValue, int user_id)
        {
            Log.Logger.Information("sqlrepo.cs at line 174 ");
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            if (tableName is "Prasanna.[users]")
            {
                if (columnName is "user_id")
                {
                    int newvalue = Convert.ToInt32(newValue);
                    string query = $"update '{tableName}' set '{columnName}' = '{newvalue}' where user_id = '{user_id}'";
                    SqlCommand command1 = new SqlCommand(query, con);
                    Log.Information($"{user_id}");
                    command1.ExecuteNonQuery();
                    Console.WriteLine("Data updated");
                }

            }

            Console.WriteLine("Data updated Successfully");

        }



        UserDetails IRepo.GetAllUser(string eMail)
        {
            Log.Logger.Information("sqlrepo.cs at line 197 ");
            UserDetails detail = new UserDetails();

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            List<UserDetails> details = new List<UserDetails>();

            try
            {

                string query = @"Select  user_id, Username,gender, email,pasword, location,aboutme ,phoneNo, website from Prasanna.[users];";

                SqlCommand command = new SqlCommand(query, con);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    details.Add(new UserDetails()
                    {
                        user_id = reader.GetInt32(0),
                        Email = reader.GetString(3),
                        Password = reader.GetString(4),
                        Username = reader.GetString(1),
                        Location = reader.GetString(5),
                        Gender = reader.GetString(2),
                        Aboutme = reader.GetString(6),
                        PhoneNo = reader.GetString(7),
                        Website = reader.GetString(8),
                    });
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Query not executed");
                throw;
            }
            return detail;
        }
    }


}
