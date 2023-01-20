using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TrainerFinder_p1
{
    internal class SIgnUp:IMenu
    {

            internal static UserDetails details = new UserDetails();

            public SIgnUp(UserDetails trainer)
            {
                details = trainer;
            }
            public SIgnUp()
            {

            }
            private readonly string connectionString;


        static string connStrr = "Server=tcp:prasanna-db-server.database.windows.net,1433;Initial Catalog=Trainerfind;User ID=prasannaadmin;Password=Amma@621218;";

        IRepo repo = new SqlRepo(connStrr);

            public void Display()
            {
                Console.WriteLine("\n********Greetings to trainer Menu********\n");
                Console.WriteLine("[0] Menu");
                Console.WriteLine("[1] Save");
                Console.WriteLine("[2] Username    : " + details.Username);
                Console.WriteLine("[3] Gender      : " + details.Gender);
                Console.WriteLine("[4] Email       : " + details.Email);
                Console.WriteLine("[5] Password    : " + details.Password);
                Console.WriteLine("[6] Location    : " + details.Location);
                Console.WriteLine("[7] About Me    : " + details.Aboutme);
                Console.WriteLine("[8] Phone number: " + details.PhoneNo);
                Console.WriteLine("[9] Website     : " + details.Website);
                
            }
            public string UserChoice()
            {
               
                System.Console.Write("\nEnter your choice: ");
                string userchoice = System.Console.ReadLine();

                switch (userchoice)
                {
                    case "0":
                        return "Menu";
                    case "1":
                        try
                        {
                            Log.Logger.Information("Adding trainer details");
                            repo.Add(details);
                            details = new UserDetails();
                            System.Console.WriteLine("Successfully added");
                            Log.Logger.Information("Successfully added trainer details");
                        }
                        catch (System.Exception ex)
                        {
                            Log.Logger.Information($"Failed to add details {ex.Message}");
                            System.Console.WriteLine("Press Enter to continue");
                            System.Console.ReadLine();
                        }
                        return "AddTrainer";
                    case "4":
                        System.Console.Write("Enter your Email: ");
                        string pattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";

                        string Email = Console.ReadLine();

                        if (Regex.IsMatch(Email, pattern))
                        {
                            details.Email = Email;
                        }
                        else
                        {
                            System.Console.WriteLine(" try again...");
                            System.Console.ReadLine();
                        }
                        return "Signup";
                    case "5":
                        System.Console.Write("Enter your Password: ");
                        string pattern1 = @"";

                        string password = System.Console.ReadLine();

                        if (password!="")
                        {
                            details.Password = password;
                        }
                        else
                        {
                            System.Console.WriteLine(" try again...");
                            System.Console.ReadLine();
                        }
                        return "Signup";


                    case "2":
                        System.Console.Write("Enter your Username: ");
                        details.Username = Console.ReadLine();
                    return "Signup";


                    case "3":
                        System.Console.Write("Enter your Gender: ");
                        details.Gender = Console.ReadLine();
                        return "Signup";

                    case "8":
                        System.Console.Write("Enter your Mobile number: ");
                        string pattern2 = @"^(?:(?:\+|00)91|0)[7-9][0-9]{9}$";

                        string phone_number = Console.ReadLine();

                        if (phone_number!="")
                        {
                            details.PhoneNo = phone_number;
                        }
                        else
                        {
                            System.Console.WriteLine("Wrong pattern try again...");
                            System.Console.ReadLine();
                        }
                        return "Signup";

                    
                case "6":
                    System.Console.Write("Location ");
                    details.Location = System.Console.ReadLine();
                    return "Signup";
                case "7":
                    System.Console.Write("About Me ");
                    details.Aboutme = System.Console.ReadLine();
                    return "Signup";
                case "9":
                    System.Console.Write("Enter you Website: ");
                    details.Website = System.Console.ReadLine();
                    return "Signup";
                


                default:
                        
                        System.Console.WriteLine("Try again!........");
                        System.Console.WriteLine("Enter to continue");
                        System.Console.ReadLine();
                        return "Signup";

                }
            }
        }
    }

