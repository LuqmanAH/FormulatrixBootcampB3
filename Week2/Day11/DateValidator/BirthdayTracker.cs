namespace BirthdayTracker;

public class BirthdayTracker
{
    private Dictionary<string, DateTime> _birthdays;
    public BirthdayTracker()
    {
        _birthdays = new Dictionary<string, DateTime>();
    }
    public DateTime GetBirthDay(string name)
    {
        return _birthdays[name];
    }
    public int GetBirthDayMonth(string name)
    {
        return _birthdays[name].Month;
    }
    public void AddBirthday(string name, DateTime birthday)
    {
        if (!_birthdays.ContainsKey(name))
        {
            _birthdays.Add(name, birthday);
        }
        else
        {
            _birthdays[name] = birthday;
        }
    }
    protected int DaysUntilBirthday(string name)
    {
        int thisMonth = DateTime.Today.Month;
        int birthdayMonth = _birthdays[name].Month;
        if (birthdayMonth - thisMonth > 0)
        {
            return birthdayMonth - thisMonth;
        }
        return 12 - thisMonth + birthdayMonth;
    }
    protected int EstimateAge(string name)
    {
        int bornYear = _birthdays[name].Year;
        int thisYear = DateTime.Today.Year;
        if (thisYear - bornYear > 0)
        {
            return thisYear - bornYear;
        }
        return -1;
    }
    public string GreetUser(string name)
    {
        return $"Hi {name}, your birthday is in {DaysUntilBirthday(name)} months. Hope you're alive until then!";
    }
    public string SpitTheAge(string name)
    {
        if (EstimateAge(name) != -1)
        {
            return $"Hi {name}, from my exceptional computation ability i estimate that you are {EstimateAge(name)} years old, what a legend!";
        }
        return "bruh, you're not even born yet dude";
    }
}