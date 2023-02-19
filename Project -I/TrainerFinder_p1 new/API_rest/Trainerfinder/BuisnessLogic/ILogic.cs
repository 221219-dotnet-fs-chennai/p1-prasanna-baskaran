using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLogic
{
    public interface ILogic
    {
        Models.Users AddUserDetails(string Email, Models.Users userDetails);
        IEnumerable<Models.Users> GetUserDetails();
        Models.Users RemoveUserDetailsByUserId(string Email);
        Models.Users UpdateUserDetails(string Email, Models.Users r);
        Models.Users Get(string Email);
    }
}
