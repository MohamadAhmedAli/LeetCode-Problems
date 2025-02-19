public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
    int res = 1, res0=1;
    int[] result = new int[nums.Length];
    for (int i = 0; i < nums.Length; i++)
    {
        res *= nums[i];
    }

    for (int i = 0; i < nums.Length; i++)
    {
       
        if (nums[i] != 0)
            result[i] = res / nums[i];

        else
        {
            res0 = 1;
            for (int j = 0; j < nums.Length; j++)
            {
                if (i == j)
                    continue;
                else
                {
                    res0 *= nums[j];
                }
            }
            result[i] = res0;
        }
       
    }

    return result;
}
}