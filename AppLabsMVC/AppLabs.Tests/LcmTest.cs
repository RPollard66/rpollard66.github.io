using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppLabs.Operations.Level3;
using NUnit.Framework;

namespace AppLabs.Tests
{
    [TestFixture]
    public class LcmTest
    {
        [Test]
        public void FindLcm()
        {
            LcmFinder f=new LcmFinder();

            string a = "11/12";
            string b = "13/5";

            Assert.AreEqual(60,f.Execute(a,b));
        }
    }
}
