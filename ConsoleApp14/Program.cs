using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr =  new int[40];
            int[] arr_min = new int[40];
            int[] arr_max = new int[40];
            

            FileStream file1 = new FileStream("C:\\Users\\user\\Desktop\\Разработка програмных модулей\\ConsoleApp14\\F1.txt", FileMode.Open); //создаем файловый поток
            StreamWriter writer = new StreamWriter(file1); //создаем «потоковый писатель» и связываем его с файловым потоком
            FileStream file2 = new FileStream("C:\\Users\\user\\Desktop\\Разработка програмных модулей\\ConsoleApp14\\F2.txt", FileMode.Open); //создаем файловый поток
            StreamWriter writer2 = new StreamWriter(file2); //создаем «потоковый писатель» и связываем его с файловым потоком

            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-10, 10);
            }

            Array.Sort(arr);
            for(int i = 0;i < arr.Length;i++)
            {
               writer.Write(arr[i] + " ");
            }
            writer.Close();

            Array.Reverse(arr);
            for (int i = 0; i < arr.Length;i++) 
            {
                writer2.Write(arr[i] + " ");
            }
            writer2.Close();

            Console.WriteLine("Завершено!");

        }
    }
}
