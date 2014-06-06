using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AppLabs.DTOs.Level3
{
    public class Fractions
    {
        [Required, RegularExpression(@"^(\d+/\d+|\d+(\s\d+/\d+)?)$", ErrorMessage = "Please enter a numeric fraction in the form: a/b")]
        public string Input1 { get; set; }
        [Required, RegularExpression(@"^(\d+/\d+|\d+(\s\d+/\d+)?)$", ErrorMessage = "Please enter a numeric fraction in the form: a/b")]
        public string Input2 { get; set; }

        public int CommonDenom { get; set; }
    }
}
