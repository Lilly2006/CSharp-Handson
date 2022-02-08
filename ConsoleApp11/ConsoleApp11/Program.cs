using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingAss

{
    class Program
    {
        static void Main(string[] args)
        {
            FileAss fileAssObj = new FileAss();
            fileAssObj.ReadNetwork();
            Console.ReadKey();


        }
    }
}
