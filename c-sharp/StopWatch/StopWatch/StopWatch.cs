using System;
using System.Collections.Generic;
using System.Text;

namespace StopWatch
{
    class StopWatch
    {
        private DateTime starTime;
        private DateTime endTime;
        public DateTime StarTime
        {
            get => starTime;
            set => starTime = value;
        }
        public DateTime EndTime
        {
            get => endTime;
            set => endTime = value;
        }
        public DateTime Start()
        {
            return StarTime = System.DateTime.Now;
        }
        public DateTime End()
        {
            return EndTime = System.DateTime.Now;
        }
        public DateTime GetElapsedTime()
        {
            return 
        }
    }
}
