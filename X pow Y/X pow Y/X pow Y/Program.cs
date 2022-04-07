using System;

namespace XPOWERY
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter two numbers till to X power of Y :");
            int numX = Convert.ToInt32(Console.ReadLine());
            int numY = Convert.ToInt32(Console.ReadLine());
            double powXY = Math.Pow(numX,numY);

            Console.WriteLine(powXY);
        }
    }
}