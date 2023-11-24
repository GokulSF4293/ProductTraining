using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application
{
    public class Appointment
    {
        private static int s_appointmentID;
        public int AppointmentID { get; }
        public int PatientID { get; set; }
        public int DoctorID { get; set; }
        public DateTime Date { get; set; }
        public string Problem { get; set; }

        public Appointment(int patientID,int doctorID,DateTime date,string problem)
        {
            AppointmentID = ++s_appointmentID;
            PatientID = patientID;
            DoctorID = doctorID;
            Date = date;
            Problem = problem;
        }
    }
}