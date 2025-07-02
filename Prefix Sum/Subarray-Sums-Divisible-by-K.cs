public class Solution {
    public int SubarraysDivByK(int[] nums, int k) {
    int count = 0;
    Dictionary<int,int> dict = new Dictionary<int,int>();

    for (int i = 1; i < nums.Length; i++)
    {
        nums[i] += nums[i - 1];
    }

    for (int i = 0; i< nums.Length;i++)
    {
        while (nums[i]<0)
            nums[i] += 1000*k;
        if (dict.ContainsKey(nums[i] % k))
            dict[nums[i] % k]++;
        else
            dict[nums[i] % k] = 1;

    }
    foreach (var item in dict.Values)
        count += item * (item - 1) / 2;

    if(dict.ContainsKey(0))
        count += dict[0];
   
    return count;
}
}