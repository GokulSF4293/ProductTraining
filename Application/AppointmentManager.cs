using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Application
{
    public class AppointmentManager
    {
        public static Patient currentLoggedPerson;
        public static List<Doctor> doctorList = new List<Doctor>();
        public static List<Patient> patientList = new List<Patient>();
        public static List<Appointment> appointmentList = new List<Appointment>();

        public static void AddValues()
        {
            Doctor doctor1 = new Doctor(1, "Nancy", "Anesthesiology");
            doctorList.Add(doctor1);
            Doctor doctor2 = new Doctor(2, "Andrew", "Cardiology");
            doctorList.Add(doctor2);
            Doctor doctor3 = new Doctor(3, "Janet", "Diabetology");
            doctorList.Add(doctor3);
            Doctor doctor4 = new Doctor(4, "Margaret", "Neonatology");
            doctorList.Add(doctor4);
            Doctor doctor5 = new Doctor(5, "Steven", "Nephrology");
            doctorList.Add(doctor5);

            Patient patient1 = new Patient("welcome", "Robert", 40, Gender.Male);
            patientList.Add(patient1);
            Patient patient2 = new Patient("welcome", "Laura", 36, Gender.Female);
            patientList.Add(patient2);
            Patient patient3 = new Patient("welcome", "Anne", 42, Gender.Female);
            patientList.Add(patient3);

            Appointment appointment1 = new Appointment(1, 2, new DateTime(2012, 3, 8), "Heart problem");
            appointmentList.Add(appointment1);
            Appointment appointment2 = new Appointment(1, 5, new DateTime(2012, 3, 8), "Spinal cord injury");
            appointmentList.Add(appointment2);
            Appointment appointment3 = new Appointment(2, 2, new DateTime(2012, 3, 8), "Heart attack");
            appointmentList.Add(appointment3);

        }

        public static void MainMenu()
        {
            string choice = "YES";
            Console.WriteLine("------Welcome to SyncHospital-----");
            do
            {
                Console.WriteLine("-----This the Main Menu-----\n1. Login\n2. Register");
                Console.WriteLine("Enter the option to proceed");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            Login();
                            break;
                        }
                    case 2:
                        {
                            Register();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid option entered.");
                            break;
                        }
                }
                Console.WriteLine("Do you want to continue?");
                choice = Console.ReadLine().ToUpper();
            } while (choice == "YES");
        }

        public static void Register()
        {
            Console.WriteLine("------Welcome to Registeration Page-----");
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your password");
            string password = Console.ReadLine();
            Console.WriteLine("Enter your age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your gender");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(), true);
            Patient patient = new Patient(password, name, age, gender);
            patientList.Add(patient);
            Console.WriteLine($"Your Regustration was successful and your PatientID is {patient.PatientID}");
        }

        public static void Login()
        {
            Console.WriteLine("------Welcome to Login Page-----");
            Console.WriteLine("Enter the patientID");
            int enteredID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the password");
            string enteredPassword = Console.ReadLine();
            bool flag = true;
            foreach (Patient patient in patientList)
            {
                if (enteredID.Equals(patient.PatientID) && enteredPassword.Equals(patient.Password))
                {
                    flag = false;
                    currentLoggedPerson = patient;
                    SubMenu();
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine("Details not found register and login.");
            }
        }

        public static void SubMenu()
        {
            String choice = "YES";
            do
            {
                Console.WriteLine("------Welcome to Sub Menu-----");
                Console.WriteLine("1. Book Appointment\n2. View Appointment\n3. Edit my Profile\n4. Exit\nEnter the option to proceed");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            BookAppointment();
                            break;
                        }
                    case 2:
                        {
                            ViewAppointmentDetails();
                            break;
                        }
                    case 3:
                        {
                            EditMyProfile();
                            break;
                        }
                    case 4:
                        {
                            choice = "NO";
                            break;
                        }
                }
            } while (choice == "YES");
        }

        public static void BookAppointment()
        {
            string choice = "Y";
            bool flag = true;
            do
            {
                Console.WriteLine("Department\n1. Anaesthesiology\n2. Cardiology\n3. Diabetology\n4. Neonatology\n5. Nephrology\nEnter the department to proceed");
                string enteredDept = Console.ReadLine();
                foreach (Doctor doctor in doctorList)
                {
                    if (enteredDept.Equals(doctor.Department))
                    {
                        flag = false;
                        Console.WriteLine("Enter the date to book slot");
                        DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                        foreach (Appointment appointment in appointmentList)
                        {
                            if (doctor.DoctorID.Equals(appointment.DoctorID) && date >= DateTime.Now && date != appointment.Date)
                            {
                                Console.WriteLine("Enter the problem");
                                string problem = Console.ReadLine();
                                Appointment appointment1 = new Appointment(currentLoggedPerson.PatientID, doctor.DoctorID, date, problem);
                                appointmentList.Add(appointment1);
                                Console.WriteLine($"Appointment is confrimed and your AppointmentID is {appointment1.AppointmentID}");
                                break;
                            }
                        }
                        break;
                    }
                }
                Console.WriteLine("Do you want to book another slot?(Y/N)");
                choice = Console.ReadLine().ToUpper();
            }while(choice == "Y");
            if(flag)
            {
                Console.WriteLine("Invalid department!");
            }
        }

        public static void EditMyProfile()
        {
            Console.WriteLine("Enter your name:");
            currentLoggedPerson.Name = Console.ReadLine();
            Console.WriteLine("Enter your password");
            currentLoggedPerson.Password = Console.ReadLine();
            Console.WriteLine("Enter your age");
            currentLoggedPerson.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your gender");
            currentLoggedPerson.Gender = Enum.Parse<Gender>(Console.ReadLine(), true);
        }

        public static void ViewAppointmentDetails()
        {
            Console.WriteLine($"| {"AppointmentID",-5} | {"PatientID",-5} | {"DoctorID",-5} | {"Date",-25} | {"Problem",-30} |");
            foreach (Appointment appointment in appointmentList)
            {
                if (currentLoggedPerson.PatientID.Equals(appointment.PatientID))
                {
                    Console.WriteLine($"| {appointment.AppointmentID,-5} | {appointment.PatientID,-5} | {appointment.DoctorID,-5} | {appointment.Date.ToString("MM/dd/yyyy"),-25} | {appointment.Problem} |");
                }
            }
        }
    }
}