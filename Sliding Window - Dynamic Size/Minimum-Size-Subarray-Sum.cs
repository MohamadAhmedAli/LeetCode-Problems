public class Solution {
    public int MinSubArrayLen(int target, int[] nums){
    int left = 0;
    int sum = 0;
    int min = int.MaxValue;

    for (int right = 0; right < nums.Length; right++)
    {
        sum += nums[right];

        while(sum >= target)
        {
            min = Math.Min(min, right - left +1);
            sum -= nums[left];
            left++;
        }
    }
    if (min == int.MaxValue) return 0;
    return min;
}
}