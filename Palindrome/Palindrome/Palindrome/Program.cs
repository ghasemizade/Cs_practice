using System;

namespace Plindrome
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("enter the number :");
            int inputuser = Convert.ToInt32(Console.ReadLine());

            int Tempnumber = inputuser;
            int mod;
            int revers = 0;

            if (inputuser < 0)
            {
                Console.WriteLine("false");
            }

            while (inputuser != 0)
            {
                mod = inputuser % 10;
                revers = revers * 10 + mod;
                inputuser /= 10;
            }
            if (Tempnumber == revers)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}