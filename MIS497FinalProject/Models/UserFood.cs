using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MIS497FinalProject.Models
{
    public class UserFood
    {
        public int ID { get; set; }
        public int userID { get; set; }
        [Required]
        [StringLength(100)]
        public string FoodName { get; set; }
        [Required]
        public double Calories { get; set; }
        public double Protein { get; set; }
        public double Fat { get; set; }
        public double Carbs { get; set; }
    }
}