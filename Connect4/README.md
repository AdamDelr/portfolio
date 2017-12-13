Connect 4 project by Adam del Rosario

Files:
-WPF GUI files-
MainWindow.xaml.cs
MainWindow.xaml

-Code files-
GameState.cs
Contains game state info
slotArray: Array that holds the current state of the game "Slots".
Slot:      Inner class to represent game board data.
redTurn:   Bool value holds who's turn it is

Logic.cs
Logic to declare a winner.
checkWin:  Large function that takes in the GameState and returns a winner if one exists.

Animate.cs
Manipulates the WPF objects to animate and run the game.
delayedExecute: Helper function used to animate the game pieces and prevent player from double clicking
dropPiece:      Sets the GameState and animates the game piece   
