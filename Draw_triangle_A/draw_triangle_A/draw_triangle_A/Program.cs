using System;

namespace Triangle_A
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("enter the number side of star :");

            int numstar = Convert.ToInt32 (Console.ReadLine());

            for (int counter = 1; counter < numstar; counter++)
            {
                Console.WriteLine(" ** ");
                for (int counter1 = 0; counter1 < counter; counter1++)
                {
                    Console.Write(" *** ");
                }
            }
        }
    }
}