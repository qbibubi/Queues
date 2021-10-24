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
        private void Appointments_Load( object sender, EventArgs e )
        {
            // on init so the strings are instantly changed to current hour
            TextCurrentDate.Text = DateTime.Today.ToString("dd-MM-yyyy");
            TextCurrentHour.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
        }

        public Appointments()
        {
            InitializeComponent();
        }

        private readonly int timer_tick = 10000; // 10s
        private void TimeManager_Tick( object sender, EventArgs e )
        {
            TimeManager.Interval = timer_tick;
            TextCurrentHour.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
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
