using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trainerfinder.Entities;

namespace FluentAPI
{
    public class EducationSqlRepo : IEducationRepo<Trainerfinder.Entities.Education>
    {
        public EducationSqlRepo() { }
        Trainerfinder.Entities.AssociatesDbContext Context =new AssociatesDbContext();

        public Education Add(Education t)
        {
            Log.Logger.Information("EducationSqlRepo.cs--line->18");
            Context.Add(t);
            Context.SaveChanges();
            return t;
        }

        public List<Education> GetEducationDetails()
        {
            Log.Logger.Information("EducationSqlRepo.cs--line->26");
            return Context.Educations.ToList();
        }

        public Education RemoveEducation(int t)
        {
            Log.Logger.Information("EducationSqlRepo.cs--line->32");
            var id = Context.Educations.Where(ti => ti.UserId == t).FirstOrDefault();
            Context.Remove(id);   
            Context.SaveChanges();

            return id;

        }

        public Education UpdateEducationDetails(Education t)
        {
            Log.Logger.Information("EducationSqlRepo.cs--line->43");
            Context.Update(t);
            Context.SaveChanges();
            return t;
        }

        public IEnumerable<Education> Get(int t)
        {
            Log.Logger.Information("EducationSqlRepo.cs--line->51");
            var id=Context.Educations.Where(d => d.UserId == t);
            return id;
        }
    }
}
