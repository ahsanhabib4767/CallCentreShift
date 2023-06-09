﻿using System;
using System.Collections.Generic;

namespace OBL.BIC.Models
{
    public partial class User
    {
        public User()
        {
            UserClaims = new HashSet<UserClaim>();
            UserLogins = new HashSet<UserLogin>();
            UserTokens = new HashSet<UserToken>();
            Roles = new HashSet<Role>();
        }

        public string Id { get; set; } = null!;
        public string? UserName { get; set; }
        public string? NormalizedUserName { get; set; }
        public string? Email { get; set; }
        public string? NormalizedEmail { get; set; }
        public bool? EmailConfirmed { get; set; }
        public string? PasswordHash { get; set; }
        public string? SecurityStamp { get; set; }
        public string? ConcurrencyStamp { get; set; }
        public string? PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTimeOffset? LockoutEnd { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public byte[]? ProfilePicture { get; set; }
        public int UsernameChangeLimit { get; set; }
        public string? EmployeeId { get; set; }
        public string? BranchCode { get; set; }
        public string? UserType { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<UserClaim> UserClaims { get; set; }
        public virtual ICollection<UserLogin> UserLogins { get; set; }
        public virtual ICollection<UserToken> UserTokens { get; set; }

        public virtual ICollection<Role> Roles { get; set; }
    }
}
