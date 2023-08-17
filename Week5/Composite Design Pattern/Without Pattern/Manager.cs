namespace NoPattern;

public class Manager
{
    public string Name {get; private set;}
    protected List<Engineer> _engineerHandled = new List<Engineer>();
    public Manager(string name)
    {
        Name     = name;
    }
    public string Role()
    {
        return "Manager";
    }
    public string Work()
    {
        string workDone = $"{Name} is managing some important stuffs";
        foreach (var eng in _engineerHandled)
        {
            workDone += $"\n{eng.Name} is now {eng.Work()}";
        }
        return workDone;
    }
    public void AddSubordinate(Engineer[] engineers)
    {
        foreach (var eng in engineers.Where(eng => !eng.HasSubordinates()))
        {
            _engineerHandled.Add(eng);
        }
    }
    public void RemoveSubordinate(Engineer[] engineers)
    {
        foreach (var eng in _engineerHandled)
        {
            _engineerHandled.Remove(eng);
        }
    }
}
