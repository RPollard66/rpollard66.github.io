using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppLabsMVC.Models.Level4
{
    public class PascalRequest
    {
        [Required(ErrorMessage = "Please enter number of rows")]
        [Range(1, Int32.MaxValue, ErrorMessage = "Value must be an integer greater than or equal to 1")]
        public int PascalInput { get; set; }
    }
}