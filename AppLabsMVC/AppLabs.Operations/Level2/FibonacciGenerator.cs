using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppLabs.DTOs.Level2;

namespace AppLabs.Operations.Level2
{
    public class FibonacciGenerator
    {
        private Fibonacci numbers = new Fibonacci();

        public List<int> Generate(int numPlaces)
        {
            
            //this sets the first two values in the sequence to 1
            numbers.Sequence.Add(1);
            numbers.Sequence.Add(1);

            for (int i = 0; i < numPlaces-2; i++)
            {
                numbers.Sequence.Add(numbers.Sequence.ElementAt(i)+numbers.Sequence.ElementAt(i+1));
            }

            return numbers.Sequence;
        }
    }
}
