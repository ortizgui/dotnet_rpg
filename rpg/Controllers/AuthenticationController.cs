using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using rpg.Data;
using rpg.Dtos.User;
using rpg.Models;

namespace rpg.Controllers
{
    [ApiController]
    [Route("auth")]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthRepository _authRepository;

        public AuthenticationController(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(UserLoginDto request)
        {
            ServiceResponse<string> response = await _authRepository.Login(
                request.Username, request.Password);

            if(!response.Success) {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(UserRegisterDto request)
        {
            ServiceResponse<int> response = await _authRepository.Register(
                new User { Username = request.Username }, request.Password);
                
            if(!response.Success) {
                return BadRequest(response);
            }
            return Ok(response);
        }
    }
}