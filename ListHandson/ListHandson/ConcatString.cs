using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListHandson
{
    class ConcatString
    {
        //Write a C# Sharp program to create a new list from a
        //given list of strings where each element is replaced by
        //4 copies of the string concatenated together
        //Sample input: "1", "2", "3" , "4"
        //Output:1111 2222 3333 4444
        public void ConcatArr()
        {
            List<int> numbers = new List<int>();
            Console.Write("Enter the size of an array : ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] strList = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter the Array element " + (i + 1) + " : ");
                strList[i] = Convert.ToInt32(Console.ReadLine());
                numbers.Add(strList[i]);
            }
            foreach (var item in numbers)
            {
                var display = Convert.ToString(item);
                Console.WriteLine(display + display + display + display);
            }
        }
    }
}

