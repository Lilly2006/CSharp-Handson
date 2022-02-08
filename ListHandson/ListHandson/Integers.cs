using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ListHandson
{
    //Write a C# Sharp program to create a new list from a given
    //list of integers where each integer value is added to 2 and the
    //result value is multiplied by 5
    class Integers
    {
        public void IntArr()
        {
            List<int> Numbers = new List<int>();
            Console.Write("Enter the size of List");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] lit = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter the element of list " + (i + 1) + " :");
                lit[i] = Convert.ToInt32(Console.ReadLine());
                Numbers.Add((lit[i] + 2) * 5);



            }
            foreach (int num in Numbers)
            {
                Console.WriteLine(num);
            }
        }
           
        }
    }


