using Microsoft.AspNetCore.Mvc;
using rpg.Models;

namespace rpg.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private static Character knight = new Character();

        public IActionResult Get()
        {
            return Ok(knight);
        }
    }
}