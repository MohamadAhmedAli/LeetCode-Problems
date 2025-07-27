public class Solution {
    public int MaxProduct(int[] nums) 
{
    if(nums.Count() == 1) 
        return nums[0];

    int sumMaxR2L = 1;
    int sumMaxL2R = 1;
    int maxR = int.MinValue;
    int maxL = int.MinValue;
    int max = int.MinValue;
    int totalproduct = 1;

    for(int i = 0; i< nums.Length;i++)
    {
        if (nums[i] == 0)
            sumMaxR2L = 0;
        else
        {
            if (sumMaxR2L == 0) sumMaxR2L = 1;
            sumMaxR2L *= nums[i];
        }


        if (nums[nums.Length - 1 - i] == 0)
            sumMaxL2R = 0;
        else
        {
            if (sumMaxL2R == 0) sumMaxL2R = 1;
            sumMaxL2R *= nums[nums.Length - 1 - i];
        }

        maxR = Math.Max(maxR, sumMaxR2L);
        maxL = Math.Max(maxL, sumMaxL2R);
        totalproduct *= nums[i];
    }
   

    max = Math.Max(maxR, maxL);
    if(totalproduct > 0)
        return totalproduct;
    

    return max;
}
}