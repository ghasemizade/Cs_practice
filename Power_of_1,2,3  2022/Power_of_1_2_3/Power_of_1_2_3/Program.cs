using System;

namespace POWER
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number till to power of the 1,2,3 :");
            int num = Convert.ToInt32(Console.ReadLine());
            double pow1 = Math.Pow(num, 1);
            double pow2 = Math.Pow(num, 2);
            double pow3 = Math.Pow(num, 3);

            Console.WriteLine(pow1);
            Console.WriteLine(pow2);
            Console.WriteLine(pow3);
        }
    }
}