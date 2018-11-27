using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIS497FinalProject.Models
{
    //Calculations (BMI, weight change, etc...)
    public class Health
    {
        public int ID { get; set; }
        public double BMI { get; set; }
        public double WeightChange { get; set; }
         
 
        public void BMICalc(User Weight, User Height)
        {
            BMI = (703 * (Weight / (Math.Pow(Height,2)));
            
        }
    }
}