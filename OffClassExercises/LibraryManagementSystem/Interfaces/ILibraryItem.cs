namespace LibraryInterfaces;

public interface IPrinted
{
    public string Title();
    public string Author();
    public int PublicationYear();
    public int NumberOfPage();
}

public interface IDigital
{
    public string Filesize();
    public string URL();
}