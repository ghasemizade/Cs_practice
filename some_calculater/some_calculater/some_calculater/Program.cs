using System;

namespace calculate
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("enter the number till to calculate :");
            int inputuser = Convert.ToInt32(Console.ReadLine());
            int sum = 1;
            
            int[] MyArray;
            MyArray = new int[inputuser];
            int counter = 0;
            int count = 0;
            Console.WriteLine("entered :");
            while (counter < inputuser)
            {
                MyArray[counter] = Convert.ToInt32(Console.ReadLine());
                sum += MyArray[counter];
                count++;
                counter++;
            }
            Console.WriteLine("number of input user :");
            Console.WriteLine(count);

            int min = MyArray[0];
            int max = MyArray[0];

            for (int i = 0; i < inputuser; i++)
            {
                if (MyArray[i] < min)
                {
                    min = MyArray[i];
                }
                if (MyArray[i] > max)
                {
                    max = MyArray[i];
                }
            }
            Console.WriteLine("minimum number in this aray :");
            Console.WriteLine(min);
            Console.WriteLine("maximum number in this aray :");
            Console.WriteLine(max);

            float avg;

            avg = sum / count;
            Console.WriteLine("avrage of numbers :");
            Console.WriteLine(avg);

            int submission, power, division;
            int variance = 0;

            for (int i = 1; i < inputuser; i++)
            {
                submission = Convert.ToInt32(MyArray[i] - avg);
                power = (submission * submission);
                division = power / count;
                variance += division;
            }
            Console.WriteLine("variance :");
            Console.WriteLine(variance);
        }
    }
}