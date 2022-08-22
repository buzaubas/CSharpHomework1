using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHomework1
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName;
            Console.WriteLine("Enter your name and surname->");
            userName = Console.ReadLine();
            Console.WriteLine($"Greeting you - {userName}");

            Console.Write('\n');

            int numberToSum1 = new int();
            int numberToSum2 = new int();
            Console.WriteLine("Enter first number->");
            numberToSum1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter second number->");
            numberToSum2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine($"Sum of two numbers: {numberToSum1 + numberToSum2}");
            Console.ReadKey();

        }
    }
}
