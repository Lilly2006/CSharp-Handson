using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace AssignmentSalon
{
    class Appointment
    {
        public static void Schedule()
        {

            var cultureInfo = new CultureInfo("de-DE");
            Console.WriteLine("Task 1");
            Console.Write("Enter Your Appoinment : ");
            DateTime dateString = new DateTime();



            dateString = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Enter AM/PM : ");
            String time = Console.ReadLine();

            Console.WriteLine(dateString.Year+","+dateString.Month+","+dateString.Day+","+dateString.Hour+","+dateString.Minute+","+dateString.Second);
        }
        public static void HasPassed()
        {
            Console.WriteLine("Task 2");
            Console.Write("Enter Your Appoinment : ");
            DateTime dateString = new DateTime();
            dateString = Convert.ToDateTime(Console.ReadLine());
            DateTime AppoinmentDate = dateString;
            if (AppoinmentDate <= DateTime.Now)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            

        }
        public static void IsAfternoonAppointment() {
            Console.WriteLine("Task 3");

            Console.Write("Enter Your Appoinment : ");
            DateTime dateString = new DateTime();



            dateString = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Enter AM/PM : ");
            String time = Console.ReadLine();

            DateTime Date = DateTime.Now;
            string date1 = Convert.ToString(Date);
            string date2 = Convert.ToString(dateString);


            string[] authorsList = date1.Split(' ');           
            string[] authorsList1 = date2.Split(' ');
            if (authorsList[0] == authorsList1[0] && time == "PM")
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

        }
        public static void  Description() {
            Console.WriteLine("Task 4");
            Console.Write("Enter Your Appoinment : ");
            DateTime dateString = new DateTime();
            dateString = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Enter AM/PM : ");
            String time = Console.ReadLine();
            Console.WriteLine("You have an appointment on " + dateString + " " + time + ".");

        }
        public static void AnniversaryDate() { 
            DateTime date3 = new DateTime(2019, 9, 15);
            Console.WriteLine(date3.Year+","+date3.Month+","+date3.Day+","+date3.Hour+","+date3.Minute+","+date3.Second);
        }
    }
}
            
        
    
