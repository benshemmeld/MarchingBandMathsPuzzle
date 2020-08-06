using System;
using System.Collections.Generic;

namespace MarchingBandMathsPuzzle
{
    class Program
    {
        static void Main(string[] args)
        {
            var targetArrangements = 64;
            var numBandMembers = 0;
            while(true)
            {
                numBandMembers++;

                var possibleArrangements = GetFactors(numBandMembers);
                if(possibleArrangements.Count == targetArrangements)
                {
                    Console.WriteLine($"{numBandMembers} band members has {targetArrangements} different marching options");
                    var count = 0;
                    foreach(var arrangment in possibleArrangements)
                    {
                        count++;
                        Console.WriteLine($"{count} {arrangment.Item1} x {arrangment.Item2}");
                    }
                    Console.ReadLine();
                    return;
                }
            }
        }

        private static List<(int, int)> GetFactors(int number)
        {
            var factors = new List<(int, int)>();
            for(var i=1; i<=number; i++)
            {
                if(number%i == 0)
                {
                    var otherFactor = number / i;
                    factors.Add((i, otherFactor));
                }
            }
            return factors;
        }
    }
}
