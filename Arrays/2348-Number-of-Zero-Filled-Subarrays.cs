public class Solution {
    public long ZeroFilledSubarray(int[] nums) {
    long res = 0, num = 1;
    for (int i = 0;i< nums.Length-1;i++)
    {
        if (nums[i] == 0)
            res += num;
        if (nums[i] == 0 && nums[i+1 ] == 0)
            num++;
        else
            num = 1;
        

    }
    if (nums[nums.Length-1] == 0)
        return res+num;
    else
        return res;
}
}