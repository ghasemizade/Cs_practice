using System;

namespace star
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number of star to show :");
            int star = Convert.ToInt32(Console.ReadLine());

            for (int counter = 1; counter <= star; counter++)
            {
                Console.WriteLine("*");
            }
        }
    }
}