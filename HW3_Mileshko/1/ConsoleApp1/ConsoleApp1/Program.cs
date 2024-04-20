using System.ComponentModel.Design;

internal class Program
{
   
    public const double Pi = Math.PI;
    private static void Main(string[] args)
    {
        Console.WriteLine("Задание1 HW3_Mileshko ");
        /*
        1.Рассчитать и вывести на консоль площадь поверхности круглого конусаю.
Формула S = πr(r + l);
        где r – радиус основания, l – образующая, π(пи)— математическая постоянная;
        Важно! Πи должно быть константой. r и I входные параметры, т е их вводим через консоль.
        */

        Console.WriteLine("Введите r – радиус основания");
        double r = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine("Введите l  – образующая");
        double l = Convert.ToDouble(Console.ReadLine());

        double S = Pi * r*(r + l);
      
        Console.WriteLine("Pi=" + Pi);

        Console.WriteLine("S="+S);

        Console.WriteLine(" ");
        Console.WriteLine("Задание2 HW3_Mileshko ");
        /*
          2. Создать консольное приложение, которое будет ожидать ввода символов (чисел),
Проверять, что число четное.
  Если четное -> вывести на консоль “число {значение} четное”
  Если нечетное -> вывести на консоль “число {значение} нечетное”
         */
        Console.WriteLine("Введите 1-е число");
        double a1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите 2-е число");
        double a2 = Convert.ToDouble(Console.ReadLine());
        if (a1 % 2 == 0)
            Console.WriteLine($" Число {a1} чётное");
        else
            Console.WriteLine($" Число {a1} нечётное");

        if (a2 % 2 == 0)
            Console.WriteLine($" Число {a2} чётное");
        else
            Console.WriteLine($" Число {a2} нечётное");

        Console.WriteLine(" ");
        Console.WriteLine("Задание3 HW3_Mileshko ");
        Console.WriteLine("int x = 14, y = 1, и z = 5;  ");
       
        /*
         3.Имеется 3 переменные типа int x = 14, y = 1, и z = 5; 
           Выведите значения переменных на Console после каждой операции:

             x += y - x++ * z; 
             z = --x – y * 5; 
             y /= x + 5 % z; 
             z = x++ + y * 5; 
             x = y - x++ * z; 
          */
        int x = 14, y = 1,  z = 5;
        x += y - x++ * z;
        Console.WriteLine(" Первое выражание:x += y - x++ * z;");
        Console.WriteLine($"x={x}  y={y}  z={z}");

        int x2 = 14, y2 = 1, z2 = 5;

        z2 = --x2  -y2 * 5;
        Console.WriteLine(" Второе выражание:z = --x – y * 5;");
        Console.WriteLine($"x={x2}  y={y2}  z={z2}");
        int x3 = 14, y3 = 1, z3 = 5;

        y3 /= x3 + 5 % z3;
        Console.WriteLine(" Третье выражание:y /= x + 5 % z;");
        Console.WriteLine($"x={x3}  y={y3}  z={z3}");
        int x4 = 14, y4 = 1, z4 = 5;
        z4 = x4++ + y4 * 5;
        Console.WriteLine(" Четвёртое выражание:z = x++ + y * 5;");
        Console.WriteLine($"x={x4}  y={y4}  z={z4}");
        int x5 = 14, y5 = 1, z5 = 5;
        x5 = y5 - x5++ * z5;
        Console.WriteLine(" Пятое выражание:x = y - x++ * z; ");
        Console.WriteLine($"x={x5}  y={y5}  z={z5}");


        Console.WriteLine(" ");
        Console.WriteLine("Задание4 HW3_Mileshko ");
        /*
        4.С помощью оператора default вывести в консоль дефолтные значения для всех числовых типов данных
        +типа  int?, типа string, char, bool

        */
        byte a = default(byte);
        sbyte b = default(sbyte);
        short c = default(short);
        ushort d = default(ushort);
        int e = default(int);
        uint f = default(uint);
        long g = default(long);
        ulong p = default(ulong);

        float k = default(float);
        double m = default(double);

        decimal q = default(decimal);

        bool n = default(bool);

        char ch = default(char);

        string s = default(string);

        object w = default(object);

        Console.WriteLine("Значения по умолчанию для целочисельных типов:");
        Console.WriteLine("byte: {0}", a);
        Console.WriteLine("sbyte: {0}", b);
        Console.WriteLine("short: {0}", c);
        Console.WriteLine("ushort: {0}", d);
        Console.WriteLine("int: {0}", e);
        Console.WriteLine("uint: {0}", f);
        Console.WriteLine("long: {0}", g);
        Console.WriteLine("ulong: {0}", p);

        Console.WriteLine();

        Console.WriteLine("Значения по умолчанию для вещественных типов:");
        Console.WriteLine("float: {0}", k);
        Console.WriteLine("double: {0}", m);

        Console.WriteLine();

        Console.WriteLine("Значением по умолчанию для типа decimal: {0}", q);
        Console.WriteLine("Значением по умолчанию для типа bool: {0}", n);
        Console.WriteLine("Значением по умолчанию для типа char: {0}", ch);

        Console.WriteLine();

        // поскольку типы string и object являются ссылочными типами (class), то их значениями по умоланию должно быть null
        // null – указывает, что переменная не ссылается ни на один объект в памяти
        // проверка на null: s == null ? "null" : s
        Console.WriteLine("Значением по умолчанию для типа string: {0}", s == null ? "null" : s);
        Console.WriteLine("Значением по умолчанию для типа object: {0}", w == null ? "null" : w);

        Console.WriteLine(" ");
        Console.WriteLine("Задание5 HW3_Mileshko ");

        /* 5.  Создать переменную в которую записать свой рост и вывести в консоль название переменной и значение.
        Используйте оператор nameof.
          */
        float myHeight=1.86f;
        string str = nameof(myHeight);
        // str = "myHeight"
        Console.WriteLine($"{str}={myHeight} м");


        Console.WriteLine("Example");
        string person_Height;
        float x10 = 2.10f;
        Console.WriteLine($"{nameof(person_Height)}={(x10)} м");      
     

    
         
    


    Console.ReadKey();
    }
}