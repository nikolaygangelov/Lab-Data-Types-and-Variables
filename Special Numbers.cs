using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int numCopy;
            int digitSum = 0;
            for (int i = 1; i <= n; i++)
            {
                numCopy = i;
                while (numCopy > 0)
                {
                    int lastDigit = numCopy % 10;
                    digitSum += lastDigit;
                    numCopy /= 10;

                }
                if (digitSum == 5 || digitSum == 7 || digitSum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
                digitSum = 0;
            }
        }
    }
}
