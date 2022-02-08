using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            //ABSTRACT CLASS
            IPhone13promax phone13Promaxobj = new IPhone13promax();
            //int[] result = phone13Promaxobj.MyCameramode();
            phone13Promaxobj.cameraconfiguration();
            phone13Promaxobj.memorysetup();
            phone13Promaxobj.ramconfiguration();
           MobileBrandList[] mobileBrandLists= phone13Promaxobj.MobileBrands();
            
            foreach (var item in mobileBrandLists)
            {
                Console.WriteLine(item.MobileId);
                Console.WriteLine(item.MobileBrandName);
                Console.WriteLine(item.Description);

            }
           
            //SEALED CLASS
            Myadmin myadminObj = new Myadmin();
            myadminObj.Data();

            //PARTIAL CLASS
            Myclass myclassObj = new Myclass();
            myclassObj.Data1();
            myclassObj.Data2();

            //STATIC CLASS
            Mobilecustomers.customers();
            Console.ReadKey();
        }
    }
}
