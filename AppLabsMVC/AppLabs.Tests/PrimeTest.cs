using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppLabs.Operations.Level2;
using NUnit.Framework;

namespace AppLabs.Tests
{
    [TestFixture]
    public class PrimeTest
    {
        [Test]
        public void CheckPrimeLogic()
        {
            var f=new FindNextPrime();
            var actual = f.NextPrime(13);
            Assert.AreEqual(17,actual);
        }
    }
}
