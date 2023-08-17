namespace CompositePattern;

public class Manager : Employee
{
    protected List<Employee> _employeesHandled = new List<Employee>();
    public Manager(string name) : base(name)
    {

    }
    public override string Role()
    {
        return "Manager";
    }
    public override string Work()
    {
        string workDone = $"{Name} is managing some important stuffs";
        foreach (Employee emp in _employeesHandled)
        {
            workDone += $"\n{emp.Name} is now {emp.Work()}";
        }
        return workDone;
    }
    public override void AddSubordinate(Employee[] employees)
    {
        foreach (Employee emp in employees.Where(emp => !emp.HasSubordinates()))
        {
            _employeesHandled.Add(emp);
        }
    }
    public override void RemoveSubordinate(Employee[] employees)
    {
        foreach (Employee emp in _employeesHandled)
        {
            _employeesHandled.Remove(emp);
        }
    }
}
