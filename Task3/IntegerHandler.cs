using System.Collections.Generic;
using System.Linq;

namespace Task3
{
    public static class IntegerHandler
    {
        public static int NextBiggerNumber(int number)
        {
            return NextNumber(number);
        }

        private static int NextNumber(int number)
        {
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

        private static IEnumerable<string> GetPermutations(string s)
        {
            if (s.Length > 1)
                return from ch in s
                       from permutation in GetPermutations(s.Remove(s.IndexOf(ch), 1))
                       select string.Format($"{ch}{permutation}");
            return new[] { s };
        }
    }
}
