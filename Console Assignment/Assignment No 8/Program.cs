using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exp8
{
    abstract class Shape
    {
        public abstract void Area();
    }
    class Circle : Shape
    {
        public override void Area()
        {
            double r = 5;
            double area = Math.PI * r * r;
            Console.WriteLine("Area Of Circle = " + area);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            c.Area();
            Console.ReadKey();
        }
    }
}
