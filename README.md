# Tic-Tac-Toe

This is a two-player, turn-based Tic-Tac-Toe program. The program allows players to take turns and marks their chosen positions on the game board until a winner is determined or the game ends in a draw.

## Visuals

The program is a console based program so it in your terminal it should look like this:

        It is currently John's turn:

        |1||2||3|
        |4||5||6|
        |7||8||9|
        Choose a slot currently

        It is currently Chloe's turn.
        |X||2||3|
        |4||5||6|
        |7||8||9|
        Choose a slot currently

## Program Specifications

The solution includes the following components:

- **Game Board**: This class constructs and displays the game board after every turn, showing the updated state of the board. It also includes methods to update the board and check for a winner.

- **Player**: This class holds the player's information, such as their name and marker (X or O). It provides actions that the player can take during the game.

- **Game**: This class controls the flow of the game. It manages switching between players, obtaining input from players, and determining the outcome of the game.

- **Position**: This class represents individual positions on the game board.

The program handles a bug where if a player selects a position on the board that is already marked, it prompts the player to retake their turn.

## Getting Started

To play the Tic-Tac-Toe game, follow these steps:

1. Clone the repository to your local machine.
2. Open the project in your preferred IDE or text editor.
3. Run the program.
4. Follow the on-screen instructions to enter the names of the players and their respective markers (X or O).
5. Each player will take turns selecting a position on the game board by entering the corresponding number.
6. The game will display the updated board after each turn.
7. The game ends when a player wins or there is a draw. The program will announce the winner or declare a draw.

## Testing

The program has been tested for the following functionality:

- Validating winning conditions on the game board.
- Ensuring that players switch turns correctly.
- Verifying that the positions chosen by players correlate to the correct index of the game board array.
- Additional unique test cases.

