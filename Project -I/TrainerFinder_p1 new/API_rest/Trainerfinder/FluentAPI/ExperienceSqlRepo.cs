using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trainerfinder.Entities;

namespace FluentAPI
{
    public class ExperienceSqlRepo : IExperienceRepo<Trainerfinder.Entities.Experience>
    {
        public ExperienceSqlRepo() { }
        Trainerfinder.Entities.AssociatesDbContext Context=new AssociatesDbContext();

        public Experience Add(Experience t)
        {
            Log.Logger.Information("ExperienceSqlRepo.cs--line->18");
            Context.Add(t);
          Context.SaveChanges();
            return t;
        }

        public List<Experience> GetExperience()
        {
            Log.Logger.Information("ExperienceSqlRepo.cs--line->26");
            return Context.Experiences.ToList();
        }

        public Experience RemoveExperience(int t)
        {
            Log.Logger.Information("ExperienceSqlRepo.cs--line->32");
            var id = Context.Experiences.Where(e => e.UserId == t);
            Context.Experiences.Remove((Experience)id);
            Context.SaveChanges();

            return (Experience)id;
        }

        public Experience UpdateExperience(Experience t)
        {
            Log.Logger.Information("ExperienceSqlRepo.cs--line->42");
            Context.Update(t);
            Context.SaveChanges();
            return (Experience)t;
        }

        public IEnumerable<Experience> Get(int t)
        {
            Log.Logger.Information("ExperienceSqlRepo.cs--line->50");
            var id=Context.Experiences.Where((e) => e.UserId == t);
            return id;
        }
    }
}
