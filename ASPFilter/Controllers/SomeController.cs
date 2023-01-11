using Microsoft.AspNetCore.Mvc;

namespace ASPFilter.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SomeController : ControllerBase
    {
        private readonly ILogger<SomeController> _logger;

        public SomeController(ILogger<SomeController> logger)
        {
            _logger = logger;
        }

        [ServiceFilter(typeof(LogActionFilter))]
        [HttpPost(Name = "PostName")]
        public IActionResult Post(string firstName, string lastName)
        {

            return Ok();
        }
    }
}