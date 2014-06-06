using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLabs.DTOs.Level1
{
    public class FlooringValues
    {
        [Required(ErrorMessage = "Please enter a valid width")]
        [Range(0, Int32.MaxValue, ErrorMessage = "Width can not be negative")]
        public int Width { get; set; }

        [Required(ErrorMessage = "Please enter a valid length")]
        [Range(0, Int32.MaxValue, ErrorMessage = "Length can not be negative")]
        public int Length { get; set; }

        [Required(ErrorMessage = "Please enter a valid cost per sq ft")]
        [Range(0, Double.MaxValue, ErrorMessage = "Cost per sq ft can not be negative")]
        public decimal CostPerSqFoot { get; set; }
        
    }
}
