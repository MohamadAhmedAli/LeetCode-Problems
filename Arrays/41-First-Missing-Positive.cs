public class Solution {
    public int FirstMissingPositive(int[] nums) {
    int num,ind;
    for (int i = 0; i < nums.Length; i++)
    {
        if(nums[i] < 0)
            nums[i] = 0;
    }
    for (int i = 1; i <= nums.Length; i++)
    {
        num = Math.Abs(nums[i-1]);
        ind = num - 1;
        if (0<= ind && ind <= nums.Length-1)
        {
            if (nums[ind] > 0)
                nums[ind] *= -1;
            else if (nums[ind] == 0)
                nums[ind] = -1 * (nums.Length + 1);
        }
    }
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] >= 0)
            return i+1;
    }


        return nums.Length+1;
}
}