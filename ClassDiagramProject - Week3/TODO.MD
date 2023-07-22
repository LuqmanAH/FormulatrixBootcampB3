# TODO List

Chess class diagram To do list

## Easy to implement

- Decouple HumanPlayer Class by:
  
  - ~~Remove MakeMove() method in order to generalize the HumanPlayer class. Also remove from the Interface~~
  - ~~Remove IsWhite() method in order to make the HumanPlayer class reusable in games without colors~~

## Revamp the GR mechanism to track pieces, and determine player side

- ~~Introduce Color Enum to be implemented by the ChessGame runner~~
- ~~Introduce a Dictionary field to store player color settings in GR~~
- ~~Field to determine which turn currently the game is better assigned to refer the instance of the IPlayer itself rather than boolean value~~
- ~~Every player should have a list of pieces in possesion to track~~
- ~~This tracker should be implemented as field in GR as a dictionary in which a list of pieces corresponds to a player available in the game~~
- ~~This removes the requirement to have IsWhite() method for each piece~~

## Revamp board layouting mechanism

- Remove the use of cell class to prevent unecessary memory hog
- Board should refer directly to Position Class to define the boundary of the game

## Revamp movement engine

- Implement list of possible move for each piece in a given board condition

## Pawn New Feature

- Implement MoveCounter to allow the pawn move further initially
- En Passant move capability

## Last to Configure

- Multiplicity for each relationship
