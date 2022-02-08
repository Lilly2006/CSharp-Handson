using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionHandson
{
    class Person
    {
        //ARRAYLIST OF OBJECTS
        public void GetPersonDetails()
        {
           
            ArrayList PersonList = new ArrayList();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
                object name = Console.ReadLine();
                Console.WriteLine();
                object age = Convert.ToInt32(Console.ReadLine());
                PersonList.Add(name + "-" + age);
            }

            foreach (var element in PersonList)
            {
                Console.WriteLine(element);
            }
        }
    }
}


    

    
