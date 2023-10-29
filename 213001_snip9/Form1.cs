using System;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace _213001_snip9
{
    public partial class Form1 : Form
    {
        private object label2;

        public Form1()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            label1.Text = "Month Calendar Date: " + monthCalendar1.SelectionStart.ToLongDateString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label2.Text = "Date Time Picker: " + dateTimePicker1.Text;
        }
    }
}
