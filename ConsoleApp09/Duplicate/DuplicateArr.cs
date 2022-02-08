using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duplicate
{
    class DuplicateArr
    {
        public void DuplicateArrFind() 
        {
            int[] arr = new int[50];
            int i, j, n;
            Console.WriteLine("Enter the size of array:");
            n =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Enter the elements:");
            for (i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32( Console.ReadLine());

            }
            int count = 0;
            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        break;
                    }
                }
            }
            Console.WriteLine("Number of duplicate elements found in array is:" + count);
            Console.ReadLine();
        }
    }
}
