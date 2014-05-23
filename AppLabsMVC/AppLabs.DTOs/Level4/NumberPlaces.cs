using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLabs.DTOs.Level4
{
    public class NumberPlaces
    {
        public double Huns { get; set; }
        public double Tens { get; set; }
        public double Ones { get; set; }
    }

    

    public class WordRepo
    {
        public string[] BasicWords = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        public string[] TeenWords = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        public string[] EndsInYWords = { "", "", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
       
    }
}
