/*
 * File:            Advent of Code 2020 - Day 1
 * Description:     Given a list of numbers, find the two that sum to 2020. Then
 *                  multiply them to get the product. Extended to find 3 numbers 
 *                  for part 2 of day 1.
 * Date:            12/19/2020
 * Programmer:      Ian Ewing
 */

using System;
using System.IO;

namespace D1P1
{
    class Program
    {
        const int kSum = 2020;
        static void Main(string[] args)
        {
            //Grab our text file
            string[] lines = File.ReadAllLines(@"C:\temp\input.txt");

            int sum = checkNums(lines);
            Console.WriteLine($"Sum is {sum}");
        }


        /// <summary>
        /// Finds three numbers that sum to 2020 and returns their product
        /// </summary>
        /// <param name="lines">Array of strings. Represents numbers ripped from a .txt</param>
        /// <returns>int - 0 if no answer found, product of 3 numbers otherwise</returns>
        static int checkNums(string[] lines)
        {
            int key = 0;
            int value = 0;
            int answer = 0;
            //Iterate through each number checking them to see if they sum to 2020
            //If so, get the proudct and return it.
            foreach (var line in lines)
            {
                key = Int32.Parse(line);
                foreach (var line2 in lines)
                {
                    value = Int32.Parse(line2);
                    foreach (var line3 in lines)
                    {
                        int otherThing = Int32.Parse(line3);
                        if (key + value + otherThing == kSum)
                        {
                            answer = key * value * otherThing;
                            return answer;
                        }
                    }
                    
                }
            }
            return 0;
        }
    }
}
