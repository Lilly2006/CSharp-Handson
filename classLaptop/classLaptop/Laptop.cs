using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classLaptop
{
    class Laptop
   
        {
            public string name = "HP";
            public int price = 50000;
            public string Processor = "intel core ";
            public int ram = 4;
            public string Hardware = "sea gate";
            public void LaptopDetails()
            {
                Console.WriteLine(name);
                Console.WriteLine(price);
                Console.WriteLine(Processor);
                Console.WriteLine(ram);
                Console.WriteLine(Hardware);
            }
        }
        class Dell : Laptop
        {



            public string name1 = "Dell";
            public int price1 = 60000;
            public string Processor1 = "intel core i7";
            public int ram1 = 8;
            public string Hardware1 = "SCV";
            public void DellDetails()
            {
                Console.WriteLine(name1);
                Console.WriteLine(price1);
                Console.WriteLine(Processor1);
                Console.WriteLine(ram1);
                Console.WriteLine(Hardware1);
            }
        }
    }


