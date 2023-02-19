using FluentAPI;
using Microsoft.Azure.Documents;
using Models;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trainerfinder.Entities;

namespace BuisnessLogic
{
    public class EducationLogic : IEducationLogic
    {
        
        Validation id;
        FluentAPI.IEducationRepo<Trainerfinder.Entities.Education> Repo;
        public EducationLogic(Validation id, FluentAPI.IEducationRepo<Trainerfinder.Entities.Education> repo)
        {
            Log.Logger.Information("EducationLogic.cs--line->21");
            this.id = id;
            Repo = repo;
        }
        public Models.Education AddEduDetails(string Email, Models.Education education)
        {
            Log.Logger.Information("EducationLogic.cs--line->27");
            education.UserId = id.Pid(Email);
            return Mapper.Map(Repo.Add(Mapper.Map(education)));
        }

        public IEnumerable<Models.Education> Get(string email)
        {
            Log.Logger.Information("EducationLogic.cs--line->34");
            int Userid = id.Pid(email);
            return Mapper.Map(Repo.Get(Userid));
        }

        public IEnumerable<Models.Education> GetEducationDetails()
        {
            Log.Logger.Information("EducationLogic.cs--line->41");
            return Mapper.Map(Repo.GetEducationDetails());
        }

        public Models.Education RemoveEducation(string Email)
        {
            Log.Logger.Information("EducationLogic.cs--line->47");
            int Userid = id.Pid(Email);
            return Mapper.Map(Repo.RemoveEducation(Userid));
        }

       public Trainerfinder.Entities.Education UpdateEducationDetails(string Email, Models.Education r)
        {
            Log.Logger.Information("EducationLogic.cs--line->54");
            var education = (from rst in Repo.GetEducationDetails()
                             where rst.UserId == r.UserId
                             select rst).FirstOrDefault();
            if (education != null)
            {
                education.UserId=r.UserId;
                education.Educationid = r.Educationid;
                education.Sslc = r.Sslc;
                education.Ssc = r.Ssc;
                education.Ug= r.Ug;
                education.Pg=r.Pg;


                education = Repo.UpdateEducationDetails(education);
            }
            return Repo.UpdateEducationDetails(education);
        }
    }
}
