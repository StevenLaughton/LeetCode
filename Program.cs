using System;
using System.Linq;

namespace Leetcode
{
    public class Program
    {
        public static void Main()
        {
            var input = new string[] { "flower", "flow", "flight" };
            var res = LongestCommonPrefix(input);
        }

        public static string LongestCommonPrefix(string[] strs)
        {
            var prefix = string.Empty;
            if (strs.Count() > 0)
            {
                var len = strs.Min(x => x.Length);
                for (var i = 0; i < len; i++)
                {
                    var values = strs.Select(s => s[i]).Distinct();
                    if (values.Count() == 1)
                    {
                        prefix += values.First();
                    }
                    else
                    {
                        return prefix;
                    }
                }
            };
            return prefix;
        }
    }
}
