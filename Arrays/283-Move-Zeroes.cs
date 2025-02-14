public class Solution {
    public void MoveZeroes(int[] nums) {
    int num = 0, ind = 0;

    for (int i = 0; i < nums.Length; i++)
    {
        if(nums[i] !=0)
        {
            nums[ind++] = nums[i];
        }
        else
        {
            num++;
        }
    }
    for (int i = 0;i < num; i++)
    {
        nums[ind++] =0;
    }
}
}