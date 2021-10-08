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

        int timer_tick = 10000; // 10 seconds
        private void TimeManager_Tick(object sender, EventArgs e)
        {
            TimeManager.Interval = timer_tick;

            TextCurrentDate.Text = DateTime.Today.ToString() + DateTime.Now.Hour.ToString(); 
        }
    }
}
