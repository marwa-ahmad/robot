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
            var execusionModel = _robotService.ExecutePath(commandRequest);

            //For post method since data is will be created, then response code will be Created(202) response and a resourceid
            return Created($"Request.Path/{execusionModel.Id}", execusionModel);
        }
    }
}