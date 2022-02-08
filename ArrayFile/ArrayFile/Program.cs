using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayFile
{
    class Program
    {
        static void Main(string[] args)
        {
            FileArr fileArrObj = new FileArr();
            fileArrObj.ReadNetworkArr();
            Console.ReadKey();
        }
    }
}
