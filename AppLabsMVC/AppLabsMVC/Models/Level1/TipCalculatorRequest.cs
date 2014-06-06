using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppLabsMVC.Models.Level1
{
    public class TipCalculatorRequest
    {
        [Required(ErrorMessage = "Enter the meal amount")]
        [Range(0, Double.MaxValue, ErrorMessage = "The meal amount must be greater than zero")]
        public decimal? MealTotal { get; set; }

        [Required(ErrorMessage = "Enter the tip percent")]
        [Range(0, 100, ErrorMessage = "The tip percent must be between 0 and 100")]
        public decimal? TipPercent { get; set; }
    }
}