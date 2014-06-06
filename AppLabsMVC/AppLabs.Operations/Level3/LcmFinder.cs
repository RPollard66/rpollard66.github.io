using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using AppLabs.DTOs.Level3;

namespace AppLabs.Operations.Level3
{
    public class LcmFinder
    {
        private int _result;

        public int Execute(string a, string b)
        {
            Splitter(a, b);
            return _result;
        }

        
        private void Splitter(string a, string b)
        {
            string[] first = a.Split('/');
            string[] second = b.Split('/');

            string denom1 = first[1];
            string denom2 = second[1];

            ConvertToNums(denom1, denom2);
        }

        private void ConvertToNums(string a, string b)
        {
            int denom1 = int.Parse(a);
            int denom2 = int.Parse(b);

           CommonDenom(denom1, denom2);
        }

        private void CommonDenom(int a, int b)
        {
            int num1, num2;

            if (a > b)
            {
                num1 = a;
                num2 = b;
            }
            else
            {
                num1 = b;
                num2 = a;
            }

            for (int i = 1; i <= num2; i++)
            {
                if ((num1 * i) % num2 == 0)
                {
                    _result = i * num1;
                }
            }

        }

    }
}
