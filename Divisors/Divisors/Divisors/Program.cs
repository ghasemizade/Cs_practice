using System;

namespace divisor
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("enter the number :");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int counter = 1; counter <= number; counter++)
            {
                if (number % counter == 0)
                {
                    Console.WriteLine(counter);
                }
            }
        }
    }
}