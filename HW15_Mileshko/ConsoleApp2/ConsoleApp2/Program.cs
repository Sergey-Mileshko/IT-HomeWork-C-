using System;

class Kindergarten
{
    public event EventHandler ChildGraduated;
    public void GraduateChild(string childName)
    {
        Console.WriteLine($"Child is {childName} graduated from kindergarten.");
        ChildGraduated?.Invoke(this, EventArgs.Empty);
    }
}

class School
{
    public void AcceptChild(object sender, EventArgs e)
    {
        Console.WriteLine("The child has add to school. \n");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("HW15_ex2_Mileshko \n");
        Kindergarten kindergarten = new Kindergarten();
        School school = new School();
        kindergarten.ChildGraduated += school.AcceptChild;

        kindergarten.GraduateChild("Yasha");
        kindergarten.GraduateChild("Dasha");
        kindergarten.GraduateChild("Ivan");

        Console.ReadKey();
    }
}