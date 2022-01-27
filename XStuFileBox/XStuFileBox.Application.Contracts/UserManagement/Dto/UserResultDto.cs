using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XStuFileBox.Application.Contracts.UserManagement.Dto
{
    public class UserResultDto
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string NickName { get; set; }
        public DateTime? BirthDay { get; set; }
    }
}
