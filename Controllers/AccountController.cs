using BuyItOnce.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BuyItOnce.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        public AccountController()
        {
        }

        [HttpPost("CreateAccount")]
        public IActionResult CreateAccount(UserAccount user)
        {
            return BadRequest();
        }
    }
}
