using System;

namespace BirthdayTracker;

public partial class Program
{
    public static void Main(string[] args)
    {
        BirthdayTracker tracker = new BirthdayTracker();
        tracker.AddBirthday("popo", new DateTime(1980, 2, 13));
        tracker.AddBirthday("Limosin", new DateTime(2000, 8, 13));
        tracker.AddBirthday("bayek", new DateTime(2025, 7, 14));

        DisplayStuff(tracker.GreetUser("popo"));
        DisplayStuff(tracker.GetBirthDay("popo").ToString());
        DisplayStuff(tracker.GetBirthDayMonth("popo").ToString());
        DisplayStuff(tracker.GreetUser("Limosin"));

        DisplayStuff(tracker.SpitTheAge("popo"));
        DisplayStuff(tracker.SpitTheAge("bayek"));
    }
}