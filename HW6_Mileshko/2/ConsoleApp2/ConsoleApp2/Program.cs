public class Program
{
   
        public static int[,] SumArray(int[,] a, int[,] b)
        {
            int[,] result = new int[a.GetLength(0), a.GetLength(1)];

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    result[i, j] = a[i, j] + b[i, j];
                }
            }
            return result;
        }
        private static void Main(string[] args)
        {
        Console.WriteLine("HW6_ex2_Mileshko");

            int[,] a = new int[2, 2] { { 1, 4 }, { 2, 3 } };
        
            int[,] b = new int[2, 2] { { 4, 4 }, { 5, 2 } };


            int[,] sum = SumArray(a, b);
        Console.WriteLine("Result A+B:");

        for (int i = 0; i < sum.GetLength(0); i++)
            {
                for (int j = 0; j < sum.GetLength(1); j++)
                {
                    Console.Write(sum[i, j] + " ");
                }
                Console.WriteLine();
          
            }
        }
    }