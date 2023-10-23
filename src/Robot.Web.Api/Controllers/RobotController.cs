using Microsoft.AspNetCore.Mvc;
using Robot.Model;
using Robot.Service;

namespace Robot.Web.Api.Controllers
{
    [ApiController]
    [Route("tibber-developer-test")]
    public class RobotController : ControllerBase
    {
        private IRobotService _robotService;
        public RobotController(IRobotService robotService)
        {
            _robotService = robotService;
        }

        [HttpPost("enter-path")]
        public IActionResult EnterPath([FromBody] RobotCommandRequest commandRequest)
        {
            var createdRecord = _robotService.ExecutePath(commandRequest);

            return Ok(createdRecord);
        }
    }
}