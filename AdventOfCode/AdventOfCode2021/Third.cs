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
    }
}