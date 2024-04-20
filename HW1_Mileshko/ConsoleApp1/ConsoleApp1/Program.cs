using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Забивание гвоздя HW1_Mileshko");

        
                Console.WriteLine("Возьмите гвоздь от 1 до 10");

        int N = System.Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Берём молоток");
        Console.WriteLine("Вы ввели такое кол-во гвоздей "+N);
     
        Console.WriteLine("Делаем удар молотком по гвоздю, от 1 до 5 - кол-во ударов ");

        int T = System.Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Кол-во ударов " + T);
   

        if (N < 0)
        
        for (int i = 1; N < i; N--)
            {
                Console.WriteLine("Возьмите следующий гвоздь");
        }
        else
        if (T==0)
        {
            Console.WriteLine("Гвоздь забит");
        }

    }
}