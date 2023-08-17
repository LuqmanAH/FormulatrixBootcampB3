namespace NoPattern;

public abstract class Employee
{
    public string Name { get; private set; }
    public Employee(string name)
    {
        Name = name;
    }
    public virtual string Role()
    {
        return "Employee";
    }
    public abstract string Work();
    public virtual bool HasSubordinates()
    {
        return true;
    }
    public virtual void AddSubordinate(Employee[] employees)
    {
        throw new NotImplementedException();
    }
    public virtual void RemoveSubordinate(Employee[] employees)
    {
        throw new NotImplementedException();
    }
}
