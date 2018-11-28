using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MIS497FinalProject.Models
{
    public class Log
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "Select a data")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MMM/yyyy}")]
        public DateTime LogDate { get; set; }
    }
}