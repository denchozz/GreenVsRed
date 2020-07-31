namespace GreenVsRed
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            //Choose the size of the grid

            Console.Write("X = ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Y = ");
            int y = int.Parse(Console.ReadLine());

            //Check if X is bigger than Y
            if (x > y)
            {
                Console.WriteLine("X must be smaller or equal to Y! Change your values!");
                return;
            }

            //Check if Y is bigger or equal to 1000
            if (y >= 1000)
            {
                Console.WriteLine("Y must be smaller than 1000! Change your value!");
                return;
            }

            int[,] matrix = new int[x, y];

            //Add 0s and 1s to the matrix
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] matrixRow = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();

                //Fill the matrix row
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = matrixRow[col];
                }
            }

            int[] cellAndTurns = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int[] cell = new int[2];
            cell[0] = cellAndTurns[1];
            cell[1] = cellAndTurns[0];

            int turns = cellAndTurns[2];

            int generations = 0;

            Rules rules = new Rules();

            int[,] currentMatrixState = new int[x, y];

            //Check the Initial matrix if the selected cell is already green
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 1 &&
                        row == cell[0] &&
                        col == cell[1])
                    {
                        generations++;
                    }
                    
                }
            }


            //Fill the temporary matrix
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    currentMatrixState[row, col] = matrix[row, col];
                }
            }

            while (turns > 0)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (matrix[row, col] == 0 &&
                            row == cell[0] &&
                            col == cell[1] &&
                            rules.CheckRedToGreen(matrix[row, col], matrix, row, col) == true)
                        {
                            currentMatrixState[row, col] = 1;
                            generations++;
                        }
                        else if (matrix[row, col] == 0 &&
                            rules.CheckRedToGreen(matrix[row, col], matrix, row, col) == true)
                        {
                            currentMatrixState[row, col] = 1;
                        }
                        else if (matrix[row, col] == 1 &&
                            row == cell[0] &&
                            col == cell[1] &&
                            rules.CheckGreenToStayGreen(matrix[row, col], matrix, row, col) == true)
                        {
                            currentMatrixState[row, col] = 1;
                            generations++;
                        }
                        else if (matrix[row, col] == 1 &&
                            rules.CheckGreenToStayGreen(matrix[row, col], matrix, row, col) == true)
                        {
                            currentMatrixState[row, col] = 1;
                        }
                        else
                        {
                            currentMatrixState[row, col] = 0;
                        }
                    }
                }

                //Change the main matrix values
                for (int row = 0; row < currentMatrixState.GetLength(0); row++)
                {
                    for (int col = 0; col < currentMatrixState.GetLength(1); col++)
                    {
                        matrix[row, col] = currentMatrixState[row, col];
                    }
                }

                turns--;
            }

            Console.WriteLine(generations);
        }
    }
}
