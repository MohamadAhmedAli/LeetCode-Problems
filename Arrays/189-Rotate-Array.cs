public class Solution {
    public void Rotate(int[] nums, int k) {
    int ind = k;
    int[] copy = new int[nums.Length];
    Array.Copy(nums,copy,nums.Length);
    for (int i = 0; i < nums.Length; i++)
    {
        ind = k + i; 
        while(ind>= nums.Length)
           ind-= nums.Length;
        nums[ind] = copy[i];
    }
}
}