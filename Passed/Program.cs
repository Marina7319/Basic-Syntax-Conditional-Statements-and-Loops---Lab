using System;

namespace Passed
{
    class Program
    {
        static void Main(string[] args)
        {
            float grade = float.Parse(Console.ReadLine());
            float sum = grade;
            string result = "";
            if (sum < 3.00)
            {
                result = "Failed!";
            }
            else if (sum < 2.00)
            {
                result = "Too Small!";
            }
            else if (sum > 6.50)
            {
                result = "Too Big!";
            }
            else if (sum >= 3.00 && sum <= 6.50)
            {
                result = "Passed!";
            }
            Console.WriteLine(result);
        }
    }
}

