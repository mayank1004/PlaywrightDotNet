﻿using System;
using RestSharp;

namespace E2ETestCSharp.Model.Auth
{
    public class UserManagement
    {
        public UserManagement()
        {
        }
        public User user { get; set; }

        public UserManagement(User user)
        {
            this.user = user;
        }
    }
}
