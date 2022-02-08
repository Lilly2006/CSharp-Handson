using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            ConFunover conFunoverObj = new ConFunover("Lilly");
            conFunoverObj.GetProduct();
            conFunoverObj.GetProduct("Keyboard");
            Console.ReadKey();
        }
    }
}
