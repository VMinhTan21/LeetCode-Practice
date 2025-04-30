using System;

namespace Leetcode.Exercies
{ 
    public static class LongestCommonPrefix
    {
        private static Tuple<string, int> GetShortestLengthElement(string[] strs)
        {
            string smallest = strs[0];
            int index = 0;
            
            for (int i = 0; i < strs.Length; i++)
            {
                if (strs[i].Length < smallest.Length)
                {
                    smallest = strs[i];
                    index = i;
                }
                else
                    continue;
            }

            return new Tuple<string, int>(smallest, index);
        }
        public static string GetLongestCommonPrefix(string[] strs)
        {
            Tuple<string, int> shortestElement = GetShortestLengthElement(strs);
            
            string shortest = shortestElement.Item1;
            int index = shortestElement.Item2;
            int prefixLength = shortest.Length;

            for (int i = 0; i < strs.Length; i++)
            {
                if (i != index)
                {
                    if (strs[i].Substring(0, prefixLength) != shortest.Substring(0, prefixLength))
                    {
                        prefixLength--;
                        i = -1;
                    }

                    if (prefixLength == 0)
                        return String.Empty;
                }
            }

            return shortest.Substring(0, prefixLength);
        }
    }
}
