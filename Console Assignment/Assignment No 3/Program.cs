using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exp3
{
    class Program
    {
        static void swap(int a,int b)
        {
            int Temp = a;
            a = b;
            b = Temp;

            Console.WriteLine("Inside Function");
            Console.WriteLine("A = " + a);
            Console.WriteLine("B = " + b);
        }
        static void Main(string[] args)
        {
            int x = 10;

            int y = 20;

            Console.WriteLine("Before Swapping ");

            Console.WriteLine(" X =" + x);

            Console.WriteLine(" Y = " + y);

            swap(x, y);

            Console.WriteLine("\n After Function Call :");

            Console.WriteLine(" X = " + x);

            Console.WriteLine(" Y = " + y);

            Console.ReadKey();
        }
    }
}
