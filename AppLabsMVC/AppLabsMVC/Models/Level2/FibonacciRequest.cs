using System;
using System.ComponentModel.DataAnnotations;

namespace AppLabsMVC.Models.Level2
{
    public class FibonacciRequest
    {
        [Required(ErrorMessage = "Please enter number of terms")]
        [Range(1, Int32.MaxValue, ErrorMessage = "Value must be an integer greater than or equal to 1")]
        public int num { get; set; }
    }
}