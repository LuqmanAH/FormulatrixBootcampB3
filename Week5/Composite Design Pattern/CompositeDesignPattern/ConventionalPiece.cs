namespace NoPattern;
public class Piece
{
    public string? PieceName {get; private set;}

    public Piece (string pieceName = "pion")
    {
        PieceName = pieceName;
    }

    public bool SetPieceName(string pieceName)
    {
        PieceName = pieceName;
        return true;
    }
}
