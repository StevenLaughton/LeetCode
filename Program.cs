using System;
using System.Collections.Generic;
using System.Linq;

namespace Leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            var val = RomanToInt("LVIII");
        }

        public static int RomanToInt(string s)
        {
            var valuesDict = RomanDict();
            var subtractionDict = SubtractionDict();

            var final = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if ((i + 1) < s.Length && subtractionDict.ContainsKeyValue(s[i], s[i + 1]))
                {
                    final += valuesDict.GetKeyValue(s[i + 1]) - valuesDict.GetKeyValue(s[i]);
                    i += 1;
                } 
                else
                {
                    final += valuesDict.GetKeyValue(s[i]);
                }

            }

            return final;
        }

        public static Dictionary<char, int> RomanDict()
        {
            var dict = new Dictionary<char, int>();

            dict.Add('I', 1);
            dict.Add('V', 5);
            dict.Add('X', 10);
            dict.Add('L', 50);
            dict.Add('C', 100);
            dict.Add('D', 500);
            dict.Add('M', 1000);

            return dict;
        }

        public static Dictionary<char, List<char>> SubtractionDict()
        {
            var look = new Dictionary<char, List<char>>();

            look.Add('I', new List<char> { 'V', 'X' });
            look.Add('X', new List<char> { 'L', 'C' });
            look.Add('C', new List<char> { 'D', 'M' });

            return look;
        }
    }

    public static class DictionaryExtensions
    {
        public static bool ContainsKeyValue(this Dictionary<char, List<char>> dictionary,
                             char expectedKey, char expectedValue)
        {
            return dictionary.TryGetValue(expectedKey, out var actualValue) &&
                actualValue.Contains(expectedValue);
        }

        public static int GetKeyValue(this Dictionary<char, int> dictionary,
                     char key)
        {
            return dictionary.First(d => d.Key == key).Value;
        }
    }
}
