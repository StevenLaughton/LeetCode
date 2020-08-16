namespace Leetcode
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var res = IsPalindrome(1441);

        }

        public static bool IsPalindrome(int x)
        {
            var asString = x.ToString();

            for (var i = 0; i < (asString.Length / 2); i++)
            {
                if (!Equals(asString[i], asString[^(i + 1)]))
                {
                    return false;
                };
            }

            return true;
        }
    }

}
