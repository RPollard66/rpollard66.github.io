using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppLabs.DTOs.Level4;

namespace AppLabs.Operations.Level4
{
    public class PascalCalculator
    {
        private Triangle _triangle = new Triangle();

        // this creates jagged arrays that form the triangle
        public int[][] Calculate(int numRows)
        {
            _triangle.Elements = new int[numRows][];

            for (int i = 0; i < numRows; i++)
            {
                _triangle.Elements[i] = new int[i + 1];
            }

            for (int n = 0; n < numRows; n++)
            {
                for (int r = 0; r <= n; r++)
                {
                    _triangle.Elements[n][r] = Factorial(n) / (Factorial(r) * Factorial(n - r));
                }
            }

            return _triangle.Elements;
        }

        // this finds the factorial of a number
        private int Factorial(int n)
        {

            int factorial = n;
            if (n == 0)
                return 1;

            for (int i = 1; i < (n - 1); i++)
            {
                factorial = factorial * (n - i);
            }


            return factorial;
        }


    }
}
