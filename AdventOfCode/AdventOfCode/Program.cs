using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using AdventOfCode2021;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Advent of Code \n");
            First();
        }

        private static void First()
        {
            Console.WriteLine("!st December 2021 \n");

            var listOfInts = WriteFileToListOfInts();
            var first2021 = new First();
            var amountOfIncreases = first2021.CalculateAmountOfIncreases(listOfInts);
            var amountSumOf3Increases = first2021.CalculateAmountOfSumIncreases(listOfInts);

            Console.WriteLine($"There are {amountOfIncreases} increases");
            Console.WriteLine($"There are {amountSumOf3Increases} sum of 3 increases");
        }

        private static List<int> WriteFileToListOfInts()
        {
            return File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, "Resources/2021/FirstDecember.txt")).Select(int.Parse).ToList();
        }
    }
}