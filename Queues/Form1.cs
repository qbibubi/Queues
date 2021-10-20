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
        struct Patient
        {
            public string patient_name, patient_appointment;
            public DateTime patient_appointment_date;
        }

        public Appointments()
        {
            InitializeComponent();

            // on init so the strings are instantly changed to current hour
            TextCurrentDate.Text = DateTime.Today.ToString("dd-MM-yyyy");
            TextCurrentHour.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
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

        private void Blinker_Tick( object sender, EventArgs e )
        {
            /* code */
        }

        private void StartQueue_Click( object sender, EventArgs e )
        {
            if (!CheckPatientInfo())
            {
                Blinker.Start();
            }
        }

        private void StopQueue_Click( object sender, EventArgs e )
        {

        }

        private void AddToQueue_Click( object sender, EventArgs e )
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
