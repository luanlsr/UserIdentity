using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UsersApp.Application.Interfaces.Services;
using UsersApp.Application.Models.Responses;

namespace UsersApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : BaseController
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        //[Authorize]
        [HttpGet("get-all")]
        [ProducesResponseType(typeof(List<UsersResponseDTO>), StatusCodes.Status200OK)]
        public IActionResult GetUsers()
        {
            return StatusCode(200, _userService.GetAll());
        }
    }
}
