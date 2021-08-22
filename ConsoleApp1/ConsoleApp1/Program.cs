/*Создать массив из 20 элементов в диапазоне значений от -15 до 14 включительно.
 * Определить количество элементов по модулю больших, чем максимальный.*/

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            Random random = new Random();

            for (int i = 0; i < arr.Length; i++) // заполнение массива рандомными числами
            {
                arr[i] = random.Next(-15, 14);
            }

            for (int i = 0; i < arr.Length - 1; i++)// сортировка массива
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        arr[i] = arr[i] + arr[j];
                        arr[j] = arr[i] - arr[j];
                        arr[i] = arr[i] - arr[j];
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("сортированные числа до модуля: " + arr[i]);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                    arr[i] = arr[i] * -1;

                Console.WriteLine("присвоили модуль числам: " + arr[i]);
            }

            int counter = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[19])
                {
                    counter++;
                }
            }
            Console.WriteLine("количество чисел по модулю больше максимального числа без модуля: " + counter);
        }
    }
}
