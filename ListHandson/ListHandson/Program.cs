using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListHandson
{
    class Program
    {
        static void Main(string[] args)
        {
            Integers integersObj = new Integers();
            integersObj.IntArr();


            ConcatString concatStringObj = new ConcatString();
            concatStringObj.ConcatArr();

            RemoveA removeAObj = new RemoveA();
            removeAObj.RemoveStr();
            Console.ReadKey();
        }
    }
}
