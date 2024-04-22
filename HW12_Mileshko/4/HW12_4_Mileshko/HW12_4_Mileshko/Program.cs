using System;
using System.Collections.Generic;

public enum Gender_F_M
{
    Female,
    Male
}

public class Person : IComparable<Person>
{
    public int Age { get; set; }
    public Gender_F_M Gender { get; set; }

    public int CompareTo(Person other)
    {
        if (this.Gender != other.Gender)
        {
            return this.Gender.CompareTo(other.Gender);
        }
        else
        {
            return this.Age.CompareTo(other.Age);
        }
    }
}

public class PersonComparer : IComparer<Person>
{
    public int Compare(Person x, Person y)
    {
        if (x.Gender != y.Gender)
        {
            return x.Gender.CompareTo(y.Gender);
        }
        else
        {
            return x.Age.CompareTo(y.Age);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("HW12_ex4_Mileshko \n");

        List<Person> listOfPerson = new List<Person>
        {
            new Person { Age = 11, Gender = Gender_F_M.Female },
            new Person { Age = 40, Gender = Gender_F_M.Male },
            new Person { Age = 17, Gender = Gender_F_M.Female },
            new Person { Age = 15, Gender = Gender_F_M.Male },
            new Person { Age = 38, Gender = Gender_F_M.Female },
            new Person { Age = 18, Gender = Gender_F_M.Male },
            new Person { Age = 65, Gender = Gender_F_M.Female },
            new Person { Age = 21, Gender = Gender_F_M.Male },
            new Person { Age = 43, Gender = Gender_F_M.Female },
            new Person { Age = 37, Gender = Gender_F_M.Male }
        };

        listOfPerson.Sort();

        Console.WriteLine("Sorting using the IComparable<Person>:");
        foreach (var person in listOfPerson)
        {
            Console.WriteLine($"Age: {person.Age}, Gender: {person.Gender}");
        }

        Person[] array = listOfPerson.ToArray();
        Array.Sort(array, new PersonComparer());

        Console.WriteLine("\nSorting using the PersonComparer:");
        foreach (var person in array)
        {
            Console.WriteLine($"Age: {person.Age}, Gender: {person.Gender}");
        }
    }
}