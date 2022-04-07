using System;

namespace Divine_Proportion
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("enter number to Divine Proportion :");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(number / 1.618);
            Console.WriteLine(number * 1.618);
        }
    }
}