using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace local_maximum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arrayLenght = 30;
            int[] array = new int[arrayLenght];
            Random random = new Random();
            int minValue = 0;
            int maxValue = 100;
            int compareNumber;

            Console.Write("Массив: ");

            for(int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(minValue, maxValue);
                Console.Write(array[i] + " ");
            }

            Console.Write("\nЛокальные максимумы: ");

            if (array[0] > array[1])
            {
                Console.Write(array[0] + " ");
            }

            for(int i = 1; i < array.Length - 2; i++)
            {
                if (array[i] > array[i + 1] && array[i] > array[i - 1])
                {
                    Console.Write(array[i] + " ");
                }
            }

            if (array[array.Length - 1] > array[array.Length - 2])
            {
                Console.Write(array[array.Length - 1]);
            }

            Console.ReadKey();
        }
    }
}
