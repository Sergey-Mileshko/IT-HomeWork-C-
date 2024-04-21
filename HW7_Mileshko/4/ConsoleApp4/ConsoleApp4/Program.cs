internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("HW7_ex4(Queue)_Mileshko");

        var queue = new Queue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);
        queue.Enqueue(5);

        Console.WriteLine($"Should print out 1: {queue.Peek()}");

        queue.Dequeue();

        Console.WriteLine($"Should print out 2: {queue.Peek()}");

        Console.WriteLine($"Iterate over the queue.");
        foreach (var Iter_Q in queue)
        {
            Console.WriteLine(Iter_Q);
        }
    }
}