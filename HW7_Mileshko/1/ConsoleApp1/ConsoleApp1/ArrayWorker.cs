using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ArrayWorker
    {

        public int[] InvertArray(int[] arr)
        {
            int length = arr.Length;
            int[] inverted = new int[length];

            for (int i = 0; i < length; i++)
            {
                inverted[i] = arr[length - 1 - i];
            }

            return inverted;
        }
    }
}
