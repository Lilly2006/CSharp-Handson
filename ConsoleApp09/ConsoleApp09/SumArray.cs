using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp09
{
    class SumArray
    {
        public void GetSumArray()
        {
            int[] arrNum = new int[50];
            int i, n;
          
           Console.WriteLine("Enter the array number:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the elements");
            for (i = 0; i < n; i++)
            {
                arrNum[i]= Convert.ToInt32( Console.ReadLine());
       
            }
            int sum = 0;
            for ( i = 0; i < n; i++)
            {
                sum += arrNum[i];
               
            }
            Console.WriteLine("The sum of array is :"+sum);
        }

    }
}