namespace Leetcode
{
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var input = "[";
            _ = IsValid(input);
        }
        public static bool IsValid(string s)
        {
            if (s.Length % 2 != 0)
            {
                return false;
            }

            var pairs = CreateDict();
            var stack = new Stack<char>();

            for (var i = 0; i < s.Length; i++)
            {
                if (pairs.ContainsKey(s[i]))
                {
                    stack.Push(s[i]);
                }
                if (pairs.ContainsValue(s[i]))
                {
                    if (stack.TryPop(out var popd) && popd != pairs.GetKeyFromValue(s[i]))
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }

        public static Dictionary<char, char> CreateDict() => new Dictionary<char, char>
            {
                { '(', ')' },
                { '[', ']' },
                { '{', '}' }
            };
    }
    public static class DictionaryExtensions
    {
        public static char GetKeyFromValue(this Dictionary<char, char> dictionary,
            char value) => dictionary.First(d => d.Value == value).Key;
    }
}
