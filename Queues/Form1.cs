using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queues
{
    public partial class Appointments : Form
    {
        public struct Patient
        {
            public Patient(string p_name, string p_app, DateTime p_app_date)
            {
                patient_name = p_name;
                patient_appointment = p_app;
                patient_appointment_date = p_app_date;      
            }

            private string patient_name, patient_appointment;
            private DateTime patient_appointment_date;
        }
                
        Patient[] patients = new Patient[3];
        

        public Appointments()
        {
            InitializeComponent();
        }

        private void Appointments_Load(object sender, EventArgs e)
        {
            TextCurrentDate.Text = DateTime.Today.ToString("dd-MM-yyyy");
            TextCurrentHour.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();

            patients[0] = new Patient();
            patients[1] = new Patient();
            patients[2] = new Patient();
        }

        public bool CheckPatientInfo()
        {
            if ( !(NameTextBox.Text == "" || AppointmentNameTextBox.Text == "") )
                return true;

            return false;
        }

        private readonly int timer_tick = 10000; // 10s
        private void TimeManager_Tick( object sender, EventArgs e )
        {
            TimeManager.Interval = timer_tick;
            TextCurrentHour.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
        }

        private void Enqueue_Click( object sender, EventArgs e )
        {
            if (!CheckPatientInfo())
            {   
            }
        }

        private void RemoveFromQueue_Click( object sender, EventArgs e )
        {

        }

        private void InsertIntoQueue_Click( object sender, EventArgs e )
        {

        }       
    }
}
