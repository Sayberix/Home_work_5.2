using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            // Программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

            Console.WriteLine("Введите номер дня недели (от 1 до 7):");
            int  dayOfWeek= Convert.ToInt32(Console.ReadLine());
            if (dayOfWeek >= 1 && dayOfWeek <= 7)
            {
                if(dayOfWeek >= 1 && dayOfWeek <= 5)
                    Console.Write("Заданный день недели не является выходным!");
                else
                    Console.Write("Заданный день недели является выходным!");
            }
            else
                Console.WriteLine("Неверно введенный день недели!");
        }
    }
}
