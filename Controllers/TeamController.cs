using Microsoft.AspNetCore.Mvc;

namespace YourNamespace.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        [HttpGet("GetTeamMembers")]
        public IActionResult GetTeamMembers()
        {
            return Ok(new { /* Your data */ });
        }
    }
}
