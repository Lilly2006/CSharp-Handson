using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NGCDemo
{
    class NGCollection
    {     
        public void AddStudent()
        {
            #region Boxing & Unboxing
            int a = 10;
            object b = a;   //boxing
            int myValue = Convert.ToInt32(b);    //unboxing
            #endregion

            #region ArrayList
            ArrayList studentList = new ArrayList();
            studentList.Add("Lilly");
            studentList.Add(21);

            for (int i = 0; i < studentList.Count; i++)
            {
                Console.WriteLine(studentList[i]);
            }
            #endregion

            #region Stack
            Stack stackObj = new Stack();
            stackObj.Push(500);
            stackObj.Push("Lilly");
            stackObj.Push(500.10);
           
            //Console.WriteLine(stackObj.Pop());
            //Console.WriteLine(stackObj.Pop());
            foreach (var item in stackObj)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(stackObj.Pop());

            #endregion

            #region Hashtable

            Hashtable hashtableObj = new Hashtable();
            hashtableObj.Add("stu-101", "90");
            hashtableObj.Add("stu-102", "95");
            hashtableObj.Add("stu-103", "80");
            foreach (DictionaryEntry item in hashtableObj)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
                //Console.WriteLine(hashtableObj[item.key]);
            }
            #endregion

        }
    }
}
