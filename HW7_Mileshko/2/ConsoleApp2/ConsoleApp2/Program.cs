using ConsoleApp2;

internal class Program
{
    private static void Main(string[] args)
    {
        {

            Console.WriteLine("HW7_ex2_Mileshko");
            double r = 4;
            double h = 8;

            Cone cone = new Cone(r, h);

            double baseArea = cone.Base_Area();
            double totalArea = cone.Total_Area();

            Console.WriteLine("Base Area: " + baseArea +"cm2");
            Console.WriteLine("Total Area: " + totalArea+ "cm2");
        }
    }
}