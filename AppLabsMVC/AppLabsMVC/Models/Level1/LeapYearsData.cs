using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Web;

namespace AppLabsMVC.Models.Level1
{
    public class LeapYearsData
    {
        //if i make them nullable it throws errors on controller in for loop

        [Required(ErrorMessage = "Enter the beginning year")]
        [Range(0,2014)]
        public int? BeginYear { get; set; }

        [Required(ErrorMessage = "Enter the ending year")]
        [Range(0, 2014)]
        public int? EndYear { get; set; }
    }
}