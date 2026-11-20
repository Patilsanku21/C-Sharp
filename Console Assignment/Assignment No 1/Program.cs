using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ep1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a Number");

            int Num = Convert.ToInt32(Console.ReadLine());

            if(Num %2 == 0)
            {
                Console.WriteLine(Num + "is Divisible By 2");
            }
            else
            {
                Console.WriteLine(Num + "is Not Divisible By 2");
            }
            Console.ReadKey();


        }
    }
}
