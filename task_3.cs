using System;

namespace MatrixMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix1 = {
                { 2, 4 },
                { 3, 2 }
            };

            int[,] matrix2 = {
                { 3, 4 },
                { 3, 3 }
            };

            int[,] resultMatrix = MultiplyMatrices(matrix1, matrix2);

            Console.WriteLine("Результирующая матрица:");

            for (int i = 0; i < resultMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < resultMatrix.GetLength(1); j++)
                {
                    Console.Write(resultMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
        {
            int rows1 = matrix1.GetLength(0);
            int cols1 = matrix1.GetLength(1);
            int cols2 = matrix2.GetLength(1);

            int[,] result = new int[rows1, cols2];

            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < cols1; k++)
                    {
                        sum += matrix1[i, k] * matrix2[k, j];
                    }
                    result[i, j] = sum;
                }
            }

            return result;
        }
    }
}
