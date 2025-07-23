public class Solution {
    public int LongestOnes(int[] nums, int k) {
    int left = 0;
    int num = 0;
    int max = 0;

    for(int right = 0; right < nums.Length; right++)
    {
        if (nums[right] == 1)
            num++;

        while(right -left + 1 -num > k)
        {
            if (nums[left] == 1)
                num--;
                                               
            left++;
            
        }

        max = Math.Max(max, right - left + 1);
            
    }



    return max;
}
}