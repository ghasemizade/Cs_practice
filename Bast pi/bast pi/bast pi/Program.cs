using System;

namespace Bastpi
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("enter the number to calculate bastpi :");
            int number = Convert.ToInt32(Console.ReadLine());
            float pi = 3.14F;

            double circumference = 2 * pi * number;
            pi = Convert.ToInt64(circumference / number);

            Console.WriteLine(pi);

        }
    }
}