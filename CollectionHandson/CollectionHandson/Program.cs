using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionHandson
{
    class Program
    {
        static void Main(string[] args)
        {
            Person personObj = new Person();
            personObj.GetPersonDetails();
            
            StackPerson stackPersonObj = new StackPerson();
            stackPersonObj.GetStackList();
            
            QueuePerson queuePersonObj = new QueuePerson();
            queuePersonObj.GetQueueDeatils();
            Console.ReadKey();

        }
    }
}
