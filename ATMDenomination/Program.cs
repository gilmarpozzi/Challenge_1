using System;
using System.Collections.Generic;
using System.Linq;

namespace ATMDenomination
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] denominations = { 10, 50, 100 };
            int[] amounts = { 30, 50, 60, 80, 140, 230, 370, 610, 980 };

            var calculator = new ATMDenominationCalculator();

            foreach (int amount in amounts)
            {
                Console.WriteLine($"\nPossible combinations for {amount} EUR:");
                var combinations = calculator.FindCombinations(amount, denominations);
                
                if (combinations.Count == 0)
                {
                    Console.WriteLine("No possible combinations found.");
                    continue;
                }

                foreach (var combination in combinations)
                {
                    var parts = combination
                        .GroupBy(x => x)
                        .Select(g => $"{g.Count()} x {g.Key} EUR")
                        .ToList();
                    Console.WriteLine(string.Join(" + ", parts));
                }
            }
        }

        public List<List<int>> FindCombinations(int target, int[] denominations)
        {
            var calculator = new ATMDenominationCalculator();
            return calculator.FindCombinations(target, denominations);
        }
    }
} 