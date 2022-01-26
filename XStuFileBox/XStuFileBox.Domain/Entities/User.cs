using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XStuFileBox.Domain.EntityRoot;

namespace XStuFileBox.Domain.Entitys
{
    public class User : AuditEntity
    {
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string NickName { get; set; }
        public DateTime? BirthDay { get; set; }
    }
}
