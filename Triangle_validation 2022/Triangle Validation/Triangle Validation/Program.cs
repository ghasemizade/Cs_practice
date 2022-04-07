using System;

namespace triangle
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the three side of triangle :");
            int sideA = Convert.ToInt32(Console.ReadLine());
            int sideB = Convert.ToInt32(Console.ReadLine());
            int sideC = Convert.ToInt32(Console.ReadLine());

            if (sideA + sideB > sideC && sideA + sideC > sideB && sideC + sideB > sideA)
            {
                Console.WriteLine("this numbers create triangle :)");
            }
            else
            {
                Console.WriteLine("this numbers does not create triangle !");
            }
        }
    }
}
