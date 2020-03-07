﻿using System.ComponentModel.DataAnnotations;

namespace PPR.Data.Entities {
    public class UserRole {
        [Key]
        public int UserRoleId { get; set; }
        public int UserId { get; set; }
        public short RoleId { get; set; }

        public virtual Role Role { get; set; }
    }
}