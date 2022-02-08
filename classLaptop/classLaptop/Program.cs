using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classLaptop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dell DellObj = new Dell();

            DellObj.LaptopDetails();
            DellObj.DellDetails();

        }
    }
}
