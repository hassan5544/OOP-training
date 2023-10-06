using HIMS_OOP_Practice;
using System;
using System.Collections.Generic;

class Program
{
    static List<Patients> patientList = new List<Patients>();
    static List<Doctors> doctorList = new List<Doctors>();

    static void Main()
    {
        Console.WriteLine("Hospital Information Management System (HIMS)");

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Add Patient");
            Console.WriteLine("2. Add Doctor");
            Console.WriteLine("3. Monitor Patient");
            Console.WriteLine("4. Test Patient");
            Console.WriteLine("5. View Tested Patient");
            Console.WriteLine("6. View Monitored Patient");
            Console.WriteLine("7. Exit");
            Console.Write("Select an option: ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        AddPatient();
                        break;
                    case 2:
                        AddDoctor();
                        break;
                    case 3:
                        MonitorPatient();
                        break;
                    case 4:
                        TestPatient();
                        break;
                    case 5:
                        ViewTestedPatient();
                        break;
                    case 6:
                        ViewMonitoredPatient();
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid option.");
            }
        }
    }

    static void AddPatient()
    {
        Console.Write("\nEnter Patient Name: ");
        string patientName = Console.ReadLine();
        if (patientName == null)
        {
            Console.WriteLine("Please Enter a valid Name");
            return;
        }
        Patients NewPatient = new Patients(patientName);
        patientList.Add(NewPatient);
        Console.WriteLine($"Patient '{patientName}' added successfully.");
    }

    static void AddDoctor()
    {
        Console.Write("\nEnter Doctor Name: ");
        string doctorName = Console.ReadLine();
        if (doctorName == null)
        {
            Console.WriteLine("Please Enterr a valid Name");
            return;
        }
        Doctors NewDoctor = new Doctors(doctorName);
        doctorList.Add(NewDoctor);
        Console.WriteLine($"Doctor '{doctorName}' added successfully.");
    }



    static void TestPatient()
    {
        Console.WriteLine("\nSelect a patient to test:");

        for (int patient = 0; patient < patientList.Count; patient++)
        {
            Console.WriteLine($"{patient + 1}. {patientList[patient].PatientName}");
        }

        if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= patientList.Count)
        {
            Patients selectedPatient = patientList[choice - 1];
            selectedPatient.TestPatient();
            Console.WriteLine($"Testing patient: {selectedPatient.PatientName}");
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
        }
    }
    static void MonitorPatient()
    {
        Console.WriteLine("\nSelect a patient to monitor:");

        for (int Patient = 0; Patient < patientList.Count; Patient++)
        {
            Console.WriteLine($"{Patient + 1}. {patientList[Patient]}");
        }

        if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= patientList.Count)
        {
            Patients selectedPatient = patientList[choice - 1];
            selectedPatient.MonitorPatient();
            Console.WriteLine($"Patient '{selectedPatient}' is now being monitored.");
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
        }
    }

    static void ViewTestedPatient()
    {
        int Counter = 1;
        foreach (var Patient in patientList.Where(x => x.IsTested == true))
        {
            Console.WriteLine($"{Counter}. {Patient.PatientName}");
            Counter++;
        }
    }

    static void ViewMonitoredPatient()
    {
        int Counter = 1;
        foreach (var Patient in patientList.Where(x => x.IsMonitored == true))
        {
            Console.WriteLine($"{Counter}. {Patient.PatientName}");
            Counter++;
        }
    }
}