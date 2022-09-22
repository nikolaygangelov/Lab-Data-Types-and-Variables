using System;

namespace _03._Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            decimal number;
            decimal sumOfNumber = 0;
            for (int i = 1; i <= n; i++)
            {
                number = decimal.Parse(Console.ReadLine());
                sumOfNumber += number;
            }
            Console.WriteLine(sumOfNumber);
        }
    }
}
