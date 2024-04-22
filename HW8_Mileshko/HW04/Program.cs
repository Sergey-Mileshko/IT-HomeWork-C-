using HW8_04_Mileshko;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("HW8_ex04_Mileshko");
        try
        {
            Bag bag = new Bag();
            bag.SetIsOpen(true);
            Console.WriteLine("What do you put in the bag?");
            string object_ = Console.ReadLine();
            if (bag.AddValueToArray(object_))
            {
                Console.WriteLine($"Added to the bag {object_}\n");
            }

            
            Console.WriteLine($"It out of the bag {bag.TakeOutValueToArray(0)}");
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        
    }
}