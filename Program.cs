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
            String Alpabet = Console.ReadLine();

            if(Alpabet =="a"|| Alpabet=="e"|| Alpabet=="i"|| Alpabet=="o"|| Alpabet=="u") 
            {
                Console.WriteLine("Given Alphabet is vowel");
            }
            else
            {
                Console.WriteLine("Given Alphabet is Consonant");
            }
        }
    }
}