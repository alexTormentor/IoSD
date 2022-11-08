using MatrixTester;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Create_1x1()
        {
            double[,] array = { { 1 } };
            Matrix m = new Matrix(array);
            Assert.Equal(array, m.Params);
            Assert.Equal(1, m.Size);

        }

        [Fact]
        public void Create2x2()
        {
            double[,] array = { { 1, 1 }, { 1, 1} };
            Matrix m = new Matrix(array);
            Assert.Equal(array, m.Params);
            Assert.Equal(2, m.Size);
        }

        [Fact]
        public void Copy()
        {
            double[,] array = { { 1, 1 }, { 1, 1 } };
            Matrix m1 = new Matrix(array);
            Matrix m2 = new Matrix(m1);
            Assert.Equal(array, m1.Params);
            Assert.Equal(2, m2.Size);
        }

        [Fact]
        public void sum()
        {
            Matrix m1 = new Matrix(new double[,] { { 1, 1 }, { 1, 1 } });
            Matrix m2 = new Matrix(m1);
            Matrix summa = m1 + m2;
            Assert.Equal(new double[,] { { 2, 2 }, { 2, 2 } }, summa.Params);
            Assert.Equal(2, m2.Size);
        }

        [Fact]
        public void sub()
        {
            Matrix m1 = new Matrix(new double[,] { { 2 } });
            Matrix m2 = new Matrix(new double[,] { { 1 } });
            Matrix subs = m1 - m2;
            Assert.Equal(new double[,] { { 1 } }, subs.Params);
            Assert.Equal(1, subs.Size);
        }

        [Fact]
        public void zero()
        {
            double[,] array = { { 0 } };
            Matrix m = new Matrix(array);
            Assert.NotNull(m);
        }
    }
}
