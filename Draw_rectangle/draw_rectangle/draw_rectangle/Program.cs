using System;

namespace square
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("height :");
            int side = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("width :");
            int side1 = Convert.ToInt32(Console.ReadLine());
            int counter = 0;
            for (int height = 0; height < side; height++)
            {
                for (int width = 0; width < side1; width++)
                {
                    if (height == counter)
                        Console.Write("*");
                    else
                        Console.Write("*");
                }
                counter++;

                Console.WriteLine();
            }
            Console.WriteLine();

        }
    }
}