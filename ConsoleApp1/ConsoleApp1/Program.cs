using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstFactorial ninetyFour = new FirstFactorial();
            int v = ninetyFour.getFirstFactorial("7"); // 7! = 5040

            Console.WriteLine("Hello World!");

            // keep this function call here
            Console.WriteLine(v);
            Console.WriteLine("above is my answer for 94!");
            
           
        }

    }
}
