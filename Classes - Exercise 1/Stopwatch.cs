using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes___Exercise_1
{
    internal class Stopwatch
    {
        private DateTime StartTime;
        private DateTime StopTime;
        private bool IsStarted;
        private TimeSpan TotalDuration;

        internal Stopwatch()
        {
            Reset();
        }

        internal void Start()
        {
            if (!this.IsStarted)
            {
                this.IsStarted = true;
                this.StartTime = DateTime.Now;
            }
            else
            {
                throw new InvalidOperationException("You may not start the watch twice without stopping first");
            }
        }

        internal void Stop()
        {
            if (this.IsStarted)
            {
                this.StopTime = DateTime.Now;
                this.IsStarted = false;
                TimeSpan duration = this.StopTime - this.StartTime;
                this.TotalDuration += duration;
            }
            else
            {
                throw new InvalidOperationException("You cannot stop a watch twice in a row");
            }
            
        }

        internal void DisplayResult()
        {
            Console.WriteLine($"Duration is {this.TotalDuration}");
        }

        internal void Reset()
        {
            this.IsStarted = false;
            this.TotalDuration = TimeSpan.Zero;
        }
    }
}
