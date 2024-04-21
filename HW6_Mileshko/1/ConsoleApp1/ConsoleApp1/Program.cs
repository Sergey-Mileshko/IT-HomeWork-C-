internal class Program
{
   
        public static string[] AddValueToArray(string[] array, string value)
    {
        bool b_Add = false;
        if (array == null || string.IsNullOrEmpty(value))
        {
            return array;
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != null)
            {
                if (array[i].ToUpper() == value.ToUpper())
                {
                    return array;
                }
            }

        }

        foreach (string S in array)
        {
            if (S != null)
            {
                if (S.ToUpper() == value.ToUpper())
                {
                    return array;
                }
            }
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (string.IsNullOrEmpty(array[i]))
            {
                array[i] = value;
                b_Add = true;
                return array;
            }
        }


        if (!b_Add)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = value;
        }
        return array;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("HW6_ex1_Mileshko");
        Console.WriteLine("Words:");
        string[] array = { "banana", "orange", "egg", "pasta", "pineapple" };

        array = AddValueToArray(array, "");
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
        Console.WriteLine("Number of words:"); ;
        Console.WriteLine(array.Length);
        Console.ReadLine();

        Console.ReadKey();

    }


}


