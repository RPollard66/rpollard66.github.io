using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppLabs.DTOs.Level1;

namespace AppLabs.Operations.Level1
{
    public class TipCalculator
    {
        public TipCalculationResult CalculateTip(TipCalculation data)
        {
            var result = new TipCalculationResult();
            result.MealTotal = data.MealTotal;
            result.TipPercent = data.TipPercent;
            result.TipAmount = result.MealTotal * result.TipPercent;
            result.TotalAmount = result.TipAmount + result.MealTotal;

            return result;
        }
    }
}
