﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIS497FinalProject.Models
{
    public class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Birthdate { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }

    }
}