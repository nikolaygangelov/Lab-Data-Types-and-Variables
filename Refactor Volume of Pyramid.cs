﻿using System;

namespace _11._Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            
            double volume = (length * width * height)/3;
            Console.WriteLine($"Length: {length}Width: {width}Height: {height}Pyramid Volume: {volume:f2}");

        }
    }
}
