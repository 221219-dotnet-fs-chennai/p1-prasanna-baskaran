using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace BuisnessLogic
{
    public interface IExperienceLogic
    {
        Models.Experience AddExperience(string email, Models.Experience company);
        IEnumerable<Models.Experience> GetExperience();
        IEnumerable<Models.Experience> Get(string email);

        //Users AddUserDetails(Users r);
        Models.Experience RemoveExperience(string email);
        Models.Experience UpdateExperience(string Email, Experience r);
    }
}
