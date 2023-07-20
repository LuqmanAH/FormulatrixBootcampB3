# Chess Game Class Diagram

## Game features

- Classic 2-player black vs white chess layout. Each side start with 16 pieces from a range of 6 different types of piece. The board itself has the size of 8 by 8 cell class unit. The piece position and movement direction are governed by the coordinate system namely files and ranks.
- Castling move and Pawn promotion ability are provided within the class diagram

## The Design Thought Process

The game is divided into several objects as the building blocks.

- Game Layouting Object

  - Position --> define the coordinate of the board
  - Cell &nbsp; &nbsp; &nbsp;  --> Object with defined unit size and position class where a piece may inhabit
  - Board &nbsp; &nbsp; --> Main board that refer to Cell class and mandatory for game runner to exist

- Pieces

  - Piece abstract &nbsp; &nbsp; --> base class that provides essential fields for derived specific class
  - king derived class --> extends by enabling castling move and check status
  - pawn derived class --> extends by enabling promotion move

- Movement Engine

  - Evaluates the piece to be moved, origin and destination cell, player that invoke the piece movement, and evaluates whether the move would kill opposing piece or a castling move

- Player

  - General interface to implement Human Player or AI Player binded by the method MakeMove()

- Game Runner

  - starts game and terminates game based on player
  - Pertains the board object
  - Continuously evaluate the pieces position to evaluate the game status
  - Evaluates whether the finished game has a winner or stalemate
  