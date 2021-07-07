using System;
using System.Collections.Generic;
using System.Text;

namespace WorkTime4
{
    class job
    {
        public string jobName;
        public DateTime startTime;
        public string time;



        public job(string newJobName, DateTime newStartTime)
        {
            this.jobName = newJobName;
            this.startTime = newStartTime;
        }

        public void addJob(string newJobName, DateTime newStartTime)
        {

        }
    }
}
