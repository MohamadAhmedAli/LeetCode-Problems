public class Solution {
    public void GameOfLife(int[][] board) {
    int ones = 0;
    int zeros = 0;
    int[][] res = new int[board.Length][];
    for (int i = 0; i < board.Length; i++)
    {
        res[i] = new int[board[i].Length];
        Array.Copy(board[i], res[i], res[i].Length);
    }
           
    for (int i = 0; i < board.Length; i++)
    {
        for (int j = 0; j < board[i].Length; j++)
        {
            zeros = 0;
            ones = 0;

            if ((j - 1) >= 0)
            {
                if (board[i][j - 1] == 0)
                    zeros++;
                else
                    ones++;
            }

            if ((j - 1) >= 0 && (i - 1) >= 0)
            {
                if (board[i - 1][j - 1] == 0)
                    zeros++;
                else
                    ones++;
            }

            if ((j + 1) < board[i].Length && (i - 1) >= 0)
            {
                if (board[i - 1][j + 1] == 0)
                    zeros++;
                else
                    ones++;
            }

            if ((j + 1) < board[i].Length && (i + 1) < board.Length)
            {
                if (board[i + 1][j + 1] == 0)
                    zeros++;
                else
                    ones++;
            }

            if ((i - 1) >= 0)
            {
                if (board[i - 1][j] == 0)
                    zeros++;
                else
                    ones++;
            }
            if ((j + 1) < board[i].Length)
            {
                if (board[i][j + 1] == 0)
                    zeros++;
                else
                    ones++;
            }

            if ((i + 1) < board.Length)
            {
                if (board[i + 1][j] == 0)
                    zeros++;
                else
                    ones++;
            }

            if ((j - 1) >= 0 && (i + 1) < board.Length)
            {
                if (board[i + 1][j - 1] == 0)
                    zeros++;
                else
                    ones++;
            }

            if (board[i][j] == 1)
            {
                if (ones < 2)
                    res[i][j] = 0;
                else if (ones == 2 && ones == 3)
                    res[i][j] = 1;
                else if (ones > 3)
                    res[i][j] = 0;
            }
            else
            {
                if (ones == 3)
                    res[i][j] = 1;
            }
        }
        
    
    }
    for (int i = 0; i < board.Length; i++)
    {
        Array.Copy( res[i], board[i], res[i].Length);
    }
}
}