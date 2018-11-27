using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIS497FinalProject.Models
{
    public class Meal
    {
        public int mealID { get; set; }
        public string mealType { get; set; }
        public Food food { get; set; }
        public byte foodID { get; set; }
    }
}