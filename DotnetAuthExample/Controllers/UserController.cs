using DotnetAuthExample.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DotnetAuthExample.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserServices _iUserServices;

        public UserController(IUserServices iUserServices)
        {
            _iUserServices = iUserServices;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            var result = _iUserServices.GetUserService();
            return StatusCode(result.Code, result);
        }

    }
}
