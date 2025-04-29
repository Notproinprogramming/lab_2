using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    public class Sorting
    {
        public static int[] BubbleSort(int[] array, int length)
        {
            for (bool operation = false; ; operation = false)
            {
                for (int i = 0; i < length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        operation = true;
                    }
                }
                if (!operation)
                {
                    break;
                }
            }
            return array;
        }
    }
}
