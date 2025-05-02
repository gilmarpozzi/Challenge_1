using System.Collections.Generic;

namespace ATMDenomination
{
    public class ATMDenominationCalculator
    {
        public List<List<int>> FindCombinations(int target, int[] denominations)
        {
            var result = new List<List<int>>();
            var current = new List<int>();
            FindCombinationsHelper(target, denominations, 0, current, result);
            return result;
        }

        private void FindCombinationsHelper(int remaining, int[] denominations, int start, List<int> current, List<List<int>> result)
        {
            if (remaining == 0)
            {
                result.Add(new List<int>(current));
                return;
            }

            for (int i = start; i < denominations.Length; i++)
            {
                if (denominations[i] <= remaining)
                {
                    current.Add(denominations[i]);
                    FindCombinationsHelper(remaining - denominations[i], denominations, i, current, result);
                    current.RemoveAt(current.Count - 1);
                }
            }
        }
    }
} 