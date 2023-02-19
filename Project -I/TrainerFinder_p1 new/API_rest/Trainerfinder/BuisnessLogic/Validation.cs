using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLogic
{
    public class Validation
    {
        Trainerfinder.Entities.AssociatesDbContext Context;
        public Validation(Trainerfinder.Entities.AssociatesDbContext Context)
        {
            Log.Logger.Information("Validation.cs--line->15");
            this.Context = Context; 
        }
        public int Pid(String t)
        {
            Log.Logger.Information("Validation.cs--line->19");
            int id = 0;
            var v=Context.Users.Where(i=>i.Email==t).FirstOrDefault();
            if (v.Email==t) {
                id = v.UserId;
            }
            return id;
        }
    }
}
