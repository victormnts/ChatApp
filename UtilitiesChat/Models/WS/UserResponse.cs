﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesChat.Models.WS
{
    public class UserResponse
    {
        public string AccessToken { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int Id { get; set; }

    }
}
