namespace Basic_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
           int HeadOrTails=random.Next(0, 2);
            
            if (HeadOrTails < 0.5)
            {
                Console.WriteLine("Tails");
            }
            else
            {
                Console.WriteLine("Head");

            }
        }
    }
}