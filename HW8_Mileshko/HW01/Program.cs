using HW8_01_Mileshko;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("HW8_ex1_Mileshko");
        Item i = new Item();
        Console.WriteLine(i.GetName());

        i.SetName("Ivan");
        Console.WriteLine(i.GetName());
    }
}