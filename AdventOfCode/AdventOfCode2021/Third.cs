using System;
using System.Linq;
using System.Text;

namespace AdventOfCode2021
{
    public class Third
    {
        public int CalculatePowerOutput(string[] input)
        {
            var greater = new StringBuilder();
            var lower = new StringBuilder();

            for (var i = 0; i < input[0].Length; i++)
            {
                var more1s = input.Count(x => x.ElementAt<char>(i) == '1') > input.Count(x => x.ElementAt<char>(i) == '0');

                greater.Append(more1s ? "1" : "0");
                lower.Append(more1s ? "0" : "1");
            }

            return Convert.ToInt32(greater.ToString(), 2) * Convert.ToInt32(lower.ToString(), 2);
        }

        public int CalculateLifeSupport(string[] input)
        {
            var greaters = input;
            var lower = input;

            char greaterValue;
            char lowerValue;

            for(var i = 0; i < input[0].Length; i++)
            {
                greaterValue = greaters.Count(x => x.ElementAt<char>(i) == '1') >= greaters.Count(x => x.ElementAt<char>(i) == '0') ? '1' : '0';
                lowerValue = lower.Count(x => x.ElementAt<char>(i) == '1') >= lower.Count(x => x.ElementAt<char>(i) == '0') ? '0' : '1';

                if(greaters.Length > 1)
                {
                    greaters = greaters.Where(x => x.ElementAt<char>(i) == greaterValue).ToArray();
                }

                if (lower.Length > 1)
                {
                    lower = lower.Where(x => x.ElementAt<char>(i) == lowerValue).ToArray();
                }
            }

            return Convert.ToInt32(greaters[0].ToString(), 2) * Convert.ToInt32(lower[0].ToString(), 2); ;
        }
    }
}