using System;

internal class Program
{
    public const double Pi = Math.PI;
    
    private static void Main(string[] args)
    {

       
        Console.WriteLine("MySecondConsole_Mileshko\n");
     
        // задание2 HW2
        Console.WriteLine("Задание2 HW2 ");
       // double pi = 3.141592653d;
        Console.WriteLine(" Введено число Pi= " + Pi);
        
    decimal e = 1.414213562373095048M;

        Console.WriteLine(" Введено число e=" + e) ;

        double Ed = 1.414213562373095048d;
        Console.WriteLine("Ed=" + Ed); Console.Write("Ed- тип double" );
        // задание3 HW2
        Console.WriteLine("\nЗадание3 HW2 ");
        int a = 3;
        Console.WriteLine(" a= "+ a);

        byte b = ((byte)a);
        Console.WriteLine(" b= "+ b);


        // задание4 HW2
        Console.WriteLine("\nЗадание4 HW2 ");
        bool correctEnter = false;
        int x = 0, y = 0, z = 0;
        string input = "";
        do
        {
            Console.WriteLine("Введите 1-e  число");
            input = Console.ReadLine();
            if (int.TryParse(input, out int result1))
            {

                correctEnter = true;
                x = result1;
            }
            else Console.WriteLine("Не корректный ввод");

            correctEnter = false;

            Console.WriteLine("Введите 2-e  число");
            input = Console.ReadLine();
            if (int.TryParse(input, out int result2))
            {

                correctEnter = true;
                y = result2;
            }
            else Console.WriteLine("Не корректный ввод");

            correctEnter = false;

            Console.WriteLine("Введите 3-e  число");
            input = Console.ReadLine();
            if (int.TryParse(input, out int result3))
            {

                correctEnter = true;
                z = result3;
            }
            else Console.WriteLine("Не корректный ввод");

            correctEnter = false;

            double rez = (x + y + z) / 3;

            Console.WriteLine("rez= " + rez);


        }
        while (true);

        Console.ReadKey();
    }
}