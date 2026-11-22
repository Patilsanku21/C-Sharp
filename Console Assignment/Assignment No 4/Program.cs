using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num = 100;
            object obj = Num;

            Console.WriteLine(" After Boxing : ");

            Console.WriteLine(" Value Of Num    = " + Num);
            Console.WriteLine(" Value Of Object = " + obj);

            int result = (int)obj;

            Console.WriteLine("\n After Unboxing :");
            Console.WriteLine(" Value Of Result = " + result);

            Console.ReadKey();
        }
    }
}
