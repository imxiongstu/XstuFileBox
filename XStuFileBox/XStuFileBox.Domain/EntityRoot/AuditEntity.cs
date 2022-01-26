﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XStuFileBox.Domain.EntityRoot
{
    public class AuditEntity : Entity, IAuditEntity
    {
        public Guid? CreatorId { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime? DeletedTime { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public bool IsDeleted { get; set; }

        public AuditEntity()
        {
            CreationTime = DateTime.Now;
        }
    }
}
