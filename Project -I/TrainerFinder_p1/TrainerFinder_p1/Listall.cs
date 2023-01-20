using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainerFinder_p1
{
    internal class Listall : IMenu
    {
        static string constrr = "Server=tcp:prasanna-db-server.database.windows.net,1433;Initial Catalog=Trainerfind;User ID=prasannaadmin;Password=Amma@621218;";
        IRepo repo = new SqlRepo(constrr);
        public void Display()
        {
            
            System.Console.WriteLine("[0] Back");
            System.Console.WriteLine("[1] User_Menu");

        }

        public string UserChoice()
        {
            System.Console.Write("Enter your choice: ");
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "0":
                    return "Menu";
                case "1":
                    Log.Information("Getting all trainers");
                    var listOfTrainers = repo.GetAllTrainersDisconnected();
                    Log.Information($"Got list of {listOfTrainers.Count} Trainers");
                    Log.Information("Reading Trainers about to start");
                    foreach (var r in listOfTrainers)
                    {
                        
                        Console.WriteLine(r.ToString());
                        
                    }
                    Log.Information(" print trainers List");
                    Console.WriteLine(" Enter to continue");
                    Console.ReadLine();

                    return "GetAvailableTrainers";
                default:
                    Console.WriteLine("Try again...");
                    Console.WriteLine("Enter to Continue...");
                    Console.ReadLine();
                    return "GetAvailableTrainers";

            }
        }
    }
}
