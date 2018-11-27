﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIS497FinalProject.Models
{
    public class Food
    {
        public int ID { get; set; }
        public string FoodName { get; set; }
        public double Calories { get; set; }
        public double Protein { get; set; }
        public double Fat { get; set; }
        public double Carbs { get; set; }
    }
}