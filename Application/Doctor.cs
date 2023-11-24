using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application
{
    public class Doctor
    {
        public int DoctorID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }

        public Doctor(int doctorID,string name,string department)
        {
            DoctorID = doctorID;
            Name = name;
            Department = department;
        }
    }
}