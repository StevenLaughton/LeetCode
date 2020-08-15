using System;
using System.Collections.Generic;
using System.Linq;

namespace Leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = Reverse(1534236469);
            Console.WriteLine(res);
        }

        public static int Reverse(int x)
        {
            var strung = x.ToString();
            var sign = "";

            if(strung[0] == '-')
            {
                sign = "-";
                strung = strung.Substring(1);
            }

            var reversed = "";
            for (int i = 0; i < strung.Length; i++)
            {
                reversed += strung[strung.Length - (1 + i)];
            }

            var parsed = int.TryParse($"{sign}{reversed}", out var res);

            return parsed ? res : 0;
        }
    }

}