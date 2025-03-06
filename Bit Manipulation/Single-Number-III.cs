public class Solution {
    public int[] SingleNumber(int[] nums) {
    int res = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        res ^= nums[i];
    }
    int num = 1;
    while ((res & num) == 0)
        num = num << 1;

    int x = 0, y = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if((num & nums[i]) !=0)
            x ^= nums[i];
        else
            y ^= nums[i];
    }

        return [x,y];
}
}