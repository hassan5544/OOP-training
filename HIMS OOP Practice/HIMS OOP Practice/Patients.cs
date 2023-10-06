using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HIMS_OOP_Practice
{
    public class Patients
    {
        public string PatientName { get; set; }
        public bool IsMonitored { get; set; }
        public bool IsTested { get; set; }

        public Patients(string patientName)
        {
            PatientName = patientName;
        }

        public void MonitorPatient()
        {
            IsMonitored = true;
        }

        public void UnMonitorPatient()
        {
            IsMonitored = false;
        }

        public void TestPatient ()
        {
            IsTested = true;
        }


    }
}
