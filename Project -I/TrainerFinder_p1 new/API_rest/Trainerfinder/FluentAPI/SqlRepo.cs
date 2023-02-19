using Models;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Trainerfinder.Entities;

namespace FluentAPI
{
    public class SqlRepo : IRepo<Trainerfinder.Entities.User>
    {
        public SqlRepo() { }
        Trainerfinder.Entities.AssociatesDbContext context = new AssociatesDbContext();
        public Trainerfinder.Entities.User Add(Trainerfinder.Entities.User t)
        {
            Log.Logger.Information("SqlRepo.cs--line->19");
            context.Add(t);
            context.SaveChanges();
            return t;
        }
        
        public Trainerfinder.Entities.User Get(string Email)
        {
            Log.Logger.Information("SqlRepo.cs--line->27");
            var s = context.Users.Where(m => m.Email == Email).FirstOrDefault();
            return s;
        }

        public List<Trainerfinder.Entities.User> GetUserDetails()
        {
            Log.Logger.Information("SqlRepo.cs--line->34");
            return context.Users.ToList();
        }

        public Trainerfinder.Entities.User RemoveUserDetails(string Email)
        {
            Log.Logger.Information("SqlRepo.cs--line->40");
            var se=context.Users.Where(m =>m.Equals(Email)).FirstOrDefault();
            return se;
        }

        public Trainerfinder.Entities.User UpdateUserDetails(Trainerfinder.Entities.User t)
        {
            Log.Logger.Information("SqlRepo.cs--line->47");
            context.Users.Update(t);
            context.SaveChanges();
            return t;
            
        }

     
    }
}
