using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UsersApp.Application.Interfaces.Services;
using UsersApp.Application.Models.Requests;
using UsersApp.Application.Models.Responses;

namespace UsersApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserAppService _userAppService;

        public UsersController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

        /// <summary>
        /// Create account of one user
        /// </summary>
        //[Authorize]
        [HttpPost]
        [Route("/create-account")]
        [ProducesResponseType(typeof(CreateAccountResponseDTO), StatusCodes.Status200OK)]
        public IActionResult CreateAccount(CreateAccountRequestDTO userDto)
        {
            return StatusCode(201, _userAppService.CreateAccount(userDto));
        }

        /// <summary>
        /// Authenticate a user 
        /// </summary>
        [HttpPost]
        [Route("/authenticate")]
        [ProducesResponseType(typeof(AuthenticateResponseDTO), StatusCodes.Status200OK)]
        public IActionResult Authenticate(AuthenticateRequestDTO userDto)
        {
            return StatusCode(200, _userAppService.Authenticate(userDto));

        }

        /// <summary>
        /// Reset the password
        /// </summary>
        [HttpPost]
        [Route("/reset-password")]
        [ProducesResponseType(typeof(ResetPasswordResponseDTO), StatusCodes.Status200OK)]
        public IActionResult ResetPassword(ResetPasswordRequestDTO userDto)
        {
            return StatusCode(200, _userAppService.ResetPassword(userDto));
        }
    }
}
