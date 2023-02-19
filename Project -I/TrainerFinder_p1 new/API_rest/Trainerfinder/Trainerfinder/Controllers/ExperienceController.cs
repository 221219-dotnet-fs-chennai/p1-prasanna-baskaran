using BuisnessLogic;
using FluentAPI;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Trainerfinder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExperienceController : ControllerBase
    {
       
        IExperienceLogic companylogic;
        public ExperienceController(IExperienceLogic companylogic) => this.companylogic = companylogic;
        [HttpGet("FetchUser/{email}")]
        public IActionResult Get([FromRoute] string email)
        {
            Log.Logger.Information("ExperienceController.cs--line->18");
            try
            {
                var company = companylogic.Get(email);
                if (company != null)
                {
                    return Ok(company);
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
        [HttpGet("FetchExperience")]
        public IActionResult Get()
        {
            Log.Logger.Information("ExperienceController.cs--line->39");
            try
            {
                var Company = companylogic.GetExperience();
                return Ok(Company);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public IActionResult Add(string Email, [FromBody] Models.Experience company)
        {
            Log.Logger.Information("ExperienceController.cs--line->53");
            //try
            //{
            var newuser = companylogic.AddExperience(Email, company);
            return Created("Add", newuser);
        }
        [HttpDelete("DeleteExperience/{Email}")]
        public IActionResult Delete([FromHeader] string Email)
        {
            Log.Logger.Information("ExperienceController.cs--line->62");
            try
            {
                var userDel = companylogic.RemoveExperience(Email);
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
        [HttpPut("modify/{CompanyEmail}")]

        public ActionResult Put([FromRoute] string Email, [FromBody] Models.Experience t)
        {
            Log.Logger.Information("ExperienceController.cs--line->86");
            return Ok(companylogic.RemoveExperience(Email));
        }
    }
}
