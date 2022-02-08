using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace NewClean
{
    class SqClean
    {
        public static void Clean(string Value)
        {
            StringBuilder sb = new StringBuilder(Value);
            Console.WriteLine(Value.Replace(' ', '_'));
            if (Value.Contains("\0"))
            {
                Console.WriteLine(Value.Replace("\0", "CTRL"));
            }
            string letter = "hello-world";
            for (int i = 0; i < letter.Length; i++)
            {
                if (letter[i].ToString() == "-")
                {
                    string st = letter.Replace("-", letter[i + 1].ToString().ToUpper());
                    Console.WriteLine(st.Replace(st[i + 1].ToString(), ""));
                }
            }
            string pattern = @"[a-zA-Z]";
            //string input = "MyOβιεγτFinder";
            foreach (Match match in Regex.Matches(Value, pattern))
            {
                Console.Write(match.Value);
            }

        }
    }
}
