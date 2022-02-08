using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionHandson
{
    class StackPerson
    {
        //STACK OF OBJECTS
        public void GetStackList()
        {
            Stack StackList = new Stack();
            for (int i = 0; i < 3; i++)
            {

                Console.WriteLine();
                object name = Console.ReadLine();
                Console.WriteLine();
                object age = Convert.ToInt32(Console.ReadLine());
                StackList.Push(name + "-" + age);

            }
           
            foreach(var element in StackList)
            {
                Console.WriteLine(element);
            }
        }
    }
}
//for (int j = 0; j < StackList.Count; j--)
//{
//    Console.WriteLine(StackList.Pop());
//}