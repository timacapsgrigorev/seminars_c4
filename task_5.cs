using System;

namespace SpiralArrayFill
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = FillSpiralArray(4);

            PrintArray(array);
        }

        static int[,] FillSpiralArray(int n)
        {
            int[,] result = new int[n, n];
            int value = 1;
            int rowStart = 0, rowEnd = n - 1;
            int colStart = 0, colEnd = n - 1;

            while (value <= n * n)
            {
                for (int i = colStart; i <= colEnd; i++)
                {
                    result[rowStart, i] = value++;
                }
                rowStart++;

                for (int i = rowStart; i <= rowEnd; i++)
                {
                    result[i, colEnd] = value++;
                }
                colEnd--;

                for (int i = colEnd; i >= colStart; i--)
                {
                    result[rowEnd, i] = value++;
                }
                rowEnd--;

                for (int i = rowEnd; i >= rowStart; i--)
                {
                    result[i, colStart] = value++;
                }
                colStart++;
            }

            return result;
        }

        static void PrintArray(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(array[i, j].ToString().PadLeft(2) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
