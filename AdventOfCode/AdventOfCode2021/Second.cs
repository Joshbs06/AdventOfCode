using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode2021
{
    public class Second
    {
        public int CalculateProductOfCoOrdinates(string[] instructions)
        {
            var up = instructions.Where(x => x.ToLower().StartsWith("up")).Sum(x => int.Parse(x.Substring(x.Length - 1, 1)));
            var down = instructions.Where(x => x.ToLower().StartsWith("down")).Sum(x => int.Parse(x.Substring(x.Length - 1, 1)));
            var forward = instructions.Where(x => x.ToLower().StartsWith("forward")).Sum(x => int.Parse(x.Substring(x.Length - 1, 1)));

            return forward * (down - up);
        }

        public int CalculateProductOfCoOrdinatesWithAim(string[] instructions)
        {
            var position = 0;
            var depth = 0;
            var aim = 0;

            foreach (var instruction in instructions)
            {
                var value = int.Parse(instruction.Substring(instruction.Length - 1, 1));

                if (instruction.ToLower().StartsWith("forward"))
                {
                    position += value;
                    depth += (aim * value);
                }
                else
                {
                    var multiplier = instruction.ToLower().StartsWith("down")
                        ? 1
                        : -1;

                    aim += (value * multiplier);
                }
            }

            return position * depth;
        }
    }
}