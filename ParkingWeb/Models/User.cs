﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ParkingWeb.Model
{
    public partial class User
    {
        public long Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
