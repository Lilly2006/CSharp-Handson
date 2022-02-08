using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsAssemble
{
    class AssemblyLine
    {
        public static void SuccessRate()
        {
            Console.Write("Enter the number : ");
            int Number = Convert.ToInt32(Console.ReadLine());
            
            if (Number == 0)
            {
                int Result1 = (0 / 100);
                Console.WriteLine(Result1);
            }
            else if (Number >= 1 && Number <= 4)
            {
                int Result2 = (100 / 100);
                Console.WriteLine(Result2);
            }
            else if (Number >= 5 && Number <= 8)
            {
                double Result3 = (double)90 / 100;
                Console.WriteLine(Result3);
            }
            else if (Number == 9)
            {
                double Result4 = (double)80 / 100;
                Console.WriteLine(Result4);
            }
            else if (Number == 10)
            {
                double Result5 = (double)77 / 100;
                Console.WriteLine(Result5);
            }
            else
            {
                Console.WriteLine("Data Invalid");
            }

        }
        public static void ProductionRatePerHour()
        {
            Console.Write("Enter the number : ");
            int Number = Convert.ToInt32(Console.ReadLine());           
            if (Number == 0)
            {
                int Result1 = (0 / 100);                
                int rateperhour = (Number * Result1) * 221;
                Console.WriteLine(rateperhour);
            }
            else if (Number >= 1 && Number <= 4)
            {
                int Result2 = (100 / 100);
                int rateperhour1 = (Number * Result2) * 221;
                Console.WriteLine(rateperhour1);
            }
            else if (Number >= 5 && Number <= 8)
            {
                double Result3 = (double)90 / 100;
                double rateperhour2 = (Number * Result3) * 221;
                Console.WriteLine(rateperhour2);
            }
            else if (Number == 9)
            {
                double Result4 = (double)80 / 100;
                double rateperhour3 = (Number * Result4) * 221;
                Console.WriteLine(rateperhour3);
            }
            else if (Number == 10)
            {
                double Result5 = (double)77 / 100;
                double rateperhour4 = (Number * Result5) * 221;
                Console.WriteLine(rateperhour4);
            }
            else
            {
                Console.WriteLine("Data Invalid");
            }
        }
        public static void WorkingItemsPerMinute()
        {
            Console.Write("Enter the number : ");
            int Number = Convert.ToInt32(Console.ReadLine());
            
            if (Number == 0)
            {
                int Result1 = (0 / 100);
               
                int rateperhour = (Number * Result1) * 221;
                int minPerHr1 = Convert.ToInt32((rateperhour / 60));
                Console.WriteLine(minPerHr1);
            }
            else if (Number >= 1 && Number <= 4)
            {
                int Result2 = (100 / 100);
                int rateperhour1 = (Number * Result2) * 221;
                int minPerHr2 = Convert.ToInt32((rateperhour1 / 60));
                Console.WriteLine(minPerHr2);
            }
            else if (Number >= 5 && Number <= 8)
            {
                double Result3 = (double)90 / 100;
                int rateperhour2 = Convert.ToInt32((Number * Result3) * 221);
                int minPerHr3 = Convert.ToInt32((rateperhour2 / 60));
                Console.WriteLine(minPerHr3);
            }
            else if (Number == 9)
            {
                double Result4 = (double)80 / 100;
                int rateperhour3 = Convert.ToInt32((Number * Result4) * 221);
                int minPerHr4 = Convert.ToInt32((rateperhour3 / 60));
                Console.WriteLine(minPerHr4);
            }
            else if (Number == 10)
            {
                double Result5 = (double)77 / 100;
                int rateperhour4 = Convert.ToInt32((Number * Result5) * 221);
                int minPerHr5 = Convert.ToInt32((rateperhour4 / 60));
                Console.WriteLine(minPerHr5);
            }
            else
            {
                Console.WriteLine("Data Invalid");
            }
        }
    }
}
    

