```mermaid
classDiagram
%%  Extension
Piece <|-- King : Extends
Piece <|-- Queen : Extends
Piece <|-- Bishop : Extends
Piece <|-- Knight : Extends
Piece <|-- Rook : Extends
Piece <|-- Pawn : Extends

%% Implementation of IPlayer. May be further expanded
HumanPlayer ..|> IPlayer : Implements

%% Baseline default object
ChessBoard ..|> IBoard : implements
Piece "1"<--"1" Position
ChessGame "1"o--"2..32" Piece

%% Movement Engine
ChessMove ..|> IMove : implements
ChessMove "1"<--"6" ChessMoveSet
ChessGame "1"o--"1" ChessMove
Piece "1"-->"1" ChessMove

%% Game Env Generation
ChessGame "1"o--"2" IPlayer
ChessGame "1"*--"1" ChessBoard
ChessGame ..|> GameStatus : Uses
ChessGame ..|> PlayerColor : Uses
ChessGame ..|> PromoteTo : Uses

class ChessGame{
    +board  ChessBoard
    -playerList Dictionary ~PlayerColor.IPlayer~
    -piecesList Dictionary ~List~Piece~.IPlayer~
    -validMoves Dictionary ~ChessMove.Board~
    -currentTurn IPlayer
    +gameStatus GameStatus
    +StartGame() void
    +FinishGame() void
    +CheckGameStatus() GameStatus
    +SetGameStatus() void
    +IsValidMove() bool
    +PlayerWillBeInCheck() bool
    +PawnPromotion() PromoteTo
    +MakeMove(Piece, Position, validMoves) ChessMove

}
class GameStatus{
    <<Enumeration>>
    ONGOING
    BLACK_WIN
    WHITE_WIN
    STALEMATE
}
class PromoteTo{
    <<Enumeration>>
    QUEEN
    ROOK
    BISHOP
    KNIGHT
}
class PlayerColor{
    <<Enumeration>>
    WHITE
    BLACK
}
class ChessBoard{
    
    +size int
    +InitializeBoard() void
    +GetBoardSize() int

}
class IBoard{
    <<Interface>>
    +GetBoardSize() int
}
class IPlayer{
    <<Interface>>
    +GetName() string
    +GetUID() int
}
class HumanPlayer{
    
    +playername string
    +playerID int
    +GetName() string
    +GetUID() int
}
class ChessMove{
    
    +MovementLibrary Dictionary ~Piece.ChessMoveSet~
    +IsCastling() bool
    +IsEnPassant() bool
    +IsPromotion() bool

}
class IMove{
    <<Interface>>
    +GetOrigin() Position
    +GetDestination() Position
    +SetDestination(Position destintation) void
}
class ChessMoveSet{
    +SinglePawnMove()
    +DoublePawnMove()
    +EnPassant()
    +BishopDiagonalSlide()
    +RookOrthogonalSlide()
    +KnightL()
    +QueenMove()
    +KingMove()
}
class Position{
    
    +rank  int
    +files  int
}
class Piece{
    <<Abstract>>
    +captured  bool
    +position Position
}
class King{
    
    +castlingDone bool
    +IsInCheck bool
}
class Queen{
    
}
class Knight{
    

}
class Bishop{
    
    
}
class Rook{
    

}
class Pawn{
    
    +promotionStatus bool
    +moveCount int
    +EnPassantStatus bool
    +GetPromotionStatus() bool
    +GetEnPassantStatus() bool
    +GetMoveCount() int
}
```