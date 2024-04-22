using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("HW14_ex2_Mileshko \n");
        try
        {
            Console.WriteLine("Enter the first number from 0 to 255:");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number from 0 to 255:");
            int number2 = int.Parse(Console.ReadLine());

            int result = DivideNumbers(number1, number2);
            Console.WriteLine($"The result:  {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error in the number input format. Enter an integer from 0 to 255.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("A number outside the acceptable range [0-255] ");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Mistake. Division by zero is not possible.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        Console.ReadKey();
    }
    

    static int DivideNumbers(int number1, int number2)
    {
        if (number2 == 0)
        {
            throw new DivideByZeroException();
        }

        return number1 / number2;
    }
    
}