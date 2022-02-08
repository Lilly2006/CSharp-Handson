using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunOverloading
{
    class ConFunover
    {
        //constructor
        public ConFunover()
        {
            Console.WriteLine("Constructor with no argument");
        }
        public ConFunover(string funType)
        {
            Console.WriteLine("Constructor with one argument");
        }
        //function
        public void GetProduct()
        {
            Console.WriteLine("Function overloading with no argument");
        }
        public void GetProduct(string ProdType)
        {
            Console.WriteLine("Function overloading with one argument");
        } 
    }
}
