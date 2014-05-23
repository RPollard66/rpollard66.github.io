using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AppLabs.DTOs.Level1;

namespace AppLabs.Operations.Level1
{
    public class FlooringCalculator
    {
        private FlooringValues _Values;
        private decimal _totalCost;
       
        public FlooringCalculator(FlooringValues values)
        {
            _Values = values;
        }

        public decimal FindCost()
        {
            _totalCost =_Values.Length*_Values.Width*_Values.CostPerSqFoot;
            return _totalCost;
        }

        public decimal FindLaborCost()
        {
            int area = _Values.Length*_Values.Width;
            decimal cost = area/(decimal)4.3;
            return cost;
        }


    }
}
