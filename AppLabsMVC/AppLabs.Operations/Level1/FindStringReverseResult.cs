using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLabs.Operations.Level1
{
    public class FindStringReverseResult
    {
        private string _UserInput;
        
        public FindStringReverseResult(string userInput)
        {
            _UserInput = userInput;
        }

        

        public string Reverse()
        {
            char[] charArray = _UserInput.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
