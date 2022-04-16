using System;

namespace charbetweennumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number :");
            int inputuser = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the char :");
            char symbol = Convert.ToChar(Console.ReadLine());

            int modnum, inputrevers = 0; 


            for (int i = inputuser; 0 < inputuser; i++)
            {
                modnum = inputuser % 10;
                inputrevers = inputrevers * 10 + modnum;
                inputuser /= 10;
                
            }

            for (int i = inputrevers; 0 < inputrevers; i++)
            {
                modnum = inputrevers % 10;
                inputrevers /= 10;
                Console.Write(inputrevers);
                Console.Write(symbol);
            }
            
            


            /*while (inputuser > 0)
            {
                savenum = inputuser % 10;
                savenum /= 10;
                inputrevers = inputuser * 10 + savenum;

            }

            while (inputrevers > 0)
            {
                savenum = inputrevers % 10;
                inputrevers /= 10;

                Console.Write(savenum);
                Console.Write(symbol);
            }*/
        }
    }
}