using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultiWorkerthread
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a thread with a ParemeterizedThreadStart  
            Print p = new Print();
            Thread workerThread = new Thread(p.PrintJob);
            // Start thread with a parameter  
            workerThread.Start("Some data");

            // Pass a class object to a worker thread  
            Person mahesh = new Person("Mahesh Chand", 40, "Male");
            Thread workerThread2 = new Thread(p.PrintPerson);
            workerThread2.Start(mahesh);

            // Main thread  
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Main thread: {i}");
                Thread.Sleep(200);
            }

            Console.ReadKey();
        }
    }
}

