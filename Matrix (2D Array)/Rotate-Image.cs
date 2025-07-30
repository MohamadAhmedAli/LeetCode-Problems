public class Solution {
    public void Rotate(int[][] matrix) {
    int startRow = 0;
    int endRow = matrix.Length-1;
    int startColumn = 0;
    int endColumn = matrix[0].Length - 1;
    int temp;

    for (int i = 0; i < matrix.Length; i++)
    {
        for (int j = i; j < matrix[i].Length; j++)
        {
            temp = matrix[i][j];
            matrix[i][j] = matrix[j][i];
            matrix[j][i] = temp;
        }
    }


    while (startColumn < endColumn)
    {
        for (int i = startRow; i <= endRow; i++)
        {
            temp = matrix[i][startColumn];
            matrix[i][startColumn] = matrix[i][endColumn];
            matrix[i][endColumn] = temp;
        }
        startColumn++;
        endColumn--;

    }

}
}