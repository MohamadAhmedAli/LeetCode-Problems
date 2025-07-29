public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
    IList<int> result = new List<int>();

    int firstRow = 0;
    int lastRow = matrix.GetLength(0)-1;
    int firstColumn = 0;
    int lastColumn = matrix[0].Length-1;
    int total = (lastRow+1)*(lastColumn+1);

    while(result.Count() < total)
    {
        for (int i = firstColumn; i <= lastColumn; i++)
        {
            result.Add(matrix[firstRow][i]);
        }
        firstRow++;
        for (int i = firstRow; i <= lastRow; i++)
        {
            result.Add(matrix[i][lastColumn]);
        }
        lastColumn--;
        if (result.Count() == total)
            break;
        for (int i = lastColumn; i >= firstColumn; i--)
        {
            result.Add(matrix[lastRow][i]);
        }
        lastRow--;
        for (int i = lastRow; i >=firstRow ; i--)
        {
            result.Add(matrix[i][firstColumn]);
        }
        firstColumn++;
    }


    return result;
}
}