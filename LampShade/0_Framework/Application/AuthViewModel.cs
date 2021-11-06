﻿using System.Collections.Generic;

namespace _0_Framework.Application
{
    public class AuthViewModel
    {
        public AuthViewModel(long id, long roleId, string fullname, string username , List<int> permissions)
        {
            Id = id;
            RoleId = roleId;
            Fullname = fullname;
            Username = username;
            Permissions = permissions;
        }

        public AuthViewModel() { }
        public long Id { get; set; }
        public long RoleId { get; set; }
        public string Role { get; set; }
        public string Fullname { get; set; }
        public string Username { get; set; }
        public List<int> Permissions { get; set; }
    }
}