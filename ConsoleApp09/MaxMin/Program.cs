using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMin
{
    class Program
    {
        static void Main(string[] args)
        {
            Maxmin maxminObj = new Maxmin();
            maxminObj.FindMinMax();
            Console.ReadKey();

        }
    }
}
