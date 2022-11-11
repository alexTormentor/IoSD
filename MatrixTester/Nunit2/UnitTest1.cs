using NUnit.Framework;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Nunit2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddWithInc_2Plus3Inc1_Returned6()
        {
            // arrange 
            var calc = new Calculator();
            double arg1 = 2;
            double arg2 = 3;
            double expected = 6;
            // act
            double result = calc.AddWithInc(arg1, arg2);
            // assert            
            Assert.AreEqual(expected, result);
        }
    }
}