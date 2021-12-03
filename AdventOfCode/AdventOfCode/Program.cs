﻿using System;
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
            //First();
            Second();
        }

        private static void First()
        {
            Console.WriteLine("1st December 2021 \n");

            var listOfInts = WriteFirstFile();
            var first2021 = new First();
            var amountOfIncreases = first2021.CalculateAmountOfIncreases(listOfInts);
            var amountSumOf3Increases = first2021.CalculateAmountOfSumIncreases(listOfInts);

            Console.WriteLine($"There are {amountOfIncreases} increases");
            Console.WriteLine($"There are {amountSumOf3Increases} sum of 3 increases");
        }

        private static void Second()
        {
            Console.WriteLine("2nd December 2021 \n");

            var listOfInstructions = WriteSecondFile();
            var first2021 = new Second();
            var productOfCoOrdinates = first2021.CalculateProductOfCoOrdinates(listOfInstructions);
            var productOfCoOrdinatesWithAim = first2021.CalculateProductOfCoOrdinatesWithAim(listOfInstructions);

            Console.WriteLine($"The product of co ordinates is {productOfCoOrdinates}");
            Console.WriteLine($"The product of co ordinates is {productOfCoOrdinatesWithAim}");
        }

        private static List<int> WriteFirstFile()
        {
            return File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, "Resources/2021/FirstDecember.txt")).Select(int.Parse).ToList();
        }

        private static string[] WriteSecondFile()
        {
            return File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, "Resources/2021/SecondDecember.txt")).ToArray();
        }
    }
}