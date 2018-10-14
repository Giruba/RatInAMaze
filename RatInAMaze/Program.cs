using System;

namespace RatInAMaze
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rat In a Maze!");
            Console.WriteLine("---------------");
            
            Console.WriteLine("Enter the number of dimensions of the maze");
            int noOfDimensions = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the matrix' contents");
            int[,] matrix = new int[noOfDimensions, noOfDimensions];
            for (int i = 0; i < noOfDimensions; i++) {
                for (int j = 0; j < noOfDimensions; j++) {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            SolveMaze solveMaze = new SolveMaze(noOfDimensions);
            solveMaze.SolveMazeProblem(matrix);

            Console.ReadKey();
        }
    }
}
