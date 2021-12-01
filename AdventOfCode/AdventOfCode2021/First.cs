using System;
using System.Collections.Generic;

namespace AdventOfCode2021
{
    public class First
    {
        public int CalculateAmountOfIncreases(List<int> values)
        {
            int amountOfIncreases = 0;

            for (int i = 1; i < values.Count; i++)
            {
                if (values[i] > values[i - 1])
                {
                    amountOfIncreases++;
                }
            }

            return amountOfIncreases;
        }

        public int CalculateAmountOfSumIncreases(List<int> values)
        {
            int amountOfSumIncreases = 0;

            for (int i = 1; i < (values.Count - 2); i++)
            {
                amountOfSumIncreases += (SumOf3Values(values[i - 1], values[i], values[i + 1]) < SumOf3Values(values[i], values[i + 1], values[i + 2]))
                    ? 1
                    : 0;
            }

            return amountOfSumIncreases;
        }

        private int SumOf3Values(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}