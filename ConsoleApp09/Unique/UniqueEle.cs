using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unique
{
    class UniqueEle
    {
        public void FindUnique()
        {
            int[] array = new int[100];            
            int i, j, n;
            int count = 1;
            Console.Write("Enter the size of an array : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the elements:");
            for (i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    if (array[i] == array[j] && i != j)
                        break;
                    ++count;
                }
                if (j == n)
                {
                    Console.WriteLine("Unique elements in an array is:" + array[i]);
                   
                }
          }
            
        }
    }
}