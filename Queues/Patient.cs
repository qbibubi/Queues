using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    class Patient
    {
        private string patient_name, patient_appointment;
        private DateTime patient_appointment_date;

        private int val;
        private Patient next;

        public Patient(string p_n, string p_a, DateTime p_ad)
        {
            patient_name = p_n;
            patient_appointment = p_a;
            patient_appointment_date = p_ad;
        }

        public Patient(int new_x)
        {
            val = new_x;
            next = null;
        }

        public void SetNext(Patient p) { next = p; }
        public Patient GetNext() { return next; }
        public int GetValue() { return val; }

        public DateTime GetPatientAppointmentDate() { return patient_appointment_date; }
        public string GetPatientAppointment()       { return patient_appointment; }
        public string GetPatientName()              { return patient_name; }

        public void SetPatientAppointmentDate(DateTime new_date)          { patient_appointment_date = new_date; }
        public void SetPatientAppointment(string new_patient_appointment) { patient_appointment = new_patient_appointment; }
        public void SetPatientName(string new_patient_name)               { patient_name = new_patient_name; }
    }
}
