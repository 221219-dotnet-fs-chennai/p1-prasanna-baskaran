using BuisnessLogic;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace Trainerfinder.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class SkillController : ControllerBase
    {
        ISkillLogic skilllogic;
        public SkillController(ISkillLogic skilllogic) => this.skilllogic = skilllogic;
        [HttpGet("FetchUser/{email}")]
        public IActionResult Get([FromRoute] string email)
        {
            Log.Logger.Information("SkillController.cs--line->17");
            try
            {
                var skill = skilllogic.Get(email);
                if (skill != null)
                {
                    return Ok(skill);
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
        [HttpGet("FetchSkills")]
        public IActionResult GetSkills()
        {
            Log.Logger.Information("SkillController.cs--line->38");
            try
            {
                var Skills = skilllogic.GetSkills();
                return Ok(Skills);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public IActionResult Add(string Email, [FromBody] Models.Skill skills)
        {
            Log.Logger.Information("SkillController.cs--line->52");
            //try
            //{
            var newuser = skilllogic.AddSkills(Email, skills);
            return Created("Add", newuser);
        }
        [HttpDelete("DeleteSkills")]
        public IActionResult Delete([FromHeader] string Email)
        {
            Log.Logger.Information("SkillController.cs--line->60");
            try
            {
                var userDel = skilllogic.RemoveSkills(Email);
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

        public ActionResult Put([FromRoute] string Email, [FromBody] Models.Skill t)
        {
            Log.Logger.Information("SkillController.cs--line->85");
            return Ok(skilllogic.UpdateSkills(Email, t));
        }
    }
}
