public class Solution {
    public int MaxScoreSightseeingPair(int[] values) {
    int max = values[0];
    int sum = values[0];
    int maxSum = values[0];

    for (int i = 1; i < values.Length; i++)
    {
        max--;
        sum = values[i] + max;
        if (sum > maxSum)
            maxSum = sum;

        if (values[i] > max)
            max = values[i];
    }

    return maxSum;
}
}