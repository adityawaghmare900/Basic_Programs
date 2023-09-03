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
            int N=Convert.ToInt16 (Console.ReadLine());
            float Harmonic = 0.0f;

            for(int i=1;i<=N; i++) {
                Harmonic += (float)1 / i ;
                Console.Write(Harmonic+" , ");
            }
            
        }
    }
}