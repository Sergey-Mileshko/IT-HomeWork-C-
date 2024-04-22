using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("HW16_ex1_Mileshko \n");
        List<int> sequence = new List<int> { -10, 22, 13, 43, -5, -12, 100 };
        Console.WriteLine("Numbers:");
        foreach (int number in sequence)
        {
            Console.Write(number+ " ");
        }
        List<int> extractedNumbers = sequence.Where(x => x < 0 && x % 2 == 0).ToList();
        extractedNumbers.Reverse();

        Console.WriteLine("\nNegative even numbers:");

        foreach (int number in extractedNumbers)
        {
            Console.WriteLine(number);
        }
        Console.ReadKey();
    }
}