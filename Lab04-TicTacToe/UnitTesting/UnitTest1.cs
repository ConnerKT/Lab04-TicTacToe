using Lab04TicTacToe;


namespace Lab04TicTacToe.Tests
{
    public class TicTacToeTests
    {
        [Theory]
        [InlineData("X", "X", "X")]
        [InlineData("4", "5", "6")]
        [InlineData("7", "8", "9")]
        public void CheckForWin_ShouldReturnTrue_WhenThereIsAWinningRow(string marker1, string marker2, string marker3)
        {
            // Arrange
            Program.Board = new string[][] {
                new string[]{ marker1, marker2, marker3 },
                new string[]{ "4", "5", "6" },
                new string[]{ "7", "8", "9" }
            };

            // Act
            bool result = Program.CheckForWin();

            // Assert
            Assert.True(result);
        }

    }
}