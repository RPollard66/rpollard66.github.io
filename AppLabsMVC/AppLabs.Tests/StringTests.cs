using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppLabs.Operations.Level1;
using AppLabs.Operations.Level2;
using NUnit.Framework;

namespace AppLabs.Tests
{

    [TestFixture]
    public class StringTests
    {

        [Test]
        public void ReverseStringTest()
        {
            string testInput = "hello";
            
            var req = new FindStringReverseResult(testInput);
            string testOutput = req.Reverse();

            Assert.AreEqual("olleh", testOutput);
        }

        [Test]
        public void PalindromeTest()
        {
     
            var f = new PalindromeDetector();
            Assert.AreEqual(f.ReverseAndCheck("hello"), "hello is not a palindrome!");
      
            var t = new PalindromeDetector();
            Assert.AreEqual(t.ReverseAndCheck("radar").ToCharArray(), "radar is a palindrome!");
            
        }
    }
}
