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
            Console.WriteLine("Enter the N number: ");
            int N=Convert.ToInt32 (Console.ReadLine());

            if (0 <= N && N < 31)
            {
                for (int i = 0; i < N; i++)
                {
                    Console.WriteLine(Math.Pow(2, i));
                }
            }
            else
            {
                Console.WriteLine("Please Enter Power from 0 to 30");
            }
        }
    }
}