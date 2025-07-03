public class Solution {
    public bool CheckSubarraySum(int[] nums, int k) {
    Dictionary<int,int> dict = new Dictionary<int,int>();

    nums[0] %= k;
    dict[nums[0]] =0 ;
    for (int i = 1; i < nums.Length; i++)
    {
        nums[i] = (nums[i - 1] + nums[i] )% k;
        if (nums[i] == 0)
            return true;

        if (dict.ContainsKey(nums[i]))
        {
            if( i - dict[nums[i]] > 1)
                return true;
        }
        else
            dict[nums[i]] = i;
    }
     
        return false;
}
}