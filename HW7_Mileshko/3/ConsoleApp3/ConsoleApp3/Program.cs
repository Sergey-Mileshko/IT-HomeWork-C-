internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("HW7_ex3(Stack)_Mileshko");
        var stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);
        stack.Push(5);

        Console.WriteLine($"Should print out 5: {stack.Peek()}");

        stack.Pop();

        Console.WriteLine($"Should print out 4: {stack.Peek()}");

        Console.WriteLine($"Iterate over the stack.");
        foreach (var Iter in stack)
        {
            Console.WriteLine(Iter);
        }
    }
}