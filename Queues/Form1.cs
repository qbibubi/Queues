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
        public Appointments()
        {
            InitializeComponent();
        }

        private void Appointments_Load(object sender, EventArgs e)
        {
            // on load the placeholder texts are instantly changed to current hour and date
            TextCurrentDate.Text = DateTime.Today.ToString("dd-MM-yyyy");
            if (DateTime.Now.Minute > 0)
                TextCurrentHour.Text = DateTime.Now.Hour.ToString() + ":" + "0" + DateTime.Now.Minute.ToString();
            else TextCurrentHour.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
        }

        private readonly int timer_tick = 10000;    // 10s
        private void TimeManager_Tick(object sender, EventArgs e)
        {
            TimeManager.Interval = timer_tick;
            if (DateTime.Now.Minute > 0)
                TextCurrentHour.Text = DateTime.Now.Hour.ToString() + ":" + "0" + DateTime.Now.Minute.ToString();
            else TextCurrentHour.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
        }

        public bool CheckInfo()
        {
            string title = "Error!";
            string name_err_message = "No patient name!";
            string appointment_err_message = "No appointment!";
            string date_err_message = "Wrong date!";

            if (NameTextBox.ToString() != "")
            {
                MessageBox.Show(name_err_message, title);
                return false;
            }
            else return true;

            if (AppointmentNameTextBox.ToString() != "")
            {
                MessageBox.Show(appointment_err_message, title);
                return false;
            }
            else return true;

            if (AppointmentDatePicker.Value < DateTime.Today)
            {
                MessageBox.Show(date_err_message, title);
                return false;
            }
            else return true;
        }

        private void Enqueue_Click(object sender, EventArgs e)
        {

        }

        private void Dequeue_Click(object sender, EventArgs e)
        {

        }

        private void InsertIntoQueue_Click(object sender, EventArgs e)
        {

        }       
    }
}
