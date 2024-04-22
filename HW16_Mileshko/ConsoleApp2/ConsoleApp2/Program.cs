using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("HW16_ex2_Mileshko \n");

        List<string> A = new List<string> { "Hello", "here", "we", "are" };
        List<char> result = GetInitialCharacters(A);

        Console.WriteLine("Result:");
        foreach (char character in result)
        {
            Console.WriteLine(character);
        }
        Console.ReadKey();
    }

    static List<char> GetInitialCharacters(List<string> strings)
    {
        List<char> characters = new List<char>();

        for (int i = strings.Count - 1; i >= 0; i--)
        {
            string str = strings[i];
            if (!string.IsNullOrEmpty(str))
            {
                characters.Add(str[0]);
            }
        }

        return characters;
    }
    
}