using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_hw
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();

            //1. Заполнить одномерный массив случайными числами.
            //Сжать массив, удалив из него все 0 и заполнить
            //освободившиеся справа элементы значениями -1.
            //Console.Write("Enter array size -> ");
            //int size = int.Parse(Console.ReadLine());
            //int[] arr = new int[size];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = rand.Next(0, 2);
            //}
            //Console.Write("1th array -> ");
            //foreach (var item in arr)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            //int[] res = new int[size];
            //int count = 1;
            //for (int i = 0, j = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] != 0)
            //        res[j++] = arr[i];
            //    else
            //        res[res.Length - count++] = -1;
            //}
            //arr = res;
            //Console.Write("New array -> ");
            //foreach (var item in arr)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();


            //2. Заполнить одномерный массив случайными числами.
            //Преобразовать массив так, чтобы сначала шли отрицательные
            //элементы, а потом положительные.
            //Console.Write("Enter array size -> ");
            //int size = int.Parse(Console.ReadLine());
            //int[] arr = new int[size];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = rand.Next(-5, 5);
            //}
            //Console.Write("1th array -> ");
            //foreach (var item in arr)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            //int[] res = new int[size];
            //int j = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] < 0)
            //        res[j++] = arr[i];
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] >= 0)
            //        res[j++] = arr[i];
            //}
            //Console.Write("New array -> ");
            //foreach (var item in res)
            //{
            //    Console.Write(item + " ");
            //}


            //3. В двумерном массиве, размеры которого вводятся с
            //клавиатуры, поменять местами заданные столбцы.
            //Console.WriteLine("Enter size two-dimensional array [row x col]");
            //Console.Write("Enter row -> ");
            //int row = int.Parse(Console.ReadLine());
            //Console.Write("Enter col -> ");
            //int col = int.Parse(Console.ReadLine());
            //int[,] arr = new int[row, col];
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        arr[i, j] = rand.Next(10);
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("Array: ");
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Console.Write(arr[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();
            //int[,] tmp = new int[row, col];
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        tmp[i, j] = arr[i, arr.GetLength(1) - j - 1];
            //    }
            //}
            //arr = tmp;
            //Console.WriteLine("New Array: ");
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Console.Write(arr[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();


        }
    }
}
