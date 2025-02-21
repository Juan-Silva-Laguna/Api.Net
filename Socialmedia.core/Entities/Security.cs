﻿using Socialmedia.core.Entities;
using SocialMedia.Core.Enumerations;

namespace SocialMedia.core.Entities
{
    public class Security : BaseEntity
    {
        public string User { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public RoleType Role { get; set; }
    }
}