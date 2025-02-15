public class Solution {
    public int MajorityElement(int[] nums) {
    Array.Sort(nums);
    int num = 1 ;
    for(int i = 0; i < nums.Length; i++)
    {
        if ((i != nums.Length - 1) && nums[i] == nums[i+1] )
        {
            num++;
        }
        else 
        {
            if (num > (nums.Length / 2))
            {
                return nums[i];
            }
            else
                num = 1;
        }
        
    }
    
        return nums[0];
}
}