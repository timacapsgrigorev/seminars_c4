using System;

namespace MinSumRowIn2DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = {
                { 1, 4, 7, 2 },
                { 5, 9, 2, 3 },
                { 8, 4, 2, 4 },
                { 5, 2, 6, 7 }
            };

            int minSumRow = FindMinSumRow(array);

            Console.WriteLine($"Строка с наименьшей суммой элементов: {minSumRow + 1}");
        }

        static int FindMinSumRow(int[,] array)
        {
            int minSum = int.MaxValue;
            int minSumRow = -1;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                int currentSum = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    currentSum += array[i, j];
                }

                if (currentSum < minSum)
                {
                    minSum = currentSum;
                    minSumRow = i;
                }
            }

            return minSumRow;
        }
    }
}
