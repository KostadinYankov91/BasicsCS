﻿using System;

namespace _2.GenericBoxofInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Box<int> box = new Box<int>(int.Parse(Console.ReadLine()));
                //Box<string> box = new Box<string>(Console.ReadLine());
                Console.WriteLine(box);
            }
        }
    }
}
