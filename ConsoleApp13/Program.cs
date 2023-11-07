using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] arr = new int[20];
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(1, 10);
            }

            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            int minIndex = 0;
            int maxIndex = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < arr[minIndex])
                {
                    minIndex = i;
                }
                if (arr[i] > arr[maxIndex])
                {
                    maxIndex = i;
                }
            }

            int temp = arr[minIndex];
            arr[minIndex] = arr[maxIndex];
            arr[maxIndex] = temp;
            Console.WriteLine();

            for (int i = 0; i < arr.Length; i++)
            {
                
                Console.Write($"{arr[i]} ");
            }

        }
    }
}
