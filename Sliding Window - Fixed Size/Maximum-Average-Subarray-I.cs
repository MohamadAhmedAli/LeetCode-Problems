public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
    int sum = 0, Max_Sum = 0;

    for(int i = 0; i < k; i++)
    {
        sum += nums[i];
    }

    Max_Sum = sum;

    for(int i = 0;i < nums.Length -k; i++)
    {
        sum += nums[k + i] - nums[i];
            if (sum > Max_Sum)
            Max_Sum = sum;
    }

    return (double)Max_Sum / k;
}
}