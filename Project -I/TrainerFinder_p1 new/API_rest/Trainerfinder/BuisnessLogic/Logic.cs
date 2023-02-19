
using AutoMapper;
using FluentAPI;

using Microsoft.Azure.Documents;
using Models;
using Serilog;
using Trainerfinder.Entities;

namespace BuisnessLogic
{
    public class Logic : ILogic
    {
        Validation v;
        FluentAPI.IRepo<Trainerfinder.Entities.User> Repo;
         public Logic(Validation id,FluentAPI.IRepo<Trainerfinder.Entities.User> users)
        {
            Log.Logger.Information("Logic.cs--line->18");
            v = id;
            Repo = users;
        }
        public Models.Users AddUserDetails(string Email, Models.Users users)
        {
            Log.Logger.Information("Logic.cs--line->24");
            users.UserId=v.Pid(Email);
            return Mapper.Map(Repo.Add(Mapper.Map(users)));
        }

        public Models.Users Get(string Email)
        {
            Log.Logger.Information("Logic.cs--line->31");
            return Mapper.Map(Repo.Get(Email));
        }

        public IEnumerable<Models.Users> GetUserDetails()
        {
            Log.Logger.Information("Logic.cs--line->37");
            return Mapper.Map(Repo.GetUserDetails());
        }

        public Models.Users RemoveUserDetailsByUserId(string Email)
        {
            Log.Logger.Information("Logic.cs--line->43");
            var deletedUserDetails = Repo.RemoveUserDetails(Email);
            if (deletedUserDetails != null)
                return Mapper.Map(deletedUserDetails);
            else
                return null;
        }

        public Users UpdateUserDetails(string Email, Users r)
        {
            Log.Logger.Information("Logic.cs--line->53");
            var userDetails = (from rst in Repo.GetUserDetails()
                               where rst.UserId == r.UserId
                               select rst).FirstOrDefault();
            if (userDetails != null)
            {
                userDetails.UserId = r.UserId;
                userDetails.Username=r.Username;
                userDetails.Gender = r.Gender;
                userDetails.Email = r.Email;
                userDetails.Pasword = r.Pasword;
                userDetails.Location = r.Location;
                userDetails.Aboutme = r.Aboutme;
                userDetails.Phoneno = r.Phoneno;
                userDetails.Website = r.Website;

                userDetails = Repo.UpdateUserDetails(userDetails);
            }
            return Mapper.Map(userDetails);
        }
    }
}