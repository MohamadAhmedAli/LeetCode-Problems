public class Solution {
    public bool IsValidSudoku(char[][] board) {
    Dictionary<char,int> dict = new Dictionary<char,int>();

    for(int i = 0;i<board.Length;i++)
    {
        dict.Clear();
        for(int j = 0;j<board[i].Length;j++)
        {
            if (char.IsDigit(board[i][j]))
            {
                if(dict.ContainsKey(board[i][j]))
                    return false;
                else
                    dict.Add(board[i][j], 1);
            }
        }
    }

    for (int i = 0; i < board.Length; i++)
    {
        dict.Clear();
        for (int j = 0; j < board[i].Length; j++)
        {
            if (char.IsDigit(board[j][i]))
            {
                if (dict.ContainsKey(board[j][i]))
                    return false;
                else
                    dict.Add(board[j][i], 1);
            }
        }
    }
    dict.Clear();
    for (int i = 0; i < 9; i++)
        { 

            for (int j = 0; j < 3; j++)
            {

                if (char.IsDigit(board[i][j]))
                {
                    if (dict.ContainsKey(board[i][j]))
                        return false;
                    else
                        dict.Add(board[i][j], 1);
                }
            if ((j + 1) % 3 == 0 && (i + 1) % 3 == 0)
                dict.Clear();

            if ((j + 1) % 3 == 0)
                break;

        }
        }
        for (int i = 0; i < 9; i++)
        {

            for (int j = 3; j < 6; j++)
            {
                

                if (char.IsDigit(board[i][j]))
                {
                    if (dict.ContainsKey(board[i][j]))
                        return false;
                    else
                        dict.Add(board[i][j], 1);
                }
                if ((j + 1) % 3 == 0 && (i + 1) % 3 == 0)
                    dict.Clear();

                if ((j + 1) % 3 == 0)
                    break;

        }
    }
        for (int i = 0; i <9; i++)
        {

            for (int j = 6; j < 9; j++)
            {

                if (char.IsDigit(board[i][j]))
                {
                    if (dict.ContainsKey(board[i][j]))
                        return false;
                    else
                        dict.Add(board[i][j], 1);
                }
                if ((j + 1) % 3 == 0 && (i + 1) % 3 == 0)
                    dict.Clear();

                if ((j + 1) % 3 == 0)
                    break;

        }
        }

        
    return true;
}
}