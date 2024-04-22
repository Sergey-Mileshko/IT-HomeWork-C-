using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;


namespace HW8_03_Mileshko
{
    public static class ArrayExtensions
    {
        public static int MaxValue(this int[] arr)
        {
            if (arr == null)
            {
                throw new ArgumentNullException(nameof(arr));
            }
            
            if (arr.Length == 0)
            {
                throw new InvalidOperationException("The array is empty.");
            }

            int maxValue = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > maxValue)
                {
                    maxValue = arr[i];
                }
            }

            return maxValue;
        }
    }
}
