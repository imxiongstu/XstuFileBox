using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XStuFileBox.Application.Contracts.UserManagement.Dto;

namespace XStuFileBox.Application.Contracts.UserManagement
{
    public interface IUserService
    {
        Task<UserResultDto> CreateUserAsync(UserCreateDto dto);
    }
}
