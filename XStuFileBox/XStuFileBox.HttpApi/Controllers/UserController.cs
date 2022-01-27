using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using XStuFileBox.Application.Contracts.UserManagement;
using XStuFileBox.Application.Contracts.UserManagement.Dto;

namespace XStuFileBox.HttpApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("create-user")]
        public async Task<UserResultDto> CreateUserAsync(UserCreateDto dto)
        {
            return await _userService.CreateUserAsync(dto);
        }
    }
}
