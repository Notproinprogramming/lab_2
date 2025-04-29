using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    public class Program
    {
        public static void PrintArray(int[] array, int length)
            {
            Console.Write("[ ");
            for (int i = 0; i < length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("]");
        }

        public static int Main(string[] args)
        {
            //System.Diagnostics.Debugger.Launch();
            int length = args.Length;
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
                if (Int32.TryParse(args[i], out var value))
                    array[i] = value;
                else
                {
                    Console.WriteLine("Input in a place " + (i+1) + " was not a number" , Console.Error);
                    return 1;
                }

            
            Console.WriteLine("===================================");
            Console.WriteLine("The number that you entered is: ");
            PrintArray(array, length);
            
            Console.WriteLine("Sorted array:");
            PrintArray(Sorting.BubbleSort(array, length), length);

            return 0;
        }
    }
}

