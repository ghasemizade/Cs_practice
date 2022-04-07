using System;

namespace subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int div1 = 0;
            int mod = num1;
            for (int counter = 0;; counter++)
                if (mod >= num2)
                {
                    div1++;
                    mod -= num2;
                }
                else
                {
                    break;
                }
            Console.WriteLine(div1);
        }
    }
}