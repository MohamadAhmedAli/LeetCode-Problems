public class Solution {
    public int SubarraySum(int[] nums, int k) {
    Dictionary<int,int> dict = new Dictionary<int,int>();
    dict[0] = 1;
    int sum =0;
    int count = 0;
    for (int i = 0; i < nums.Length; i++)
    {

        sum += nums[i];
        if (dict.ContainsKey(sum - k))
            count += dict[sum - k];
        if (dict.ContainsKey(sum))
            dict[sum]++;
        else
            dict[sum] =1;
    }



    return count;
}
}