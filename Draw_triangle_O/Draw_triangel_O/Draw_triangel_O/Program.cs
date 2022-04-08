using System;

namespace Triangle_O
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number side of star :");

            int numstar = Convert.ToInt32(Console.ReadLine());

            for (int counter = numstar; counter >=1; --counter)
            {
                //Console.WriteLine(" ** ");
                for (int counter1 = 1; counter1 < counter; ++counter1)
                {
                    Console.Write("*");
                }
                Console.WriteLine("\n");
            }
        }
    }
}