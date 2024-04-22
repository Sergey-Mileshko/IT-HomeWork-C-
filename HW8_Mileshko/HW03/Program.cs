using HW8_03_Mileshko;
internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("HW8_ex3_Mileshko\n");
        try
        {
            Console.WriteLine("Array:");
            int[] numbers = { 9, 12, -5, -8, 4, 55, 49 };
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("MaxValue:");
            int max = numbers.MaxValue();
            Console.WriteLine(max);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}