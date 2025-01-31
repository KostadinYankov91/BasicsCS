﻿using System;


namespace kamino
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string input = string.Empty;
            int counter = 0;
            int bestCount = 0;
            int bestCounter = 0;
            int bestBeginIndex = 0;
            int bestSum = 0;
            string bestSequence = "";

            while ((input = Console.ReadLine()) != "Clone them")
            {
                string sequence = input.Replace("!", "");

                string[] dnaParts = sequence.Split("0", StringSplitOptions.RemoveEmptyEntries);

                int count = 0;
                int sum = 0;
                string bestSubsequence = "";
                counter++;

                foreach (var dnaPart in dnaParts)
                {
                    if (dnaPart.Length > count)
                    {
                        count = dnaPart.Length;
                        bestSubsequence = dnaPart;
                    }

                    sum += dnaPart.Length;
                }

                int beginIndex = sequence.IndexOf(bestSubsequence);

                if (count > bestCount 
                    || (count == bestCount && beginIndex < bestBeginIndex) 
                    || (count == bestCount && beginIndex == bestBeginIndex && sum > bestSum)
                    || counter == 1)

                {
                    bestCount = count;
                    bestSequence = sequence;
                    bestBeginIndex = beginIndex;
                    bestSum = sum;
                    bestCounter = counter;
                }
            }

            char[] result = bestSequence.ToCharArray();

            Console.WriteLine($"Best DNA sample {bestCounter} with sum: {bestSum}.");
            Console.WriteLine($"{string.Join("", result)} ");

        }
    }
}
