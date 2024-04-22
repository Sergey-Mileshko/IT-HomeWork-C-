using System;

class EmptyStringException : Exception
{
    public EmptyStringException() : base("Attention an empty line.") { }
}

class MyClass
{
    public void ProcessString(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            throw new EmptyStringException();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("HW14_ex3_Mileshko \n");
        try
        {
            MyClass myObject = new MyClass();
            myObject.ProcessString("");
        }
        catch (EmptyStringException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        Console.ReadKey();
    }
}