using System;

namespace Exp10
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = null;

            try
            {
                Console.WriteLine("Length Of Name=" + name.Length);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Exception caught !");
                Console.WriteLine("Message :" + ex.Message);
            }
            finally
            {
                Console.WriteLine("Program Ended Successfully");
                Console.ReadKey();
            }
        }
    }
}