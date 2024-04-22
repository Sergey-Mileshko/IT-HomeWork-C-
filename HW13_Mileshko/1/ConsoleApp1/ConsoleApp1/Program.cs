using System;
using System.Collections.Generic;

class Program
{
    static IEnumerable<string> GetWordsGreaterThanFive(string[] words)
    {
        foreach (var word in words)
        {
            if (word.Length > 5)
            {
                yield return word;
            }
        }
    }

    static string[] GenerateRandomWords(int count)
    {
        Dictionary<int, string> wordDictionary = new Dictionary<int, string>()
        {
            { 1, "School backpack" },
            { 2, "Pencil" },
            { 3, "Ruler" },
            { 4, "Textbook" },
            { 5, "Mobile phone" },
            { 6, "Money" },
            { 7, "Ball" },
            { 8, "Hat" },
            { 9, "Glasses" },
            { 10, "Sun glasses" }
        };

        Random random = new Random();
        List<string> randomWords = new List<string>();

        while (randomWords.Count < count)
        {
            int randomKey = random.Next(1, wordDictionary.Count + 1);
            string randomWord = wordDictionary[randomKey];

            if (!randomWords.Contains(randomWord))
            {
                randomWords.Add(randomWord);
            }
        }

        return randomWords.ToArray();
    }

    static void Main(string[] args)
    {

        Console.WriteLine("HW13_ex1_Mileshko \n");
        string[] randomWords = GenerateRandomWords(3);

        Console.WriteLine("Words randomWords:");

        foreach (string s in randomWords) Console.Write(s + " ");
        Console.WriteLine(" ");

        Console.WriteLine("\nWords longer than 5 characters:");

        foreach (var word in GetWordsGreaterThanFive(randomWords))
        {
            Console.WriteLine(word);
        }
        Console.ReadLine();
    }
}