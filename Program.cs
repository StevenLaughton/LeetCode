using System;
using System.Collections.Generic;

namespace Leetcode
{
    public class Program
    {
        public static void Main()
        {
            var inputString = "abcabcbb";
            var len = LengthOfLongestSubstring(inputString);
            Console.WriteLine(len.ToString());
        }

        public static int LengthOfLongestSubstring(string s)
        {
            var stringArray = s.ToCharArray();
            var len = s.Length;

            var set = new HashSet<char>(len);
            foreach (char element in stringArray)
            {
                set.Add(element);
            }
            return set.Count;
            // for (var i = len; i > 0; i--)
            // {
            //     for (var j = 0; j <= len - i; j++)
            //     {
            //         var segment = new ArraySegment<char>(stringArray, j, i);
            //         if (i == segment.OptimizedDistinctAndCount(segment.Count))
            //         {
            //             return segment.Count;
            //         }
            //     }
            // }
            // return 0;
        }
    }
    public static class ArraySegmentExtensions
    {
        public static int OptimizedDistinctAndCount(this ArraySegment<char> source, int numberOfElements)
        {
            var set = new HashSet<char>(numberOfElements);
            foreach (char element in source)
            {
                set.Add(element);
            }
            return set.Count;
        }
    }

}
