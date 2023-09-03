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
            Console.WriteLine("Enter the number ");
            int divident = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number for divisor");
            int divisor = Convert.ToInt32(Console.ReadLine());
            int Quotient = 0;
            int Reminder = 0;

            Quotient = divident / divisor;
            Reminder = divident % divisor;

            Console.WriteLine("Quotient is " + Quotient);
            Console.WriteLine("Reminder is " + Reminder);
        }
    }
}
