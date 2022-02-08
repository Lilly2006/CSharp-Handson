using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMin
{
    class Maxmin
    {
        public void FindMinMax() {
            int[] arr = new int[100];
            int i,n;
            Console.WriteLine("Enter the size of array:");
            n= Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Enter the Elements:");
            for (i = 0; i < n; i++)
            {
                arr[i] =Convert.ToInt32( Console.ReadLine());
                    }
            int max = arr[0];
            int min = arr[0];
            for (i = 0; i < n; i++)
            {
                if(arr[i]>max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("The maximum element in the array is:" + max);
            Console.WriteLine("The minimum element in the array is:" + min);

        }
    }
}
