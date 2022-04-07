using System;

namespace HelloWrold
{
    class Program
    {
        static void Main (string[] args)
        {
            float pi = 3.14F;
            Console.WriteLine("Enter the radius of circle :");
            float radius = Convert.ToSingle(Console.ReadLine());
            float environment = (2 * pi * radius);
            float diameter = (2 * radius);
            float area = (pi * radius * radius);
            Console.WriteLine("environment :");
            Console.WriteLine(environment);
            Console.WriteLine("diameter :");
            Console.WriteLine(diameter);
            Console.WriteLine("area :");
            Console.WriteLine(area);
        }
    }
}