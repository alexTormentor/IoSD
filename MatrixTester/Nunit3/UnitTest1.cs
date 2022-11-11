using NUnit.Framework;

namespace Nunit3
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

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