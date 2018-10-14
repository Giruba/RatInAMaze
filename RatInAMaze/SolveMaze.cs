using System;
using System.Collections.Generic;
using System.Text;

namespace RatInAMaze
{
    class SolveMaze
    {
        int[,] solutionMatrix { get; set; }

        public SolveMaze(int length) {
            solutionMatrix = new int[length, length];
        }

        private bool isSafe(int x, int y, int[,] inputMatrix) {
            int length = inputMatrix.GetLength(0) - 1 ;
            if (x >= 0 && y >= 0 && x <= length && y <= length
                && inputMatrix[x, y] == 1) {
                return true;
            }
            return false;
        }

        private bool SolveMazeUtil(int[,] inputMatrix, int[,] solutionMatrix, int x, int y) {
            
            if ( x == inputMatrix.GetLength(0) - 1 && inputMatrix.GetLength(0) - 1 == y) {
                solutionMatrix[x,y] = 1;
                return true;
            }

            if (isSafe(x, y, inputMatrix))
            {
                //Set the path in Solution Matrix
                solutionMatrix[x, y] = 1;

                //Move down and forward to find paths
                if (SolveMazeUtil(inputMatrix,solutionMatrix, x + 1, y)) return true;

                if (SolveMazeUtil(inputMatrix,solutionMatrix, x, y + 1)) return true;

                //Backtrack if finding paths does not work
                solutionMatrix[x, y] = 0;
                return false;
            }
            //If the path cannot be explored, return false
            return false;
        }

        public void SolveMazeProblem(int[,] givenMatrix) {

            if (SolveMazeUtil(givenMatrix,solutionMatrix, 0, 0))
            {
                Console.WriteLine("The maze problem is solved!");
                PrintSolutionMatrix();
            }
            else {
                Console.WriteLine("No solution for the maze problem!");
                PrintSolutionMatrix();

            }
        }

        private void PrintSolutionMatrix() {
            for (int i = 0; i < solutionMatrix.GetLength(0); i++) {
                for (int j = 0; j < solutionMatrix.GetLength(0); j++) {
                    Console.Write(solutionMatrix[i,j]);
                }
            }
        }

    }
}
