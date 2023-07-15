using Microsoft.AspNetCore.Mvc;

namespace samir_agrawal_versioncontrol.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NameController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetName()
        {
            string name = "Samir Agrawal";

            return Ok(new { name });
        }
    }
}


