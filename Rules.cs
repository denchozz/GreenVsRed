using GreenVsRed.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace GreenVsRed
{
    public class Rules : IRules
    {
        public bool CheckRedToGreen(int cell, int[,] matrix, int row, int col)
        {
            int counter = 0;


            for (int i = row; i < matrix.GetLength(0);)
            {
                for (int j = col; j < matrix.GetLength(1);)
                {
                    try
                    {
                        if (matrix[row, col + 1] == 1)
                        {
                            counter++;
                        }
                    }
                    catch (System.IndexOutOfRangeException)
                    { }

                    try
                    {
                        if (matrix[row, col - 1] == 1)
                        {
                            counter++;
                        }
                    }
                    catch (System.IndexOutOfRangeException)
                    { }

                    try
                    {
                        if (matrix[row + 1, col] == 1)
                        {
                            counter++;
                        }
                    }
                    catch (System.IndexOutOfRangeException)
                    { }

                    try
                    {
                        if (matrix[row - 1, col] == 1)
                        {
                            counter++;
                        }
                    }
                    catch (System.IndexOutOfRangeException)
                    { }

                    try
                    {
                        if (matrix[row - 1, col - 1] == 1)
                        {
                            counter++;
                        }
                    }
                    catch (System.IndexOutOfRangeException)
                    { }

                    try
                    {
                        if (matrix[row - 1, col + 1] == 1)
                        {
                            counter++;
                        }
                    }
                    catch (System.IndexOutOfRangeException)
                    { }

                    try
                    {
                        if (matrix[row + 1, col - 1] == 1)
                        {
                            counter++;
                        }
                    }
                    catch (System.IndexOutOfRangeException)
                    { }

                    try
                    {
                        if (matrix[row + 1, col + 1] == 1)
                        {
                            counter++;
                        }
                    }
                    catch (System.IndexOutOfRangeException)
                    { }

                    break;
                }

                break;
            }
            
            

            if (counter == 3 ||
                counter == 6)
            {
                return true;
            }

            return false;
        }

        public bool CheckGreenToStayGreen(int cell, int[,] matrix, int row, int col)
        {
            int counter = 0;


            for (int i = row; i < matrix.GetLength(0);)
            {
                for (int j = col; j < matrix.GetLength(1);)
                {
                    try
                    {
                        if (matrix[row, col + 1] == 1)
                        {
                            counter++;
                        }
                    }
                    catch (System.IndexOutOfRangeException)
                    { }

                    try
                    {
                        if (matrix[row, col - 1] == 1)
                        {
                            counter++;
                        }
                    }
                    catch (System.IndexOutOfRangeException)
                    { }

                    try
                    {
                        if (matrix[row + 1, col] == 1)
                        {
                            counter++;
                        }
                    }
                    catch (System.IndexOutOfRangeException)
                    { }

                    try
                    {
                        if (matrix[row - 1, col] == 1)
                        {
                            counter++;
                        }
                    }
                    catch (System.IndexOutOfRangeException)
                    { }

                    try
                    {
                        if (matrix[row - 1, col - 1] == 1)
                        {
                            counter++;
                        }
                    }
                    catch (System.IndexOutOfRangeException)
                    { }

                    try
                    {
                        if (matrix[row - 1, col + 1] == 1)
                        {
                            counter++;
                        }
                    }
                    catch (System.IndexOutOfRangeException)
                    { }

                    try
                    {
                        if (matrix[row + 1, col - 1] == 1)
                        {
                            counter++;
                        }
                    }
                    catch (System.IndexOutOfRangeException)
                    { }

                    try
                    {
                        if (matrix[row + 1, col + 1] == 1)
                        {
                            counter++;
                        }
                    }
                    catch (System.IndexOutOfRangeException)
                    { }

                    break;
                }

                break;
            }



            if (counter == 2 ||
                counter == 3 ||
                counter == 6)
            {
                return true;
            }

            return false;
        }
    }
}
