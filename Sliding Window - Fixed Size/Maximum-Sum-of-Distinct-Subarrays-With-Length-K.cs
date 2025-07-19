public class Solution {
    public long MaximumSubarraySum(int[] nums, int k) {
    Dictionary<int,int> dict = new Dictionary<int,int>();

    long sum = 0;
    long max = 0;
    for(int i = 0; i < k; i++)
    {
        sum += nums[i];           
        if(!dict.ContainsKey(nums[i]))
            dict[nums[i]] = 1;
        else
            dict[nums[i]]++ ;
    }
    if(dict.Count == k)
        max = sum;

    int start = 0;
    int end = k;

     while (end < nums.Length)
    {
        sum -= nums[start] ;
        if (dict.ContainsKey(nums[start]) && dict[nums[start]] > 1)
            dict[nums[start]]--;
        else if(dict.ContainsKey(nums[start]) &&  dict[nums[start]] ==1)
            dict.Remove(nums[start]);
       
        sum += nums[end];
        if(!dict.ContainsKey(nums[end]))
            dict.Add(nums[end], 1);
        else
            dict[nums[end]]++ ;

        start++;
        end++;
        if(dict.Count == k)
        {
            if(sum>max) 
                max = sum;
        }


    }
    
    return max;
}
    
}