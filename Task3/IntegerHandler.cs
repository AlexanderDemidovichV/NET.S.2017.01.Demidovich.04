using System;
using System.Collections.Generic;
using System.Linq;

namespace Task3
{
    /// <summary>
    /// Provides static methods for integers
    /// </summary>
    public static class IntegerHandler
    {
        /// <summary>
        /// Find next the bigger number with <paramref name="number"/> digits.
        /// </summary>
        /// <param name="number">A positive integer that provides digits.</param>
        /// <returns>The index of the first bigger value than <paramref name="number"/>, if found; otherwise, minus 1.</returns>
        public static int NextBiggerNumber(int number)
        {
            return NextNumber(number);
        }

        /// <summary>
        /// Find next the bigger number with <paramref name="number"/> digits.
        /// </summary>
        /// <param name="number">A positive integer that provides digits.</param>
        /// <returns>The index of the first bigger value than <paramref name="number"/>, if found; otherwise, minus 1.</returns>
        /// <exception cref="System.ArgumentOutOfRangeException"><paramref name="number"/> is less than zero.</exception>
        private static int NextNumber(int number)
        {
            if (number<=0)
                throw new ArgumentOutOfRangeException();

            var list = new List<string>();

            foreach (var permutation in GetPermutations(number.ToString()))
            {
                if (!list.Contains(permutation))
                    list.Add(permutation);
            }

            list.Sort();

            if (number.ToString() == list.Last())
                return -1;
            return int.Parse(list[list.IndexOf(number.ToString()) + 1]);
        }

        /// <summary>
        /// Gets all possible combinations with <paramref name="str"/> chars.
        /// </summary>
        /// <param name="str">A string provides chars.</param>
        /// <returns>All possible permutation combinations.</returns>
        private static IEnumerable<string> GetPermutations(string str)
        {
            if (str.Length > 1)
                return from ch in str
                       from permutation in GetPermutations(str.Remove(str.IndexOf(ch), 1))
                       select string.Format($"{ch}{permutation}");
            return new[] { str };
        }
    }
}
