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
            int Num1= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            int Num2 = Convert.ToInt32(Console.ReadLine());

            Num1 = Num1 + Num2;
            Num2 = Num1 - Num2;
            Num1 = Num1 - Num2;
            Console.WriteLine("first number after swap " + Num1);
            Console.WriteLine("second number after swap "+Num2);
        }
    }
}
