public class Solution {
    public int FindMaxLength(int[] nums) {
    Dictionary<int, int> dict = new Dictionary<int, int>();
    dict[0] = -1;

    int count = 0, result = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] == 1)
            count++;
        else
            count--;

        if (dict.ContainsKey(count))
            result = Math.Max(result, i - dict[count]);
        else
            dict[count] = i;
        
    }
    return result;
}
}