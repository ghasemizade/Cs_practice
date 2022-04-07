using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter two number for calcute product :");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int pro1 = 0;
            for (int counter = 1; counter <= num2; counter++)
            {
                pro1 += num1;
            }
            Console.WriteLine(pro1);
        }
    }
}