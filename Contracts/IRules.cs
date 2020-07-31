namespace GreenVsRed.Contracts
{
    public interface IRules
    {
        bool CheckRedToGreen(int cell, int[,] matrix, int row, int col);

        bool CheckGreenToStayGreen(int cell, int[,] matrix, int row, int col);

    }
}
