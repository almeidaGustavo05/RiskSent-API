using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using RiskRent.Domain.Enums;

namespace RiskRent.Domain.Entities
{
    public class User : BaseEntity
    {
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string? Phone { get; set; }
        public UserRole Role { get; set; } = UserRole.Broker;
        public bool IsActive { get; set; } = true;
        public DateTime? LastLoginAt { get; set; }
    }
}