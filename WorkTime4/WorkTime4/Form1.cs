﻿using System;
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
        private string prevTimeString = "";
        private string lastKeyPressed;
        private string allowableTimeChars = "1234567890:";
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
            if (textJobName.Text.Length == 0)
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
            string currentString = textTimeEntry.Text;
            
            if (lastKeyPressed == "\b" || currentString.Length == 0)
            {
                return;
            }

            foreach (char c in currentString)
            {
                if (!allowableTimeChars.Contains(c.ToString()))
                {
                    textTimeEntry.Text = prevTimeString;
                    return;
                }
            }

            if (currentString[0] > '1' && currentString.Length > 4)
            {
                textTimeEntry.Text = prevTimeString;
                return;
            }
            else if(currentString[0] == '1' && currentString.Length > 5)
            {
                textTimeEntry.Text = prevTimeString;
                return;
            }

            if (currentString.Length < 2 && currentString.Length != 0)
            {
                if (currentString[0] > '1')
                {
                    textTimeEntry.Text += ":";
                }


            }
            else if (currentString.Length == 2 && !currentString.Contains(":"))
            {
                textTimeEntry.Text += ":";
            }
            textTimeEntry.SelectionStart = textTimeEntry.Text.Length;
            prevTimeString = currentString;
        }

        private void keyPressEvent(object sender, KeyPressEventArgs e)
        {
            lastKeyPressed = e.KeyChar.ToString();
        }
    }
}
