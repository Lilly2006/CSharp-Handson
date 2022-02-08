using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CollectionDemo<int> Obj = new CollectionDemo<int>();
            Obj.Data(4);
            CollectionDemo<string> Obj1 = new CollectionDemo<string>();
            Obj1.Data("Lilly");
            CollectionDemo<double> obj2 = new CollectionDemo<double>();
            obj2.Data(89.9);
            Console.ReadKey();
        }
    }
}
