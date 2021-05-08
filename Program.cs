using System;

namespace Поиск_числа
{
    class Program
    {
        static void Main()
        {
            Console.Write("The number we are looking for (it must be greater than 0): ");
            int until = int.Parse(Console.ReadLine());
            if (until > 0)
                Console.WriteLine("Yeeees your number is: " + FindNumber(0, until, ((int)until / 2) + "))"));

            else
                Console.WriteLine("It was offensive :(((((((");

            Console.ReadKey();
        }

        static int FindNumber(int from, int until, int halfNum)
        {
            if (from == until)
            {
                Console.Write("Your number is " + until + "?" + "(write please + or - ): ");
                string yesOrNo = Console.ReadLine();
                if (yesOrNo.Length > 0 && yesOrNo[0] == '+')
                        return until;
                else
                    halfNum = FindNumber(from, until, halfNum);
            }
            else
            {
                Console.Write("This number less or equal to " + halfNum + " (write please + or - ):  ");
                string yesOrNo = Console.ReadLine();

                if (yesOrNo[0] == '+')
                    halfNum = FindNumber(from, halfNum, ((int)(halfNum + from) / 2));
                else if (yesOrNo[0] == '-')
                    halfNum = FindNumber(halfNum + 1, until, ((int)(halfNum + until) / 2));
                else
                {
                    Console.WriteLine("+ or - please");
                    halfNum = FindNumber(from, until, halfNum);
                }
            }
            return halfNum;
        }
    }
}
