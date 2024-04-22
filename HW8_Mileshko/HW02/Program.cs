using HW8_02_Mileshko;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("HW8_ex2_Mileshko");
        Console.WriteLine(" ");
        Engine engine = new Engine();

        Car car = new Car();
        car.Engine = engine;
        car.Move();  // Выводит "Автомобиль движется." и "Двигатель запущен."

        Console.WriteLine(" ");

        Plane plane = new Plane();
        plane.Engine = engine;
        plane.Move();  // Выводит "Самолет летит." и "Двигатель запущен."
    }
}