using FluentAPI;
using Models;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLogic
{
    public class SkillLogic : ISkillLogic
    {
        Validation id;
        FluentAPI.ISkillRepo<Trainerfinder.Entities.Skill> Repo;

        public SkillLogic(Validation id, ISkillRepo<Trainerfinder.Entities.Skill> repo)
        {
            Log.Logger.Information("SkillLogic.cs--line->19");
            this.id = id;
            Repo = repo;
        }

        public Models.Skill AddSkills(string Email, Models.Skill skills)
        {
            Log.Logger.Information("SkillLogic.cs--line->26");
            skills.UserId = id.Pid(Email);
            return Mapper.Map(Repo.Add(Mapper.Map(skills)));
        }

        public IEnumerable<Models.Skill> Get(string email)
        {
            Log.Logger.Information("SkillLogic.cs--line->33");
            int i=id.Pid(email);
            return Mapper.Map(Repo.Get(i));
           
        }

        public IEnumerable<Models.Skill> GetSkills()
        {
            Log.Logger.Information("SkillLogic.cs--line->41");
            return Mapper.Map(Repo.GetSkills());    
        }

        public Models.Skill RemoveSkills(string r)
        {
            Log.Logger.Information("SkillLogic.cs--line->47");
            int i=id.Pid(r);    
            return Mapper.Map(Repo.RemoveSkills(i));
        }

        public Models.Skill UpdateSkills(string Email, Models.Skill r)
        {
            Log.Logger.Information("SkillLogic.cs--line->54");
            var skills = (from rst in Repo.GetSkills()
                          where rst.UserId == r.UserId
                          select rst).FirstOrDefault();
            if (skills != null)
            {
                skills.Skillid = r.Skillid; 
                skills.UserId=r.UserId;
                skills.Skills = r.Skills;
                skills.Certification = r.Certification;
                skills = Repo.UpdateSkills(skills);
            }
            return Mapper.Map(skills);
        }
    }
}
