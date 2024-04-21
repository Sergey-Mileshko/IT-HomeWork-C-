using ConsoleApp1;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        {
            Console.WriteLine("HW7_ex1_Mileshko");

            Console.WriteLine("Enter the size of the array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            int counter = 0;
            Random rand = new Random();

        Label2:
            arr[counter] = rand.Next(1, 9); // задаём массив случайными цифрами от 1 до 9
         
            counter++;
            if (counter < n)
                goto Label2;

           

            ArrayWorker arrayWorker = new ArrayWorker();
            int[] invertedArray = arrayWorker.InvertArray(arr);



            Console.WriteLine("Array: ");
            foreach (int element in arr)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();


            Console.WriteLine("Inverted array: ");
            foreach (int element in invertedArray)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }
}