public class Solution {
    public int RemoveDuplicates(int[] nums) {
    int num = 1,ind=1;
    int[] res = new int[nums.Length];
    res[0]=nums[0];
    for(int i = 0; i < nums.Length-1; i++)
    {
        if( nums[i] == nums[i+1])
        {
            continue;
        }
        else
        {
            res[ind++]= nums[i+1];
            num++;
        }
    }
    for(int i = num ; i< nums.Length;i++)
    {
        res[i] = 0;
    }
    Array.Copy(res,nums,res.Length);
    return num;
}
}