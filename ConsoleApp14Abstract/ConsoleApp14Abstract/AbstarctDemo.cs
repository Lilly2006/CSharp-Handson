using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14Abstract
{
    class MobileBrandList
    {
        public int MobileId { get; set; }
        public string MobileBrandName { get; set; }
        public string Description { get; set; }

    }
    abstract class AbstarctDemo
    {
        public MobileBrandList[] MobileBrands()    //non-abstract function - definition
        {
            MobileBrandList[] mobileBrandLists = new MobileBrandList[3];  //array of objects
            MobileBrandList mobileBrandListObj = new MobileBrandList();
            mobileBrandListObj.MobileId = 1;
            mobileBrandListObj.MobileBrandName = "IPhone12";
            mobileBrandListObj.Description = "Test1";
            mobileBrandLists[0] = mobileBrandListObj;

            mobileBrandListObj = new MobileBrandList();
            mobileBrandListObj.MobileId = 2;
            mobileBrandListObj.MobileBrandName = "IPhone13";
            mobileBrandListObj.Description = "Test2";
            mobileBrandLists[1] = mobileBrandListObj;

            mobileBrandListObj = new MobileBrandList();
            mobileBrandListObj.MobileId = 3;
            mobileBrandListObj.MobileBrandName = "IPhone14";
            mobileBrandListObj.Description = "Test3";
            mobileBrandLists[2] = mobileBrandListObj;
            return mobileBrandLists;
        }
       

        //Abstarct function - declaration
        public abstract void ramconfiguration();
        public abstract void cameraconfiguration();
        public abstract void memorysetup();
    }
    class IPhone13promax : AbstarctDemo
    {
        //public int[] MyCameramode()
        //{
        //    int[] modes = { 2, 3, 4, 5 };
        //    return modes;
        //}
        public override void cameraconfiguration()
        {
            Console.WriteLine("12mp front camera");
        }

        public override void memorysetup()
        {
            Console.WriteLine("128 internal memory");
        }

        public override void ramconfiguration()
        {
            Console.WriteLine("8GB RAM");
        }
    }
    class IPhone12promax : AbstarctDemo
    {
        public override void cameraconfiguration()
        {
            Console.WriteLine("12mp back camera");
        }

        public override void memorysetup()
        {
            Console.WriteLine("64 internal memory");
        }

        public override void ramconfiguration()
        {
            Console.WriteLine("6GB RAM");
        }
    }
    sealed class Myadmin  // can't inherit but can create object
    {
        public void Data()
        {
            Console.WriteLine("Dtat node");
        } 
    }
    partial class Myclass   // same class name can be used but methods should be different
    {
        public void Data1()
        {
            Console.WriteLine("Data1");
        }
    }
    partial class Myclass
    {
        public void Data2()
        {
            Console.WriteLine("Data2");
        }
    } 
    static class Mobilecustomers  //static keyword is main, can't inherit and create obj. 
    {
        public static void customers()
        {
            Console.WriteLine("Static class");
        }
    }
}
