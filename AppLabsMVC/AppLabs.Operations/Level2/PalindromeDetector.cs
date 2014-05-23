using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppLabs.DTOs.Level2;

namespace AppLabs.Operations.Level2
{
    public class PalindromeDetector
    {
   
        private PalindromeResult word = new PalindromeResult();

        public string ReverseAndCheck(string input)
        {

            string original = input;
            word.Verdict=input.Replace(" ","");

            char[] charArray = word.Verdict.ToCharArray();
            
            Array.Reverse(charArray);

            var orderReversed = new string(charArray);

            if (word.Verdict == orderReversed)
            {
                return orderReversed+" is a palindrome!";
            }
            return original+" is not a palindrome!";
        }
    }
}
