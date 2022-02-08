using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewClean
{
    class Program
    {
        static void Main(string[] args)
        {
            string Getword = Console.ReadLine();
            SqClean.Clean(Getword);
            Console.ReadKey();
        }
    }
}
