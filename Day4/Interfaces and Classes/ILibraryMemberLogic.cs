namespace Day4Interfaces;

public interface ILibraryMemberLogic : IBorrow, IReturn
{
    public void ConfirmIsMember();
    
}