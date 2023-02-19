using BuisnessLogic;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace Trainerfinder.Controllers
{
  
        public class UserControler : ControllerBase
        {
            ILogic logic;
            //  IMemoryCache cache;
            public UserControler(ILogic logic) => this.logic = logic;
           
            [HttpGet("FetchUser/{email}")]
            public IActionResult Get([FromRoute] string email)
            {
            Log.Logger.Information("UserController.cs--line->17");
            try
                {
                    var userDetails = logic.Get(email);
                    if (userDetails != null)
                    {
                        return Ok(userDetails);
                    }
                    else
                    {
                        return BadRequest("No Details found");
                    }
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
            [HttpGet("FetchUser")]

            public IActionResult GetUserDetails()
            {
            Log.Logger.Information("UserController.cs--line->39");
            try
                {
                    var UserDetails = logic.GetUserDetails();
                    if (UserDetails != null)
                    {
                    Log.Logger.Information("UserController.cs--line->45");
                    return Ok(UserDetails);
                    }
                    else
                    {
                    Log.Logger.Information("UserController.cs--line->50");
                    return BadRequest("No Details found");
                    }
                }
                catch (Exception ex)
                {
                Log.Logger.Information("UserController.cs--line->56");
                return BadRequest(ex.Message);
                }
            }
            [HttpPost("AddTrainer")]
            public IActionResult Add(string Email, [FromBody] Models.Users userDetails)
            {
            Log.Logger.Information("UserController.cs--line->63");
            try
                {
                    var newuser = logic.AddUserDetails(Email, userDetails);
                    return Created("Add", newuser);
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
            [HttpDelete("Delete")]
            public IActionResult Delete([FromHeader] string Email)
            {
            Log.Logger.Information("UserController.cs--line->77");
            try
                {
                    var userDel = logic.RemoveUserDetailsByUserId(Email);
                    if (userDel != null)
                    {
                        return Ok(userDel);
                    }
                    else
                    {
                        return NotFound();
                    }

                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);

                }
            }
            [HttpPut("modify/{Email}")]

            public ActionResult Put([FromRoute] string Email, [FromBody] Models.Users t)
            {
            Log.Logger.Information("UserController.cs--line->101");
            return Ok(logic.UpdateUserDetails(Email, t));
            }
        }
    
}
