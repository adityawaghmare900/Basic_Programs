using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;

namespace Basic_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number ");
            int a =Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter the second number ");
            int b = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter the third number ");
            int c = Convert.ToInt16(Console.ReadLine());

            if(a>b && a>c)
            {
                Console.WriteLine("Fisrt number is greter");
            }
            else if(b>a && b>c)
            {
                Console.WriteLine("Second number is greter");
            }
            else
            {
                Console.WriteLine("Third number is greter");
            }
        }
    }
}