using System;

namespace square
{
    class Program
    {
        static void Main(string[] args)
        {
                int side = Convert.ToInt32(Console.ReadLine());
                int counter = 0;
                for (int height = 0; height < side/2; height++)
                {
                    for (int width = 0; width < side; width++)
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