using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trainerfinder.Entities;

namespace FluentAPI
{ 
    public class SkillSqlRepo : ISkillRepo<Trainerfinder.Entities.Skill>
    {
        public SkillSqlRepo() { }
        AssociatesDbContext context = new AssociatesDbContext();
        public Skill Add(Skill t)
        {
            Log.Logger.Information("SkillSqlRepo.cs--line->17");
            context.Add(t);
            context.SaveChanges();
            return t;
        }

        public IEnumerable<Skill> Get(int t)
        {
            Log.Logger.Information("SkillSqlRepo.cs--line->25");
            var mail=context.Skills.Where(s => s.UserId == t);
           return mail;
        }

        public List<Skill> GetSkills()
        {
            Log.Logger.Information("SkillSqlRepo.cs--line->32");
            return context.Skills.ToList();
        }

        public Skill RemoveSkills(int t)
        {
            Log.Logger.Information("SkillSqlRepo.cs--line->38");
            var id = context.Skills.Where(s => s.Skillid == t).FirstOrDefault();
            context.Skills.Remove(id);
            context.SaveChanges();
            return id;
        }

        public Skill UpdateSkills(Skill t)
        {
            Log.Logger.Information("SkillSqlRepo.cs--line->47");
            context.Skills.Update(t);
            context.SaveChanges();
            return t;
        }
    }
}
