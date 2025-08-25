
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lights_out.Models
{
    public class GameStateGenerator : IGameStateGenerator
    {
        public void GenerateSolvableState(List<Button> boardButtons, int rowCount, int columnCount, ref GameRecord currentGameRecord)
        {
            Random rand = new Random();
            currentGameRecord.InitialState = new List<bool>();

            // Generate a random state for the lights (ON or OFF)
            for (int row = 0; row < rowCount; row++)
            {
                for (int col = 0; col < columnCount; col++)
                {
                    bool isOn = rand.Next(0, 2) == 0;
                    Button button = boardButtons[row * columnCount + col];
                    button.BackColor = isOn ? Color.LightGreen : SystemColors.Control;
                    button.ForeColor = isOn ? Color.Black : Color.Gray;
                    currentGameRecord.InitialState.Add(isOn);
                }
            }

            // Check if the generated state is solvable
            if (!IsSolvable(rowCount, columnCount, ref currentGameRecord))
            {
                // If not solvable, regenerate the board state
                GenerateSolvableState(boardButtons, rowCount, columnCount, ref currentGameRecord);
            }
        }

        private bool IsSolvable(int rowCount, int columnCount, ref GameRecord currentGameRecord)
        {
            // Convert the initial state into a matrix of 0s and 1s
            int[] puzzleState = currentGameRecord.InitialState!.Select(x => x ? 1 : 0).ToArray();

            // Create the adjacency matrix
            int[,] adjacencyMatrix = CreateAdjacencyMatrix(rowCount, columnCount);

            // Solve the system of equations to check if it's solvable
            return SolvePuzzle(puzzleState, adjacencyMatrix, rowCount * columnCount);
        }

        private int[,] CreateAdjacencyMatrix(int rowCount, int columnCount)
        {
            int[,] matrix = new int[rowCount * columnCount, rowCount * columnCount];

            for (int row = 0; row < rowCount; row++)
            {
                for (int col = 0; col < columnCount; col++)
                {
                    int idx = row * columnCount + col;

                    // Toggle the button itself
                    matrix[idx, idx] = 1;

                    // Toggle the buttons in adjacent positions
                    if (row > 0) matrix[idx, idx - columnCount] = 1; // Button above
                    if (row < rowCount - 1) matrix[idx, idx + columnCount] = 1; // Button below
                    if (col > 0) matrix[idx, idx - 1] = 1; // Button to the left
                    if (col < columnCount - 1) matrix[idx, idx + 1] = 1; // Button to the right
                }
            }

            return matrix;
        }

        private bool SolvePuzzle(int[] puzzleState, int[,] adjacencyMatrix, int n)
        {
            // Solve the system of linear equations using Gaussian Elimination or other methods
            int[,] augmentedMatrix = new int[n, n + 1];

            // Create augmented matrix (Adjacency Matrix | Puzzle State)
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    augmentedMatrix[i, j] = adjacencyMatrix[i, j];
                }
                augmentedMatrix[i, n] = puzzleState[i];
            }

            // Perform Gaussian elimination
            for (int i = 0; i < n; i++)
            {
                // Find the row with the maximum value in column i
                int maxRow = i;
                for (int k = i + 1; k < n; k++)
                {
                    if (Math.Abs(augmentedMatrix[k, i]) > Math.Abs(augmentedMatrix[maxRow, i]))
                    {
                        maxRow = k;
                    }
                }

                // Swap the current row with the max row
                for (int j = i; j <= n; j++)
                {
                    int temp = augmentedMatrix[i, j];
                    augmentedMatrix[i, j] = augmentedMatrix[maxRow, j];
                    augmentedMatrix[maxRow, j] = temp;
                }

                // Make the diagonal element 1 and eliminate other entries in the column
                for (int k = i + 1; k < n; k++)
                {
                    if (augmentedMatrix[k, i] != 0)
                    {
                        int factor = augmentedMatrix[k, i] / augmentedMatrix[i, i];
                        for (int j = i; j <= n; j++)
                        {
                            augmentedMatrix[k, j] -= factor * augmentedMatrix[i, j];
                        }
                    }
                }
            }

            // Check if the system has a solution (no row of the form [0...0 | non-zero])
            for (int i = n - 1; i >= 0; i--)
            {
                if (augmentedMatrix[i, n] != 0)
                {
                    return true;
                }
            }

            return false;
        }
    }

}
