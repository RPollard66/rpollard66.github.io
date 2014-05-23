using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppLabs.DTOs.Level2;

namespace AppLabs.Operations.Level2
{
    public class FindNextPrime
    {
        
        public int NextPrime(int n)
        {
            // this will run until we hit the next prime
            // once we do, it returns the value
            while (true)
            {
                n++;
                bool stop = IsItPrime(n);
                if(stop)
                    break;              
            }
            return n;
        }

        private bool IsItPrime(int n)
        {
            //check for evenness
            if (n % 2 == 0)
            {
                if (n == 2)
                {
                    return true;
                }
                return false;
            }
            //don't need to check past the square root
            int max = (int)Math.Sqrt(n);
            for (int i = 3; i <= max; i += 2)
            {
                if ((n % i) == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

