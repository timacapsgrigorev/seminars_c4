using System;

namespace ThreeDimensionalArrayWithIndices
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] threeDimArray = GenerateArray(2, 2, 2);

            PrintArrayWithIndices(threeDimArray);
        }

        static int[,,] GenerateArray(int x, int y, int z)
        {
            int[,,] array = new int[x, y, z];
            int num = 10; // Начальное значение

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    for (int k = 0; k < z; k++)
                    {
                        array[i, j, k] = num++;
                    }
                }
            }

            return array;
        }

        static void PrintArrayWithIndices(int[,,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
