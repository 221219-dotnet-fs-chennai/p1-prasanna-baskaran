using Serilog;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;

namespace TrainerFinder_p1
{
    internal class SqlRepo:IRepo
    {
        private readonly string connectionString;
        public SqlRepo(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public UserDetails Add(UserDetails details)
        {

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            Console.WriteLine("Connection opened");

            string query = @"insert into users(user_id,email,pasword, username, gender, phoneno, Website,location) values (@user_id,@email,@pasword, @username, @gender, @Mobile_number, @Website,@location)";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@user_id", details.user_id);
            command.Parameters.AddWithValue("@Password", details.Password);
            command.Parameters.AddWithValue("@Email", details.Email);
            command.Parameters.AddWithValue("@Full_name", details.Username);
            command.Parameters.AddWithValue("@Location", details.Location);
            command.Parameters.AddWithValue("@gender", details.Gender);
            command.Parameters.AddWithValue("@Mobile_number", details.PhoneNo);
            command.Parameters.AddWithValue("@Website", details.Website);
            command.ExecuteNonQuery();




            Console.WriteLine("row(s) added successfully");
            Console.ReadLine();

            return details;
        }

       

        public void DeleteTrainer(string eMail)
        {
            throw new NotImplementedException();
        }

        public UserDetails GetAllTrainer(string email)
        {
            UserDetails detail = new UserDetails();
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            List<UserDetails> details = new List<UserDetails>();

            try
            {

                string query4 = @"Select username,gender,email,pasword, location,aboutme,phoneno,website from users;";

                SqlCommand command = new SqlCommand(query4, con);

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
                System.Console.WriteLine(ex.Message);
                throw;
            }
            return detail;
        }

        public List<UserDetails> GetAllTrainersDisconnected()
        {
            List<UserDetails> details = new List<UserDetails>();

            SqlConnection con = new SqlConnection(connectionString);

            string query5 = @"Select  user_id,Username,location,aboutme,email,pasword,gender,phoneno,website from users;";

            SqlDataAdapter adapter = new SqlDataAdapter(query5, con);

            DataSet ds = new DataSet();
            adapter.Fill(ds);

            DataTable dtTrainer = ds.Tables[0];

            foreach (DataRow row in dtTrainer.Rows)
            {
                details.Add(new UserDetails()
                {
                    user_id = (int)row[0],
                    Username = (string)row[1],
                    Location= (string)row[2],
                    Aboutme= (string)row[3],
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
            string query7 = $"select email from users where email='{Email}';";
            using SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand command1 = new SqlCommand(query7, con);

            SqlDataReader reader = command1.ExecuteReader();

            if (reader.Read())
            {
                reader.Close();
                Console.Write("Enter you password: ");
                string password = System.Console.ReadLine();
                string query8 = $"select email from users where pasword='{password}';";
                SqlCommand command2 = new SqlCommand(query8, con);
                using SqlDataReader read1 = command2.ExecuteReader();
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

        public void UpdateTrainer(string tableName, string columnName, string newValue, int user_id)
        {
            using SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            if (tableName is "users")
            {
                if (columnName is "Age")
                {
                    int newvalue = Convert.ToInt32(newValue);
                    string query = $"update '{tableName}' set '{columnName}' = '{newvalue}' where user_id = '{user_id}'";
                    SqlCommand command1 = new SqlCommand(query, con);
                    Log.Information($"{user_id} is this");
                    command1.ExecuteNonQuery();
                    Console.WriteLine("Data updated");
                }
                else
                {
                    string query = $"update '{tableName}' set '{columnName}' = '{newValue}' where user_id = '{user_id}'";
                    SqlCommand command1 = new SqlCommand(query, con);
                    command1.ExecuteNonQuery();
                    Console.WriteLine("Data updated");
                }
            }
          /*  if (tableName is "Skills")
            {
                string query = $"update '{tableName}' set '{columnName}' = '{newValue}' where user_id = details.Skill_id";
                SqlCommand command1 = new SqlCommand(query, con);
                command1.ExecuteNonQuery();
                Console.WriteLine("Data updated");
            }
            if (tableName is "Company")
            {
                string query = $"update '{tableName}' set '{columnName}' = '{newValue}' where user_id = details.Id'";
                SqlCommand command1 = new SqlCommand(query, con);
                command1.ExecuteNonQuery();
                Console.WriteLine("Data updated");
            }
            if (tableName is "Education_Details")
            {
                string query = $"update '{tableName}' set '{columnName}' = '{newValue}' where user_id = details.Edu_id";
                SqlCommand command1 = new SqlCommand(query, con);
                command1.ExecuteNonQuery();
                Console.WriteLine("Data updated");
            }*/
            Console.WriteLine("Data updated Successfully");

        }

        UserDetails IRepo.GetAllTrainer(string eMail)
        {
            UserDetails detail = new UserDetails();

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            List<UserDetails> details = new List<UserDetails>();

            try
            {

                string query4 = @"Select  user_id, Username,gender, email,pasword, location,aboutme ,phoneNo, website from users;";

                SqlCommand command = new SqlCommand(query4, con);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    details.Add(new UserDetails()
                    {
                        user_id = reader.GetInt32(0),
                        Email = reader.GetString(3),
                        Password=reader.GetString(4),   
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
                System.Console.WriteLine(ex.Message);
                throw;
            }
            return detail;
        }
    

        
    }
}
