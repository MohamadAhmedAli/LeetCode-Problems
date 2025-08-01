public class Solution {
    public void SetZeroes(int[][] matrix) {
    int[] rows = new int[matrix.Length];
    int[] columns = new int[matrix[0].Length];
    for (int i = 0; i < matrix.Length; i++)
    {
        for (int j = 0; j < matrix[i].Length; j++)
        {
            if (matrix[i][j] == 0)
            {
                rows[i] = 1;
                columns[j] = 1;
            }
        }
    }

    for (int i = 0; i < matrix.Length; i++)
    {
        for (int j = 0; j < matrix[i].Length; j++)
        {
            if (rows[i] == 1 || columns[j] == 1)
                matrix[i][j] = 0;
        }
    }

}
}