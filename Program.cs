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
            int fact = 1;
            for (int i = 1; i <=N; i++)
            {
                fact=fact*i;
                }
            Console.WriteLine("Factorial of " + N + " is "+fact);
            }
        }
    }
