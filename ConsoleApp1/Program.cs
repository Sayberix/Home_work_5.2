using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            // Программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
            int number = new Random().Next(100, 1000);
            Console.WriteLine($"Рандомное число: {number}");
            Console.WriteLine(digitTwo(number));

            int digitTwo(int number)
            {
                return (number % 100 / 10);
            }
        }
    }
}
