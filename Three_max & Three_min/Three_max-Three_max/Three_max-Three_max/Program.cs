using System;

namespace calculate
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("enter the number till to calculate :");
            int inputuser = Convert.ToInt32(Console.ReadLine());


            int[] MyArray;
            MyArray = new int[inputuser];
            int counter = 1;

            Console.WriteLine("entered :");

            while (counter < inputuser)
            {
                MyArray[counter] = Convert.ToInt32(Console.ReadLine());
                counter++;
            }
            int i, firstmax, secondmax, thirdmax;
            int firstmin = int.MaxValue;
            int secondmin = int.MaxValue;
            int thirdmin = int.MaxValue;

            if (MyArray.Length < 3)
            {
                Console.WriteLine("Invalid Input");
            }
            thirdmax = firstmax = secondmax = 000;

            for (i = 0; i < MyArray.Length; i++)
            {
                if (MyArray[i] > firstmax)
                {
                    thirdmax = secondmax;
                    secondmax = firstmax;
                    firstmax = MyArray[i];
                }

                else if (MyArray[i] > secondmax)
                {
                    thirdmax = secondmax;
                    secondmax = MyArray[i];
                }

                else if (MyArray[i] > thirdmax)
                {
                    thirdmax = MyArray[i];
                }
                if (MyArray[i] < firstmin)
                {
                    thirdmin = secondmin;
                    secondmin = firstmin;
                    firstmin = MyArray[i];
                }
                else if (MyArray[i] < secondmin)
                {
                    thirdmin = secondmin;
                    secondmin = MyArray[i];
                }
                else if (MyArray[i] < thirdmin)
                    thirdmin = MyArray[i];
            }
            Console.WriteLine("three largest elements are " + firstmax + "," + secondmax + "," + thirdmax);
            Console.WriteLine("three smallest elements are " + firstmin + "," + secondmin + "," + thirdmin);
        }
    }
}
