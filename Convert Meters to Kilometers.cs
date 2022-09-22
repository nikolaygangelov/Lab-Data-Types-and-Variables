using System;

namespace _1._Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanceInMeterss = int.Parse(Console.ReadLine());
            float distanceInKm = distanceInMeterss / 1000f;
            Console.WriteLine($"{distanceInKm:f2}");
        }
    }
}
