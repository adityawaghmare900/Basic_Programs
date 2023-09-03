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
            int Num1 = Convert.ToInt32(Console.ReadLine());

            if (Num1 % 2 == 0)
            {
                Console.WriteLine("Given number is Even");
            }
            else
            {
                Console.WriteLine("Given number is Odd");
            }
        }
    }
}