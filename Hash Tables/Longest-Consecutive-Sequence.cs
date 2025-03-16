public class Solution {
    public int LongestConsecutive(int[] nums)         {
    int res = 1,max=0;
    Dictionary<int,int> dict = new Dictionary<int,int>();
    foreach (int num in nums)
    {
        dict[num] = num;
    }
    foreach (var num in dict.Keys)
    {
        res = 1;
        if(!dict.ContainsKey(num-1))
        {
            while (dict.ContainsKey(num + res))
                res++;
                
            if (res >= max)
                    max = res;
        }

    }
    return max;
}
}