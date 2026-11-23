using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exp5
{
    class A
    {
        public int a = 200, b = 100, c;
        public void Add()
        {
            c = a + b;

            Console.WriteLine(" Addition Result :" + c);
        }
    }
    class B : A
    {
        public void Sub()
        {
            c = a - b;

            Console.WriteLine(" Substraction Result :" + c);
        }
    }
    class  C : B
    {
       public void Mult()
        {
            c = a * b;

            Console.WriteLine(" Multiplication Result :" + c);

        }
    }
    class D : C
    {
        public void Div()
        {
            c = a / b;

            Console.WriteLine(" Division Result :" + c);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            D obj = new D();

            obj.Add();
            obj.Sub();
            obj.Mult();
            obj.Div();
            Console.ReadKey();
        }
    }
}
