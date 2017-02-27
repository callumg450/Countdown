using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Countdown
{
    public partial class Countdown : Form
    {
        DateTime chosenDate;
        DateTime currentDate = DateTime.Now;
        public Countdown()
        {
            InitializeComponent();
            timer1.Tick += timer1_Tick;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();
            dateTimePicker1.Value = currentDate.AddDays(1);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = chosenDate.Subtract(DateTime.Now);
            string weeks = (ts.Days / 7).ToString();
            txtTime.Text = string.Format(weeks + " Weeks\n" + ts.ToString("d' Days\n'h' Hours\n'm'Minutes\n's' Seconds'"));
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            chosenDate = dateTimePicker1.Value;
        }


    }
}
