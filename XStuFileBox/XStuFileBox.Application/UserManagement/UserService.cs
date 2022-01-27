using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XStuFileBox.Application.Contracts.UserManagement;
using XStuFileBox.Application.Contracts.UserManagement.Dto;
using XStuFileBox.Domain.Entitys;
using XStuFileBox.Domain.Repositorys;

namespace XStuFileBox.Application.UserManagement
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _userRepository;


        public UserService(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserResultDto> CreateUserAsync(UserCreateDto dto)
        {
            User user = new User();
            user.Id = Guid.NewGuid();
            await _userRepository.InsertAsync(user);
            return new UserResultDto();
        }
    }
}
