using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Extension.Standart_
{
    internal class ArrayHighElement
    {
        internal int[,] EnterArray()
        {   
           Console.WriteLine("The Lengh of Massive:");
           int n = int.Parse(Console.ReadLine());
           Console.WriteLine("The High of Massive:");
           int m = int.Parse(Console.ReadLine());
            int[,] arr = new int[n, m];

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; i < arr.Length; j++)
                {
                    Console.Write($"mass[{i}],[{j}]=");
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }

            return arr;

        }
        internal void Print(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + ' ');
                }

                Console.WriteLine();
            }
        }

        internal int[] GetMaxByRow (int[,] arr)
        {
            int[] maxRow = new int[arr.GetLength(0)];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int max = arr[i, 0];

                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (max < arr[i, j])
                        max = arr[i, j];
                  
                }

                maxRow[i] = max;
               
            }

            return maxRow;
        }
    }
}