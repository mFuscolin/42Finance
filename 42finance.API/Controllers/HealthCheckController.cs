using Microsoft.AspNetCore.Mvc;

namespace _42finance.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthCheckController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {         
            return Ok();
        }
    }
}
