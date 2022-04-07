using System;

namespace avg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter four number to calculate avg :");

            int[] avg = new int[4];
            float temp = 0;
            float average = 0F;

            for (int counter = 0; counter < 4; counter++)
            {
                avg[counter] = Convert.ToInt32(Console.ReadLine());
                temp += avg[counter];
            }
            average = temp / 4;
            Console.WriteLine(average);
        }
    }
}