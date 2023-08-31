using System;

namespace TwoDimensionalArraySorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = {
                { 1, 4, 7, 2 },
                { 5, 9, 2, 3 },
                { 8, 4, 2, 4 }
            };

            SortRowsDescending(array);

            // Вывод отсортированного массива
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void SortRowsDescending(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                // Создаем временный массив для сортировки текущей строки
                int[] tempRow = new int[array.GetLength(1)];
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    tempRow[j] = array[i, j];
                }

                // Сортировка временного массива по убыванию
                Array.Sort(tempRow);
                Array.Reverse(tempRow);

                // Копирование отсортированных элементов обратно в исходный массив
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = tempRow[j];
                }
            }
        }
    }
}
