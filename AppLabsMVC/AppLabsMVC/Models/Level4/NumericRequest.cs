using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppLabsMVC.Models.Level4
{
    public class NumericRequest
    {

        [Required(ErrorMessage = "Please enter an integer to convert")]
        [Range(1, 999, ErrorMessage = "Value must be an integer between 1 and 999")]
        public int InputNum { get; set; }
    }

    
}