using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionHandson
{
    class QueuePerson
    {
        //QUEUE OF OBJECTS
        public void GetQueueDeatils()
        {
            Queue queueList = new Queue();
            for (int i = 0; i < 3; i++)
            {

                Console.WriteLine();
                object name = Console.ReadLine();
                Console.WriteLine();
                object age = Convert.ToInt32(Console.ReadLine());
                queueList.Enqueue(name + "-" + age);

                

            }
            foreach (var element in queueList)
            {
                Console.WriteLine(element);
            }
        }
    }
}
