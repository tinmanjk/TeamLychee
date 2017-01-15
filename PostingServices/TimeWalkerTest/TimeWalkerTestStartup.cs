namespace TimeWalkerUtility
{
    using System;

    class TimeWalkerTestStartup
    {
        static void Main(string[] args)
        {
            TimeWalker tw = new TimeWalker();

            // it has a ToString override, showing formatted timestamp
            Console.WriteLine(tw);

            // default step is 3 hours
            tw.StepForward();
            tw.StepForward();
            tw.StepForward();
            Console.WriteLine(tw);

            // default step can be increased
            tw.MoveTimeFaster();
            tw.MoveTimeFaster();
            tw.MoveTimeFaster();
            // it is now at 12 hour steps

            tw.StepForward();
            Console.WriteLine(tw);

            tw.StepForward();
            Console.WriteLine(tw);

            // slow down to three hour steps
            tw.MoveTimeSlower();
            tw.MoveTimeSlower();
            tw.MoveTimeSlower();

            tw.StepForward();
            Console.WriteLine(tw);

            // finally, it has some methods to get the values:
            TimeSpan currentStep = tw.GetCurrentStep();
            DateTime currentTime = tw.GetCurrentTime();

            Console.WriteLine("Current step is: ");
            Console.WriteLine(currentStep.ToString(@"dd\.hh\:mm"));
            Console.WriteLine("Current time is: ");
            Console.WriteLine(currentTime.ToString("dd.MM.yyyy HH:MM"));
        }
    }
}
