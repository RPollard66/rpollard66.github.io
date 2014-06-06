using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppLabsMVC.Models.Level1
{
    public class StringRequest
    {
        [Required(ErrorMessage = "Please input something to reverse!")]
        public string StringToReverse { get; set; }

    }
}