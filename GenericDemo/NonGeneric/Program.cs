using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            NonGcollection nonGcollectionObj = new NonGcollection();
            nonGcollectionObj.Data(4);
            nonGcollectionObj.Data("Lilly");
            nonGcollectionObj.Data(7.5);
            Console.ReadKey();
        }
    }
}
