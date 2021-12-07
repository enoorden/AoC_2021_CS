using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Day07
{
    class Day07
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            Console.WriteLine("Day7 C#");

            var fInput = File.ReadAllLines(@"..\..\..\input07.txt");
            var input = fInput[0].Split(",").Select(int.Parse).ToList();

            //Part1
            var lowest = double.MaxValue;
            double fuel = 0;
            for (var i = 1; i <= input.Count; i++)
            {
                fuel = 0;
                for (var j = 0; j < input.Count; j++)
                {
                    fuel += Math.Abs(i - input[j]);
                }

                if (fuel < lowest)
                {
                    lowest = fuel;
                }
            }

            Console.WriteLine($"Part1 : {lowest}");

            //Part2
            lowest = double.MaxValue;
            fuel = 0;
            for (var i = 1; i <= input.Count; i++)
            {
                fuel = 0;
                for (var j = 0; j < input.Count; j++)
                {
                    var steps = Math.Abs(i - input[j]);
                    fuel += steps * ((steps / 2.0) + 0.5);
                }

                if (fuel < lowest)
                {
                    lowest = fuel;
                }
            }

            Console.WriteLine($"Part2 : {lowest}");

            stopwatch.Stop();
            Console.WriteLine("Time elapsed: {0} ", stopwatch.Elapsed);
        }
    }
}
