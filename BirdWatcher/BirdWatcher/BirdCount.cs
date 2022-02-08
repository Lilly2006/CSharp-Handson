using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdWatcher
{
    class BirdCount
    {
        public  static void LastWeek()
        {
            int[] BirdsPerweek =new int[] { 0, 2, 5, 3, 7, 8, 4 };            
            Console.WriteLine("["+string.Join(",", BirdsPerweek)+"]");
                  
                     
        }
        public static void Today()
        {
            int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
            //var birdCount = new BirdCount(birdsPerDay);
            Console.WriteLine(birdsPerDay[birdsPerDay.Length - 1]);
           
        }
        public static void IncrementTodaysCount()
        {
            int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
            Console.WriteLine(birdsPerDay[birdsPerDay.Length - 1]+1);
        }
        public static void HasDayWithoutBirds()
        {
            int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
            bool found = false;
            for (int i = 0; i < birdsPerDay.Length; i++)
            {

                if (0 == birdsPerDay[i])
                {
                    found = true;
                    break;
                }
            }
            if (found)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }          
        
        public static void CountForFirstDays()
        {
            int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
            Console.WriteLine("Enter a Day: ");
            int n =Convert.ToInt32( Console.ReadLine());
            int sum = 0;
            for (int i = 0; i <=n-1 ; i++)
            {
                 sum = birdsPerDay[i]+sum;
                
            }
            Console.WriteLine(sum);

        }
        public static void BusyDays()
        {
            int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
            int count = 0;
            for (int i = 0; i <birdsPerDay.Length; i++)
            {
                if (birdsPerDay[i] >= 5 )
                {
                    
                    count = count + 1;

                }
               
            }
            Console.WriteLine(count);
        }

    }
}
