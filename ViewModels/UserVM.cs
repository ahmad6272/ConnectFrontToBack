﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConnectFrontToBack.ViewModels
{
    public class UserVM
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
    }
}
