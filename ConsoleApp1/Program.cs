using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            // Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
 
            Console.WriteLine("Введите трехзначное число:");
            int number = Convert.ToInt32(Console.ReadLine());
            if ((number / 100) < 1)
                Console.WriteLine("У данного числа третьей цифры нет!");
            else
            {
                Console.Write("Третья цифра в заданом числе: " + digitThird(number));

                int digitThird(int number)
                {
                    return (number % 10);
                }
            }
        }
    }
}
