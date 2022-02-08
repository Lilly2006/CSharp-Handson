using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;



namespace SqueakyClean
{
    class Identifier
    {
        public static void Clean()
        {
            string Mystr = "my Id";
            Console.WriteLine(Mystr.Replace(' ', '_'));
            string Mystr1 = "my\0Id";
            Console.WriteLine(Mystr1.Replace("\0", "CTRL"));
            
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
            string input = "MyOβιεγτFinder";
            foreach (Match match in Regex.Matches(input, pattern))
            {
                Console.Write(match.Value);
            }
        }
    }
}