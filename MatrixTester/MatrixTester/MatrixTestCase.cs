using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MatrixTester
{
    delegate void testDelegate (string m);

    [TestFixture]
    class MatrixTestCase
    {
        [Test]
        public void Create_1x1()
        {
            double[,] array = {{1}};
            Matrix m = new Matrix(array);
            Assert.AreEqual(array, m.Args);
            Assert.AreEqual(1, m.Size);
        }
    }
}
