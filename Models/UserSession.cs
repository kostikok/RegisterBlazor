﻿using System.Security.Claims;

namespace werver.Models
{
    public class UserSession
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }

    }
}
