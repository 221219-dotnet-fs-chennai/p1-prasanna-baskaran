using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainerFinder_p1
{
    internal class DeleteUser : IMenu
    {
        UserDetails user2= new UserDetails();
        public DeleteUser() { }
        static string connstrr = "Server=tcp:prasanna-db1.database.windows.net,1433;Initial Catalog=TrainerFinder;User ID=prasannaadmin;Password=Amma@621218;\"";
        IRepo repo = new SqlRepo(connstrr);
        public DeleteUser(UserDetails user)
        {
            Log.Logger.Information("DeleteUser.cs Line no : 17");
            user2 = user; ;
        }
        public void Display()
        {
            Log.Logger.Information("DeleteUser.cs Line no : 22");
            System.Console.WriteLine("Confirm to Drop User\n");
            System.Console.WriteLine("[0] Back");
            System.Console.WriteLine("[1] Delete User");

        }

        public string UserChoice()
        {
            Log.Logger.Information("DeleteUser.cs Line no : 31");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "0":
                    return "TrainerUpdate";
                case "1":
                    repo.DeleteUser(user2.Email);
                    Log.Logger.Information("User deleted");
                    Console.WriteLine("User deleted succesfully");
                    return "MainMenu";
            }
            return "DropTrainer";
        }
    }
}
