using System;

namespace Поиск_числа
{
    class Program
    {
        static void Main()
        {
            Console.Write("Число до которого мы ищем(оно должно бить больше 0): ");
            int until = int.Parse(Console.ReadLine());
            if (until > 0)
                Console.WriteLine("Ваше число: " + FindNumber(0, until, ((int)until / 2)));
            else Console.WriteLine("Мы так не играем :(((((((");
        }

        static int FindNumber(int from, int until, int halfNum)
        {
            if (from == until)
            {
                Console.Write("Это число " + until + "?" + "(напишите пожалуйста + или - ): ");
                string yesOrNo = Console.ReadLine();
                if (yesOrNo.Length > 0)
                    if (yesOrNo[0] == '+')
                        return until;
                    else
                        halfNum = FindNumber(from, until, halfNum);
                else
                    halfNum = FindNumber(from, until, halfNum);
            }
            else
            {
                Console.Write("Это число меньше или равно " + halfNum + " (напишите пожалуйста + или - ):  ");
                string yesOrNo = Console.ReadLine();

                if (yesOrNo[0] == '+')
                    halfNum = FindNumber(from, halfNum, ((int)(halfNum + from) / 2));
                else if (yesOrNo[0] == '-')
                    halfNum = FindNumber(halfNum + 1, until, ((int)(halfNum + until) / 2));
                else
                {
                    Console.WriteLine("+ или - пожалуйста");
                    halfNum = FindNumber(from, until, halfNum);
                }
            }
            return halfNum;
        }
    }
}
