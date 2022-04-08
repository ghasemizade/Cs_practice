using System;

namespace Triangle_Z
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number side of star :");

            int numstar = Convert.ToInt32(Console.ReadLine());
            int counter1;
            for (int counter = numstar; counter > 0; counter--)
            {
                for (counter1 = 0; counter1 < counter; counter1++)
                {
                    Console.Write("* ");
                }
                Console.Write("\n");
                
                for (int counter2 = 0; counter2 < counter1; counter2++)
                {
                    Console.Write("");
                }
            }
            Console.Write("\n");
        }
    }
}