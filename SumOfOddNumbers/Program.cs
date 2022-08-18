using System;

namespace SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfOddNumbers = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < countOfOddNumbers; i++)
            {
                int currentOddNumber = 1 + (i * 2);
                Console.WriteLine(currentOddNumber);
                sum += currentOddNumber;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
