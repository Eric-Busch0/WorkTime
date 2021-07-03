using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkTime4
{
    public partial class Form1 : Form
    {
        private JobManager jManager;
        private string timeEntryDefault = "Time HH:MM";
        private string jobNameDefault = "Enter Job Name...";

        public Form1()
        {
            InitializeComponent();
            jManager = new JobManager();
        }

        private void btnAddJob_Click(object sender, EventArgs e)
        {
            // add some job infor like time and shit
            string name = textJobName.Text;
            DateTime time = dateTimeJobStart.Value;


        }

        private void jobNameEnter(object sender, EventArgs e)
        {
            if (textJobName.Text == "Enter Job Name...")
                textJobName.Text = "";
        }

        private void StartTimeEnter(object sender, EventArgs e)
        {
            if (textTimeEntry.Text.Contains("Time HH:MM"))
            {
                textTimeEntry.Text = "";
                textTimeEntry.ForeColor = Color.Black;
            }

        }

        private void jobNameLeave(object sender, EventArgs e)
        {
            if(textJobName.Text.Length == 0)
            {
                textJobName.Text = jobNameDefault;
                textJobName.ForeColor = Color.DimGray;
            }
        }

        private void startTimeLeave(object sender, EventArgs e)
        {
            if (textTimeEntry.Text.Length == 0)
            {
                textTimeEntry.Text = timeEntryDefault;
                textTimeEntry.ForeColor = Color.DimGray;
            }
        }

        private void textTimeChanged(object sender, EventArgs e)
        {

        }
    }
}
