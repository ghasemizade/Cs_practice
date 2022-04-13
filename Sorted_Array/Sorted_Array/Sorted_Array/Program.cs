using System;
namespace sorted
{
    class Program
    {
        static void Main ()
        {
            Console.WriteLine ("Do you want Ascending sort press 'a' , 'A' or Desending sort press 'd' , 'D' :");
            char sorting = Convert.ToChar (Console.ReadLine ());

            Console.WriteLine("Enter the number of array :");

            int input = Convert.ToInt32(Console.ReadLine());
            int[] myarray = new int[input];
            Console.WriteLine("enter element of array :");
            for (int i = 0; i < input; i++)
            {
                myarray[i] = Convert.ToInt32(Console.ReadLine()); 
            }

            Console.WriteLine("\n\n");

            Console.WriteLine("Original array");
            foreach (int i in myarray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            if (sorting == 'a' || sorting == 'A')
            {
               Array.Sort (myarray);
                Console.WriteLine("Ascending sort");
                foreach (int i in myarray)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();

            if (sorting == 'd' || sorting == 'D')
            {
                Array.Reverse(myarray);
                Console.WriteLine("Desending sort");
                foreach (int i in myarray)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();

        }
    }
}