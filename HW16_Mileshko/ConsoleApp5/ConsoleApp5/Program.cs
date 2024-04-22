using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    public static class EnumerableExtensions
    {
        public static T Median<T>(this IEnumerable<T> source)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            var sortedList = source.OrderBy(x => x).ToList();
            int count = sortedList.Count;

            if (count == 0)
            {
                throw new InvalidOperationException("Sequence contains no elements.");
            }

            return sortedList[count / 2];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HW18_ex5_Mileshko \n");

            List<int> numbers = new List<int> { 0, 10, 20, 30, 40, 50, 60,70, 80, 90, 100};

            int median = numbers.Median();
            Console.WriteLine($"Median: {median}");
        }
    }
}
