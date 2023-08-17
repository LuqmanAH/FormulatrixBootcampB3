namespace NoPattern;

public class Engineer
{
    public string Name {get; private set;}
    public Engineer(string name)
    {
        Name = name;
    }
    public string Role()
    {
        return "Developer";
    }
    public string Work()
    {
        return$"Diligently writing some codes..";
    }
    public bool HasSubordinates()
    {
        return false;
    }
    
}
