using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLabs.DTOs.Level2
{
    public class CountCharRequest
    {
        [Required(ErrorMessage = "You must enter a word or words separated by spaces")]
        public string UserInput { get; set; }
    }
}
