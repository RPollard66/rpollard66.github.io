using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLabs.DTOs.Level2
{
    public class PrimeRequest
    {
        [Required(ErrorMessage = "Please enter an integer")]
        [Range(1, Int32.MaxValue, ErrorMessage = "Value must be an integer greater than or equal to 1")]
        public int Number { get; set; }
    }
}
