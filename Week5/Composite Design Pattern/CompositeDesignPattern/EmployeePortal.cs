namespace CompositePattern;

public class EmployeePortal
{
    public string ManagerAssignWork(Employee manager, params Employee[] subordinates)
    {
        if (manager.HasSubordinates())
        {
            manager.AddSubordinate(subordinates);
            return manager.Work();
        }
        return manager.Work();
    }
}
