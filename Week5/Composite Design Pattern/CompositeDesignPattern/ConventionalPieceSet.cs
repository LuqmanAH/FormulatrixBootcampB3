namespace NoPattern;
public class ConventionalPieceList
{
    public string? ListPieceName { get; private set; }
    public IEnumerable<Piece> pieces{ get; private set; }

    public ConventionalPieceList(string listName = "pieceList")
    {
        ListPieceName = listName;
        pieces = new List<Piece>();
    }

    public bool SetListName(string listName)
    {
        ListPieceName = listName;
        return true;
    }

    public bool AddPiece(Piece piece)
    {
        pieces.Append(piece);
        return true;
    }
}
