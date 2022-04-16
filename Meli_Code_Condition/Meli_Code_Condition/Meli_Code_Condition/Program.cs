using System;

namespace Condition_Code
{
    class Program
    {
        static void Main ()
        {
            
            int Nat_Code;
            Console.WriteLine("Enter the natinal Code :");
            string Code = (Console.ReadLine());
            Nat_Code = Convert.ToInt32(Code[9]);

            int A, B, C;


            switch (Code)
            {
                case "0000000000":
                case "1111111111":
                case "22222222222":
                case "33333333333":
                case "4444444444":
                case "5555555555":
                case "6666666666":
                case "7777777777":
                case "8888888888":
                case "9999999999":
                    Console.WriteLine("this natinal Code incorrect...!");
                    break;
            }

            A = Code[9];
            B = ((((((((Code[0] * 10) + (Code[1] * 9)) + (Code[2] * 8)) + (Code[3] * 7)) + (Code[4] * 6)) + (Code[5] * 5)) + (Code[6] * 4)) + (Code[7] * 3)) + (Code[8] * 2);
            C = B - ((B / 11) * 11);

            if ((((C == 0) && (A == C)) || ((C == 1) && (A == 1))) || ((C > 1) && (A == Math.Abs((int)(C - 11)))))
            {
                Console.WriteLine("this natinal code is true.");
            }
            else
            {
                Console.WriteLine("this natinal code incorrect...!");
            }
        }
    }
}
