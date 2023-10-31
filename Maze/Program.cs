using System;
using Stacks;

namespace Maze
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] maze = {
                {'1', 'E', '1', '1', '1', '1', '1', '1', '1', '1', '1'},
                {'1', '0', '1', '1', '1', '1', '1', '0', '0', '0', '1'},
                {'1', '0', '0', '0', '0', '1', '0', '0', '1', '0', '1'},
                {'1', '0', '1', '1', '0', '0', '1', '0', '1', '0', '1'},
                {'1', '0', '1', '0', '0', '0', '1', '0', '1', '0', '1'},
                {'1', '0', '1', '0', '1', '0', '0', '0', '0', 'S', '1'},
                {'1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1'}
            };

            int startX = -1, startY = -1;

            // Find the start position
            for (int i = 0; i < maze.GetLength(0); i++)
            {
                for (int j = 0; j < maze.GetLength(1); j++)
                {
                    if (maze[i, j] == 'S')
                    {
                        startX = i;
                        startY = j;
                        break;
                    }
                }
                if (startX != -1) break;
            }

            if (startX == -1)
            {
                Console.WriteLine("Start not found.");
                return;
            }

            DisplayMaze(maze, startX, startY);
            ArrayStack path = new ArrayStack(maze.GetLength(0) * maze.GetLength(1));
            //Stack<Tuple<int, int>> path = new Stack<Tuple<int, int>>();// Fix here
            path.push(new Tuple<int, int>(startX, startY));

            while (maze[startX, startY] != 'E')
            {
                maze[startX, startY] = '.';

                // Define arrays to store neighboring coordinates
                int[] neighborX = { startX - 1, startX + 1, startX, startX };
                int[] neighborY = { startY, startY, startY - 1, startY + 1 };

                bool found = false;

                for (int i = 0; i < neighborX.Length; i++)
                {
                    int newX = neighborX[i];
                    int newY = neighborY[i];

                    if (IsValidMove(maze, newX, newY))
                    {
                        path.push(new Tuple<int, int>(newX, newY));
                        startX = newX;
                        startY = newY;
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    Console.WriteLine("exit found.");
                    break;
                }

                DisplayMaze(maze, startX, startY);
            }


            Console.WriteLine("Maze solved!");
        }

        static bool IsValidMove(char[,] maze, int x, int y)
        {
            // Check if the move is within the bounds of the maze and leads to an open path.
            return x >= 0 && x < maze.GetLength(0) && y >= 0 && y < maze.GetLength(1) && maze[x, y] == '0';
        }

        static void DisplayMaze(char[,] maze, int i, int j)
        {
            Console.Clear();
            for (int x = 0; x < maze.GetLength(0); x++)
            {
                for (int y = 0; y < maze.GetLength(1); y++)
                {
                    if (x == i && y == j)
                    {
                        Console.Write('$'); // Current position
                    }
                    else
                    {
                        Console.Write(maze[x, y]);
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            System.Threading.Thread.Sleep(500);
        }
    }
}