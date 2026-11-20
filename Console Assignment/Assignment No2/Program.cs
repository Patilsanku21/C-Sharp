using System;

namespace exp2
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please provide a number as a command-line argument.");
                return;
            }

            int num = Convert.ToInt32(args[0]);
            int sum = 0;

            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }

            if (sum == num)
            {
                Console.WriteLine(num + " is a Perfect Number.");
            }
            else
            {
                Console.WriteLine(num + " is not a Perfect Number.");
            }

            Console.ReadKey();
        }
    }
}