using System;

namespace PostingServices.Core.Infrastructure.Utils
{
    public class TimeWalker
    {
        private static DateTime defaultStart = new DateTime(2017, 01, 01, 08, 00, 00);
        private static TimeSpan defaultStep = new TimeSpan(0, 3, 0, 0); // Default three hours
        private static TimeSpan defaultIncrementsTimeSpan = new TimeSpan(0, 3, 0, 0); // Default three hours

        private static TimeWalker instance = new TimeWalker(defaultStart, defaultIncrementsTimeSpan);        

        private DateTime startPoint;
        private TimeSpan timeStep;
        private DateTime currentDateTime;
        private TimeSpan currentStep;

        public static TimeWalker Instance
        {
            get
            {
                return instance;
            }
        }

        private TimeWalker(DateTime startDateTime, TimeSpan timeSpanInterval)
        {
            this.startPoint = startDateTime;
            this.currentDateTime = startDateTime;
            this.timeStep = timeSpanInterval;
            this.currentStep = timeSpanInterval;
        }

        public DateTime StartPoint
        {
            get
            {
                return this.startPoint;
            }
        }
        public TimeSpan TimeStep
        {
            get
            {
                return this.timeStep;
            }
        }


        public DateTime StepForward()
        {
            NotifyOfTimeChange(new EventArgs());
            return this.currentDateTime += this.currentStep;
        }

        public void MoveTimeFaster()
        {
            this.currentStep += defaultIncrementsTimeSpan;
        }

        public void MoveTimeSlower()
        {
            this.currentStep -= defaultIncrementsTimeSpan;
        }

        public DateTime GetCurrentTime()
        {
            return this.currentDateTime;
        }

        public TimeSpan GetCurrentStep()
        {
            return this.currentStep;
        }

        public override string ToString()
        {
            return String.Format("It is now: {0}", currentDateTime.ToString("dd.MM.yyyy HH:MM"));
        }

        public event EventHandler TimeChanged;

        public void NotifyOfTimeChange(EventArgs e)
        {
            if(TimeChanged != null)
            {
                TimeChanged.Invoke(this, e);
            }
        }
    }
}
