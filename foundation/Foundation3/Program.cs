using System;

class Program
{
    static void Main(string[] args)
    {
        RunningActivity runningActivity = new RunningActivity("23 May 2015", 80, 10);
        CyclingActivity cyclingActivity = new CyclingActivity("03 Jul 2015", 60, 5.5);
        SwimmingActivity swimmingActivity = new SwimmingActivity("14 Aug 2015", 150, 13);

        List<Activity> activities = new List<Activity>
        {
            runningActivity, cyclingActivity, swimmingActivity
        };

        foreach (var activity in activities)
        {
            Console.WriteLine();
            Console.WriteLine(activity.GetSummary());
        }
        Console.WriteLine();
    }
}