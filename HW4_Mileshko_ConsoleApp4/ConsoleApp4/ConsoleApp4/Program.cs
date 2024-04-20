using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("Задание1");
        /*
        Создать консольное приложение, в котором пользователь вводит два числа и если сумма чисел делится:
        a)на 2 то на экран выводится “sum can be divided by 2”;
        b)5 то на экран выводится “sum can be divided by 5”;
        c)если на 2 и 5 то “sum can be divided by 2 and 5”.
         */
        int per1 = 0, per2 = 0;
        Console.WriteLine("Введите переменные a и b: ");
        per1 = Convert.ToInt32(Console.ReadLine());
        per2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Мы получили сумму:");
        Console.WriteLine($"per1+per2={per1 + per2}");

        if (((per1 + per2) % 2 == 0) && ((per1 + per2) % 5 == 0))
        {
            Console.WriteLine("sum can be devided by 2 and 5");
        }
        else if ((per1 + per2) % 2 == 0)
        {
            Console.WriteLine("sum can be devided by 2");
        }
        else if ((per1 + per2) % 5 == 0)
        {
            Console.WriteLine("sum can be devided by 5");
        }
        else Console.WriteLine("sum can't be devided by 2 and 5");

        Console.WriteLine("Задание2");
        /*
        Содайте Console Applicationв Visual Studio.
       Дано: у вас есть 3 промежутка чисел: от 0 до 30, от 31 до 60 и от 61 до 100.
       Входной параметр: пользователь вводит число.
       Что мы делаем: нужно понять в какой промежуток попало число.
       Выводим на консоль: в каком промежутке число. Если не попало, пишем “Don’t know this number.”
        */
        int number = 0;
        Console.WriteLine("Введите число: ");
        number = Convert.ToInt32(Console.ReadLine());
        if ((number >= 0) && (number <= 30)) { Console.WriteLine("Промежуток 0-30"); }
        else if ((number >= 31) && (number <= 60)) { Console.WriteLine("Промежуток 31-60"); }
        else if ((number >= 61) && (number <= 100)) { Console.WriteLine("Промежуток 61-100"); }
        else Console.WriteLine("Don't know this number");

        Console.WriteLine(" ");
        Console.WriteLine("Задание1 a) HW4");
        /*
         1.Найти все числа, большее 200 и меньше 500, которое нацело делится на 17. 
          Реализовать через цикл While(). На выходе мы должны получить строку, где числа разделены ‘,’
         */
        int i = 200;
        while (i < 500)
        {
            if (i % 17 == 0) Console.Write($"{i}, ");
            i++;
        }
        Console.WriteLine(" ");
        Console.WriteLine("Задание1 b) HW4");
        int a = 200;
        int b = 500;
        int d = 17;

        int ii = 201;
        string result = string.Empty;

        while (ii > a & ii < b)
        {
            if (ii % d == 0)
            {
                if (string.IsNullOrEmpty(result))
                {
                    result += ii.ToString();
                }
                else
                {
                    result += "," + ii.ToString();
                }
            }
            ii++;
        }
        Console.WriteLine(result);

        Console.WriteLine("  ");

        Console.WriteLine("Задание2 HW4");
        /*
         2.Ввести с клавиатуры символ. Определить, необходимо ли нам переместить фигуру вверх, вниз, вправо, 
         влево в зависимости от введенного символа (W, S, A, D). Вывести результат решения на экран. 
         В случае отсутствия необходимости перемещения вывести соответствующее сообщение.
         */
        // Label1:
        Console.WriteLine("Введите символ: ");
        string ch = Console.ReadLine();

        switch (ch)
        {
            case "W": Console.WriteLine("Двигаемся вверх"); break;
            case "S": Console.WriteLine("Двигаемся вниз"); break;
            case "A": Console.WriteLine("Двигаемся влево"); break;
            case "D": Console.WriteLine("Двигаемся вправо"); break;
            case "w": Console.WriteLine("Двигаемся вверх"); break;
            case "s": Console.WriteLine("Двигаемся вниз"); break;
            case "a": Console.WriteLine("Двигаемся влево"); break;
            case "d": Console.WriteLine("Двигаемся вправо"); break;
            default: Console.WriteLine("Необходимость перемещения отсутствует"); break;
        }
        // goto Label1;


        Console.WriteLine(" ");
        Console.WriteLine("Задание3 HW4");
        /*
         3.Создать массив целочисленных элементов. Циклом занести туда рандомные числа.
         Для генерации случайных чисел использовать класс Random и его метод Next.
         Реализовать перебор элементов массива int[] используя оператор goto
         */
        Console.WriteLine("Введите размер массива: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] array1 = new int[n];
        int counter = 0;
        Random rand = new Random();

    Label2:
        array1[counter] = rand.Next(-100, 100);
        Console.WriteLine(array1[counter]);
        counter++;
        if (counter < n)
            goto Label2;


        Console.WriteLine(" ");
        Console.WriteLine("Задание4 HW4");
        /*
         4.Написать функцию которая расчитывает налог на доход, необходимый для уплаты в конце месяца.
        Метод Должен возвращать bool флаг о том что он смог сделать расчет, а результат ресчета возвращать через out параметр. 
        Решить какие типы данных будут использоваться и как будет возвращаться значение.
         */



        static decimal Nalog(decimal fullsum, decimal stavka)
        {
            return fullsum * stavka / 100;
        }

        Console.WriteLine("Введите доход: ");
        decimal salary = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Введите ставку налога в процентах: ");
        decimal tax = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine($"Нужно уплатить налог в размере {Nalog(salary, tax)}BYN");
        Console.ReadKey();
    }


    
}
    
