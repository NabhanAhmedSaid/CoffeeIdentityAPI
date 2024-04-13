using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeIdentityAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CoffeeController : ControllerBase
    {
        [HttpGet("Info")]

        public string Info()
        {
            return "Welcome to Coffee API";
        }
    }
}
