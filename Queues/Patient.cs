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

        public DateTime GetPatientAppointmentDate() { return patient_appointment_date; }
        public string GetPatientAppointment()       { return patient_appointment; }
        public string GetPatientName()              { return patient_name; }

        public void SetValues(string p_name, string p_appointment, DateTime p_app_date)
        {
            patient_name = p_name;
            patient_appointment = p_appointment;
            patient_appointment_date = p_app_date;
        }
    }
}
