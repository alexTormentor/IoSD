using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MatrixTester
{
    class Matrix
    {
        public double[,] Params { get; set; }
        public int Size { get; set; }

        public Matrix(double[,] M)
        {
            if (M == null) throw new ArgumentNullException("Матрица не может быть пустой");     // проверка на пустоту матрицы
            int rows = M.GetLength(0);                                                          // строки столбцы
            int cols = M.GetLength(1);
            if (rows != cols) throw new ArgumentException("Матрица должна быть квадратной!");   // проверка на квадратность матрицы
            Size = rows;
            Params = new double[rows, cols];                                                    // размер определили и создали массив на размер
            for (int i = 0; i < Size; i++)                                                      // проходим по всей матрице
                for (int j = 0; j < Size; j++)
                    Params[i, j] = M[i, j];
        }

        public Matrix(Matrix newSize)
        {
            this.Size = newSize.Size;   // пересоздание матрицы
            Params = newSize.Params;    // новое заполнение
        }

        //Сложение матриц
        public static Matrix operator+(Matrix m1, Matrix m2)
        {
            if (m1.Size != m2.Size) throw new ArgumentException("Матрицы не совпадают по размеру"); // если не совпали размеры
            double[,] matrix_sum = new double[m1.Size, m2.Size];                                    // задали матрицы
            for (int i = 0; i < m1.Size; i++)                                                       // проходим по массивам
                for (int j = 0; j < m2.Size; j++)
                    matrix_sum[i, j] = m1.Params[i, j] + m2.Params[i, j];                           // суммируем матрицы
            return new Matrix(matrix_sum);
        }

        //Вычитание матриц
        public static Matrix operator-(Matrix m1, Matrix m2)
        {
            if (m1.Size != m2.Size) throw new ArgumentException("Матрицы не совпадают по размеру"); // если не совпали размеры
            double[,] matrix_sub = new double[m1.Size, m2.Size];                                    // задали матрицы
            for (int i = 0; i < m1.Size; i++)                                                       // проходим по массивам
                for (int j = 0; j < m2.Size; j++)
                    matrix_sub[i, j] = m1.Params[i, j] - m2.Params[i, j];                           // вычитаем матрицы
            return new Matrix(matrix_sub);
        }
    }
}
