using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppLabs.DTOs.Level2;
using AppLabs.Operations.Level2;
using NUnit.Framework;

namespace AppLabs.Tests
{
    [TestFixture]
    public class FibonacciTests
    {
        [Test]
        public void FiboTest()
        {
            FibonacciGenerator f=new FibonacciGenerator();
            Fibonacci fib=new Fibonacci();

            fib.Sequence = f.Generate(5);

            List<int> exp = new List<int>(){1,1,2,3,5};

            Assert.AreEqual(exp,fib.Sequence);

        }

    }
}
