using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MatrixTester
{
    class Matrix
    {
        public double[,] Args { get; set; }
        public int Size { get; set; }

        public Matrix(double[,] x)
        {
            if (x == null) throw new ArgumentNullException("Матрица не должна быть пустой!");
            int Row = x.GetLength(0); int Col = x.GetLength(1);
            if (Row != Col) throw new ArgumentException("Матрица должна быть квадратной!");
            Size = Row; Args = new double[Row, Col];
            for (int i = 0; i < Size; i++)
                for (int j = 0; j < Size; j++)
                    Args[i, j] = x[i, j];
        }

        public Matrix(Matrix other)
        {
            this.Size = other.Size;
            Args = other.Args;
        }

        //Сложение матриц
        public static Matrix operator + (Matrix m1, Matrix m2)
        {
            if (m1.Size != m2.Size) throw new ArgumentException("Матрицы должны иметь один размер!");
            double[,] ans = new double[m1.Size, m2.Size];
            for (int i = 0; i < m1.Size; i++)
                for (int j = 0; j < m2.Size; j++)
                    ans[i, j] = m1.Args[i, j] + m2.Args[i, j];
            return new Matrix(ans);
        }

        //Вычитание матриц
        public static Matrix operator - (Matrix m1, Matrix m2)
        {
            if (m1.Size != m2.Size) throw new ArgumentException("Матрицы должны иметь один размер!");
            double[,] ans = new double[m1.Size, m2.Size];
            for (int i = 0; i < m1.Size; i++)
                for (int j = 0; j < m2.Size; j++)
                    ans[i, j] = m1.Args[i, j] - m2.Args[i, j];
            return new Matrix(ans);
        }

        //Нахождение детерминанта
        public static double Determinant(Matrix m)
        {
            double det = 0; int length = m.Size;
            if (length == 1) det = m.Args[0, 0];
            if (length == 2) det = m.Args[0, 0] * m.Args[1, 1] - m.Args[0, 1] * m.Args[1, 0];
            if (length > 2)
                for (int i = 0; i < m.Size; i++)
                    det += Math.Pow(-1, 0 + i) * m.Args[0, i] * Determinant(m.getMinor(0, i));
            return det;
        }

        //Получить минор
        public Matrix getMinor(int row, int column)
        {
            if (this.Size == 1) return new Matrix(this.Args);

            double[,] minor = new double[Size - 1, Size - 1];
            for (int i = 0; i < this.Size; i++)
                for (int j = 0; j < this.Size; j++)
                    if ((i != row) || (j != column))
                    {
                        if (i > row && j < column) minor[i - 1, j] = this.Args[i, j];
                        if (i < row && j > column) minor[i, j - 1] = this.Args[i, j];
                        if (i > row && j > column) minor[i - 1, j - 1] = this.Args[i, j];
                        if (i < row && j < column) minor[i, j] = this.Args[i, j];
                    }
            return new Matrix(minor);
        }
    }
}
