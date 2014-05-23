using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppLabs.DTOs.Level2;

namespace AppLabs.Operations.Level2
{
    public class CharacterCounter
    {
        CountCharsResult _result=new CountCharsResult();

        public CountCharsResult GetResults(string text)
        {
            _result.Vowels = CountVowels(text);
            _result.Consonants = CountConsonants(text);
            _result.Spaces = CountSpaces(text);
            _result.Text = text;
            return _result;
        }

        private int CountVowels(string text)
        {
            // this finds lower case vowels
            var vowelArray = text.ToUpper().Where(c => "AEIOU".Contains(c))
                .ToArray();

            return vowelArray.Count();
        }

        private int CountConsonants(string text)
        {
            int countSpaces = text.Count(Char.IsWhiteSpace);
            var textArray = text.ToCharArray();
            var vowelArray = text.ToUpper().Where(c => "AEIOU".Contains(c))
                .ToArray();

            int letters = textArray.Count() - countSpaces;
            int cons = letters - vowelArray.Count();
            return cons;

        }

        private int CountSpaces(string text)
        {
            int countSpaces = text.Count(Char.IsWhiteSpace);
            return countSpaces;
        }
    }
}
