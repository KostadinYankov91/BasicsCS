﻿using System;
using System.Linq;

namespace матриьСхуффлинг
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int n = dimensions[0];
            int m = dimensions[1];

            string[,] matrix = new string[n, m];

            for (int row = 0; row < n; row++)
            {
                string[] rowData = Console.ReadLine().Split(" ");

                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            string command;

            while ((command = Console.ReadLine()) != "END")
            {

                string[] commandData = command.Split(" ");

                if (commandData.Length != 5 || commandData[0] != "swap")
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                int rowOne = int.Parse(commandData[1]);
                int colOne = int.Parse(commandData[2]);
                int rowTwo = int.Parse(commandData[3]);
                int colTwo = int.Parse(commandData[4]);

                bool isValidOne = IsValidCell(rowOne, colTwo, n, m);
                bool isValidTwo = IsValidCell(rowTwo, colTwo, n, m);

                if (!isValidOne || !isValidTwo)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                string valueOne = matrix[rowOne, colOne];
                string valueTwo = matrix[rowTwo, colTwo];

                matrix[rowOne, colOne] = valueTwo;
                matrix[rowTwo, colTwo] = valueOne;

                PrintMatrix(matrix);

                //bool isOutOfMatrix = rowOne < 0 || rowOne >= n || colOne < 0 || colOne >= m;


            }
        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }

        private static bool IsValidCell(int row, int col, int n, int m)
        {
            return row >= 0 && row < n && col >= 0 && col < m;
        }

    }
}
