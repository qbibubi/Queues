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
            if (DateTime.Now.Minute < 10)
                TextCurrentHour.Text = DateTime.Now.Hour.ToString() + ":" + "0" + DateTime.Now.Minute.ToString();
            else TextCurrentHour.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
        }

        private readonly int timer_tick = 10000;    // 10s
        private void TimeManager_Tick(object sender, EventArgs e)
        {
            TimeManager.Interval = timer_tick;
            if (DateTime.Now.Minute < 10)
                TextCurrentHour.Text = DateTime.Now.Hour.ToString() + ":" + "0" + DateTime.Now.Minute.ToString();
            else TextCurrentHour.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
        }

        public bool CheckInfo()
        {
            if ((NameTextBox.ToString() == "") ||
                (AppointmentNameTextBox.ToString() == "") ||
                (AppointmentDatePicker.Value < DateTime.Today))
            {
                return true;
            }
            else return false;
        }

        public void InputError()
        {
            string title = "Error!";
            string err_mess = "You missed an input!";

            if (!CheckInfo())
                MessageBox.Show(err_mess, title);
        }

        Queue queue = new Queue(3);     // Max sizeof is 3
        private void Enqueue_Click(object sender, EventArgs e)
        {
            InputError();
        }

        private void Dequeue_Click(object sender, EventArgs e)
        {
            InputError();
        }

        private void InsertIntoQueue_Click(object sender, EventArgs e)
        {
            InputError();
        }
    }
}
