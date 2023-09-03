using System.ComponentModel;
using System.Globalization;

namespace Basic_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year % 100 == 0 && year % 400 == 0 || year % 100 != 0 && year % 4 == 0)
            {
                Console.WriteLine(year + " Is leap year");
            }
            else
            {
                Console.WriteLine(year + " Is not leap year");
            }
        }
    }
}