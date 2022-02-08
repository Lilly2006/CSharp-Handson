using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultithreadingDemo
{
    class Booking
    {
        public int bookingid { get; set; }
        public string eventname { get; set; }
    }
    class EventBooking
    {
        public void Booking()
        {
            Console.WriteLine("Booking.....");
        }
        public void BookingStatus()
        {
            Console.WriteLine("BookingStatus.....");
        }
        public void BookingLog()
        {
            Console.WriteLine("BookingLog.....");
        }

    }
    class Multithreading
    {
    }
}
