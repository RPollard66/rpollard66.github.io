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
        public decimal? MealTotal { get; set; }

        [Required(ErrorMessage = "Enter the tip percent")]
        [Range(0, 100)]
        public decimal? TipPercent { get; set; }
    }
}