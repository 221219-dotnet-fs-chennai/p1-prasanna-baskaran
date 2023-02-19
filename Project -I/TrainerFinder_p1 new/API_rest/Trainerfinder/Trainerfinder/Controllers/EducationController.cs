using BuisnessLogic;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace Trainerfinder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducationController : ControllerBase
    {
        EducationLogic logic1;
        public EducationController(EducationLogic logic1) => this.logic1 = logic1;
        [HttpGet("FetchUser/{email}")]
        public IActionResult Get([FromRoute] string email)
        {
            Log.Logger.Information("EducationController.cs--line->16");
            try
            {
                var education = logic1.Get(email);
                if (education != null)
                {
                    return Ok(education);
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
        [HttpGet("FetchEducation")]
        public IActionResult GetEducationDetails()
        {
            Log.Logger.Information("EducationController.cs--line->37");
            try
            {
                var Education = logic1.GetEducationDetails();
                return Ok(Education);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost("AddEducation")]
        public IActionResult Add(string Email, [FromBody] Models.Education education)
        {
            Log.Logger.Information("EducationController.cs--line->51");
            //try
            //{
            var newuser = logic1.AddEduDetails(Email, education);
            return Created("Add", newuser);
            //}
            //catch (Exception ex)
            //{
            //    return BadRequest(ex.Message);
            //}
        }
        [HttpDelete("Delete")]
        public IActionResult Delete([FromHeader] string Email)
        {
            Log.Logger.Information("EducationController.cs--line->65");
            try
            {
                var userDel = logic1.RemoveEducation(Email);
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
        [HttpPut("modify/{Educationid}")]

        public ActionResult Put([FromRoute] string Email, [FromBody] Models.Education t)
        {
            Log.Logger.Information("EducationController.cs--line->89");
            return Ok(logic1.UpdateEducationDetails(Email, t));
        }
    }
}
