using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultithreadingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            EventBooking eventBookingObj = new EventBooking();
            //SEQUENTIAL PROCESS
            //eventBookingObj.Booking();
            //eventBookingObj.BookingStatus();
            //eventBookingObj.BookingStatus();

            //MULTITHREADING
            Thread t1 = new Thread(eventBookingObj.Booking);
            Thread t2 = new Thread(eventBookingObj.BookingStatus);
            Thread t3 = new Thread(eventBookingObj.BookingLog);
            t1.Start();
            t2.Start();
            t3.Start();
            Console.ReadKey();
        }
    }
}
