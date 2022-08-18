using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int multiplying = int.Parse(Console.ReadLine());
            for (int times = 1; times <= 10; times++)
            {
                Console.WriteLine($"{multiplying} X {times} = {multiplying * times}");
            }
        }
    }
}
