using NUnit.Framework;

using System;

namespace TestProject1
{
    public class UnitTest1
    {
        [Test]
        public void matrixCreate()
        {
            double[,] array = { { 100 } };
            Matrix m = new Matrix(array);
            Assert.AreEqual(array, m.Params);
            Assert.AreEqual(1, m.Size);

        }

        [Test]
        public void matrixCreate2()
        {
            double[,] array = { 
                { 100, 100 }, 
                { 200, 200 } 
            };
            Matrix m = new Matrix(array);
            Assert.AreEqual(array, m.Params);
            Assert.AreEqual(2, m.Size);
        }

        [Test]
        public void matrixCopy()
        {
            double[,] array = { { 100, 250 }, { 350, 1337 } };
            Matrix m1 = new Matrix(array);
            Matrix m2 = new Matrix(m1);
            Assert.AreEqual(array, m1.Params);
            Assert.AreEqual(2, m2.Size);
        }

        [Test]
        public void matrixSum()
        {
            Matrix m1 = new Matrix(new double[,] { { 320, 100 }, { 10, 15 } });
            Matrix m2 = new Matrix(m1);
            Matrix summa = m1 + m2;
            Assert.AreEqual(new double[,] { { 640, 200 }, { 20, 30 } }, summa.Params);
            Assert.AreEqual(2, m2.Size);
        }

        [Test]
        public void matrixSub()
        {
            Matrix m1 = new Matrix(new double[,] { { 10 } });
            Matrix m2 = new Matrix(new double[,] { { 5 } });
            Matrix subs = m1 - m2;
            Assert.AreEqual(new double[,] { { 5 } }, subs.Params);
            Assert.AreEqual(1, subs.Size);
        }

        [Test]
        public void matrixZeroException()
        {
            // arrange 
            var calc = new Calculator(); // так тоже монжо объ€вл€ть
            double arg1 = 4;
            double arg2 = 0;
            Assert.Throws<System.DivideByZeroException>(() => calc.Div(arg1, arg2));
        }
        [Test]
        public void calcAdd()
        {
            // arrange 
            var calc = new Calculator();
            double arg1 = 2;
            double arg2 = 3;
            double expected = 6;
            // act
            double result = calc.Add(arg1, arg2);
            // assert            
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void calcDiv()
        {
            // arrange 
            var calc = new Calculator();
            double arg1 = 4;
            double arg2 = 2;
            double expected = 2;
            // act
            double result = calc.Div(arg1, arg2);
            // assert            
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void matrixSub3()
        {
            Matrix a = new Matrix(new double[,] { { 7, 5, 3 }, { -1, 0, 2 }, { 10, 21, 8 } });
            Matrix b = new Matrix(new double[,] { { 7, 4, 3 }, { 1, 1, 1 }, { 1, 1, 1 } });
            Matrix c = a - b;

            Assert.AreEqual(new double[,] { { 0, 1, 0 }, { -2, -1, 1 }, { 9, 20, 7 } }, c.Params);
            Assert.AreEqual(3, c.Size);
        }

        [Test]
        public void matrixSub2()
        {
            Matrix a = new Matrix(new double[,] { { 32, 12 }, { 1, 5 } });
            Matrix b = new Matrix(new double[,] { { 14, 6 }, { 8, 8 } });
            Matrix c = a - b;

            Assert.AreEqual(new double[,] { { 18, 6 }, { -7, -3 } }, c.Params);
            Assert.AreEqual(2, c.Size);
        }

        [Test]
        public void matrixCopy2()
        {
            double[,] array = { { 1, 1 }, { 1, 1 } };
            Matrix a = new Matrix(array);
            Matrix b = new Matrix(a);
            Assert.AreEqual(array, b.Params);
            Assert.AreEqual(2, b.Size);
        }

        [Test]
        public void matrixDiv()
        {
            Matrix m1 = new Matrix(new double[,] { { 10 } });
            Matrix m2 = new Matrix(new double[,] { { 5 } });
            Matrix subs = m1 / m2;
            Assert.AreEqual(new double[,] { { 2 } }, subs.Params);
            Assert.AreEqual(1, subs.Size);
        }

        [Test]
        public void matrixUmn()
        {
            Matrix m1 = new Matrix(new double[,] { { 10 } });
            Matrix m2 = new Matrix(new double[,] { { 5 } });
            Matrix subs = m1 * m2;
            Assert.AreEqual(new double[,] { { 50 } }, subs.Params);
            Assert.AreEqual(1, subs.Size);
        }
    }
}
