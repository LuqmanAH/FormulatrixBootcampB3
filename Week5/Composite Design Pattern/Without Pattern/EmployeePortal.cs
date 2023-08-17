namespace NoPattern;

public class EmployeePortal
{
    public string ManagerAssignWork(Manager manager, params Engineer[] subordinates)
    {
        manager.AddSubordinate(subordinates);
        return manager.Work();
    }
}
