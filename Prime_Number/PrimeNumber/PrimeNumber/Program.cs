using System;

namespace primenumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number to check PrimeNumber :");
            int inputuser = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int temp = inputuser / 2;
            int newtemp = 0;
            for (int counter = 2; counter <= temp; counter++)
            {
                if (inputuser % counter == 0)
                {
                    Console.WriteLine("No");
                    newtemp = 1;
                    break;
                }
            }
            if (newtemp == 0)
            {
                Console.WriteLine("Yes");
            }
        }
    }
}