using System;
public class DrawHollowSquare
{
    public static void Main(string[] args)
    {
        Console.WriteLine("please enter char for draw rectangle :");
        char symbol = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("enter the side of rectangle :");
        int side = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < side; i++)
        {
            Console.Write(symbol);
            //Console.Write(" ");
        }

        Console.WriteLine();

        for (int i = 0; i < side - 2; i++)
        {
            Console.Write(symbol);

            for (int j = 0; j < side - 2; j++)
            {
                Console.Write(" ");
            }

            Console.WriteLine(symbol);
        }

        for (int i = 0; i < side; i++)
        {
            Console.Write(symbol);
            //Console.Write(" ");
        }

        Console.WriteLine();
    }
}