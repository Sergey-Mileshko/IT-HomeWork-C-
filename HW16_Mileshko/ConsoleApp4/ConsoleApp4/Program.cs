using System;
using System.Collections.Generic;

class FitnessCenter
{
    static void Main()
    {
        Console.WriteLine("HW16_ex4_Mileshko");

        List<int[]> clientsData = new List<int[]>();

        clientsData.Add(new int[] { 2020, 1, 2, 11 });
        clientsData.Add(new int[] { 2023, 1, 3, 12 });
        clientsData.Add(new int[] { 2018, 2, 1, 3 });
        clientsData.Add(new int[] { 2024, 1, 4, 14 });
        clientsData.Add(new int[] { 2021, 1, 2, 9 });
        clientsData.Add(new int[] { 2018, 2, 3, 8 });
        clientsData.Add(new int[] { 2023, 2, 4, 7 });
        clientsData.Add(new int[] { 2022, 2, 2, 5 });
        clientsData.Add(new int[] { 2024, 2, 3, 9 });
        clientsData.Add(new int[] { 2020, 2, 1, 10 });
        clientsData.Add(new int[] { 2021, 2, 2, 11 });
        clientsData.Add(new int[] { 2023, 2, 4, 12 });
        clientsData.Add(new int[] { 2024, 2, 1, 13 });
        clientsData.Add(new int[] { 2022, 2, 3, 14 });
        clientsData.Add(new int[] { 2023, 2, 3, 13 });
        clientsData.Add(new int[] { 2020, 2, 1, 10 });
        clientsData.Add(new int[] { 2020, 2, 2, 11 });
        clientsData.Add(new int[] { 2021, 2, 4, 12 });
        clientsData.Add(new int[] { 2018, 2, 1, 13 });
        clientsData.Add(new int[] { 2022, 2, 3, 15 });


        Dictionary<int, int> totalDurationByYear = new Dictionary<int, int>();

        foreach (int[] clientData in clientsData)
        {
            int year = clientData[0];
            int duration = clientData[2];

            if (totalDurationByYear.ContainsKey(year))
            {
                totalDurationByYear[year] += duration;
            }
            else
            {
                totalDurationByYear[year] = duration;
            }
        }

        int maxDuration = 0;
        int maxYear = int.MaxValue;

        foreach (KeyValuePair<int, int> entry in totalDurationByYear)
        {
            int year = entry.Key;
            int duration = entry.Value;

            if (duration > maxDuration || (duration == maxDuration && year < maxYear))
            {
                maxDuration = duration;
                maxYear = year;
            }
        }

        Console.WriteLine("The year with the highest total duration of classes: " + maxYear);
        Console.WriteLine("The highest total duration: " + maxDuration + " hours");
    }
}