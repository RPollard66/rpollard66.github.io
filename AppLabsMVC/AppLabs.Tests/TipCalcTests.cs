using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppLabs.DTOs.Level1;
using AppLabs.Operations.Level1;
using NUnit.Framework;

namespace AppLabs.Tests
{
    [TestFixture]
    public class TipCalcTests
    {
        [Test]
        public void CalculateTipTest()
        {
            var calculator = new TipCalculator();

            var request = new TipCalculation { MealTotal = 100, TipPercent = .1M };

            var result = calculator.CalculateTip(request);

            Assert.AreEqual(result.TipAmount, 10M);
            Assert.AreEqual(result.TotalAmount, 110M);
        }
    }
}
