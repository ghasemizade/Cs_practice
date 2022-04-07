using System;

namespace OddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter two number for calculate product of between odd number :");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int sum2  = 0;
            int sum1 = 0;

            if (num1 > num2)
            {
                for (int counter = num2; counter < num1; counter++)
                {
                    if (counter % 2 == 1)
                    {
                        sum1 *= counter;
                    }
                }
                Console.WriteLine(sum1);
            }
            if (num1 < num2)
            {
                for (int counter = num1; counter < num2; counter++)
                {
                    if (counter % 2 == 1)
                    {
                        sum2 *= counter;
                    }
                }
                Console.WriteLine(sum2);
            }
        }
    }
}