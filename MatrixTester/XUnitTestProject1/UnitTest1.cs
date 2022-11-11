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
        [Fact]
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
            Assert.Equal(expected, result);
        }
        [Fact]
        public void Div_4Div2_Returned2()
        {
            // arrange 
            var calc = new Calculator();
            double arg1 = 4;
            double arg2 = 2;
            double expected = 2;
            // act
            double result = calc.Div(arg1, arg2);
            // assert            
            Assert.Equal(expected, result);
        }
        [Fact]
        public void Div_4Div0_ZeroDivException()
        {


            // arrange 
            var calc = new Calculator();
            double arg1 = 4;
            double arg2 = 0;
            // act
            double result = calc.Div(arg1, arg2);
            Assert.NotNull(result);            
        }
    }
}
