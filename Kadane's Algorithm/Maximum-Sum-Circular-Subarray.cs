public class Solution {
    public int MaxSubarraySumCircular(int[] nums)    {
    int sum_max = 0;
    int max = -1*int.MaxValue;
    int min = int.MaxValue;
    int sum_min = 0;
    int sum_all =0;

    for (int i = 0; i < nums.Length; i++)
    {

            sum_max = Math.Max(sum_max + nums[i], nums[i]);
            max = Math.Max(max, sum_max);

            sum_min = Math.Min(sum_min + nums[i], nums[i]);
            min = Math.Min(min, sum_min);
        
       sum_all +=nums[i];
    }
     if(max >0)
       max = Math.Max(max,sum_all-min);

    return max;
}
}