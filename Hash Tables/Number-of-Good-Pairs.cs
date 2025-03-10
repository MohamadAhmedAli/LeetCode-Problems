public class Solution {
    public int NumIdenticalPairs(int[] nums) {
    int count = 0,res =0;
    Dictionary<int,int> dict = new Dictionary<int,int>();
    foreach (int num in nums)
    {
        if (dict.ContainsKey(num))
            dict[num]++;
        else
            dict[num] = 1;
    }
    foreach (var item in dict)
    {
        count = dict[item.Key];
        res += count * (count - 1) / 2;
    }

    return res;
}
}