﻿using WebAppGB_ForDocker.Models;

namespace WebAppGB_ForDocker.Dtos
{
    public class UserDto
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public UserRoleDto Role { get; set; }
    }
}
