using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListHandson
{
    class RemoveA
    {
        //3. Write a C# Sharp program to remove all "a" in each string in
        //given list of strings and return the new string
        //Sample input:"abc", "cdaef", "js" , "php"
        //Output: bc cdef js php

        public void RemoveStr()
        {
            List<string> numbers = new List<string>();
            Console.Write("Enter the size of an List : ");
            int size = Convert.ToInt32(Console.ReadLine());
            string[] strList = new string[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter the List element " + (i + 1) + " : ");
                strList[i] = Convert.ToString(Console.ReadLine());
                numbers.Add(strList[i]);
            }
            foreach (String item in numbers)
            {
                var display = Convert.ToString(item);
                Console.WriteLine(display.Replace("a", ""));
            }
        }
    }
}