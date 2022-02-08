using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    class CollectionDemo<T>
    {
        T[] arrayElements = new T[5];
        int count = 0;

        public void Data(T item)
        {
            if (count + 1 < 6)
            {
                arrayElements[count] = item;
            }
            count++;
            Console.WriteLine(item);
        }
        
    }
}

