using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLogic
{
    public interface IEducationLogic
    {
        
        Models.Education AddEduDetails(string Email, Models.Education education);

        IEnumerable<Models.Education> GetEducationDetails();
        IEnumerable<Models.Education> Get(string email);
        Models.Education RemoveEducation(string Email);
        Trainerfinder.Entities.Education UpdateEducationDetails(string Email, Models.Education r);

    }
}
