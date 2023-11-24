using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application
{
    public enum Gender{Select,Male,Female}
    public class Patient
    {
        private static int s_patientID = 0;
        public int PatientID { get; }
        public string Password { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }

        public Patient(string password,string name,int age,Gender gender)
        {
            PatientID = ++s_patientID;
            Password = password;
            Name = name;
            Age = age;
            Gender =  gender;
        }
    }
}