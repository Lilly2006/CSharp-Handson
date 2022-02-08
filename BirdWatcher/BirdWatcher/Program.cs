using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdWatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            BirdCount.LastWeek();
            BirdCount.Today();
            BirdCount.IncrementTodaysCount();
            BirdCount.HasDayWithoutBirds();
            BirdCount.CountForFirstDays();
            BirdCount.BusyDays();
            Console.ReadKey();
        }
    }
}
