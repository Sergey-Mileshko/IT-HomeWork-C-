using System;

class School
{
    public delegate void StudentAddedDelegate(string name, int age);
    public event StudentAddedDelegate StudentAdded;

    public void AddStudent(string name, int age)
    {
        Console.WriteLine($"People {name} add to school.");
        StudentAdded?.Invoke(name, age);
    }
}

class Director
{
    public void GreetParents(string name, int age)
    {
        Console.WriteLine($"Welcome to school, parents of {name}! You child is {age} old. \n");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("HW15_ex1_Mileshko \n");

        School school = new School();
        Director director = new Director();
        school.StudentAdded += director.GreetParents;
        school.AddStudent("Ivan", 15);
        school.AddStudent("Lev", 7);
        school.AddStudent("Leya", 9);
        school.AddStudent("Sofia", 10);

        Console.ReadKey();
    }
}