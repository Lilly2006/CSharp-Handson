using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSalon
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Appointment.Schedule();
            Appointment.HasPassed();
            Appointment.IsAfternoonAppointment();
            Appointment.Description();
            Appointment.AnniversaryDate();
            Console.ReadKey();
        }
    }
}
