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
    public class ExperienceLogic : IExperienceLogic
    {
        Validation id;
        FluentAPI.IExperienceRepo<Trainerfinder.Entities.Experience> Repo;    
        public ExperienceLogic(Validation _id,FluentAPI.IExperienceRepo<Trainerfinder.Entities.Experience> experience) 
        {
            Log.Logger.Information("ExperienceLogic.cs--line->18");
            id = _id;
            Repo = experience;
        }
        public Experience AddExperience(string email, Experience company)
        {
            Log.Logger.Information("ExperienceLogic.cs--line->24");
            company.UserId = id.Pid(email);
            return Mapper.Map(Repo.Add(Mapper.Map(company)));   
        }

        public IEnumerable<Experience> Get(string email)
        {
            Log.Logger.Information("ExperienceLogic.cs--line->31");
            int uid= id.Pid(email); 
            return Mapper.Map(Repo.Get(uid));
        }

        public IEnumerable<Experience> GetExperience()
        {
            Log.Logger.Information("ExperienceLogic.cs--line->38");
            return Mapper.Map(Repo.GetExperience());
        }

        public Experience RemoveExperience(string email)
        {
            Log.Logger.Information("ExperienceLogic.cs--line->44");
            int uid = id.Pid(email);
            return Mapper.Map(Repo.RemoveExperience(uid));
        }

        public Experience UpdateExperience(string Email, Experience r)
        {
            Log.Logger.Information("ExperienceLogic.cs--line->51");
            var company = (from rst in Repo.GetExperience()
                           where rst.UserId == r.UserId
                           select rst).FirstOrDefault();
            if (company != null)
            {
                company.UserId= r.UserId;
                company.Companyid= r.Companyid;
                company.Company= r.Company;
                company.JobRole= r.JobRole;
                company.Experience1= r.Experience1;

                company = Repo.UpdateExperience(company);
            }
            return Mapper.Map(company);
        }
    }
    
}
