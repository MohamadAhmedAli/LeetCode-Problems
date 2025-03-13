public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
    int index = 0,diff=0,num=0;
    Dictionary<int,int> dict = new Dictionary<int, int>();
    foreach (int i in nums)
    {
        if (dict.ContainsKey(i))
        {
            num = dict[i];
            diff = Math.Abs(index - num);
            if(diff <= k) 
                return true;
        }
                   dict[i]= index++;
    }
   
    return false ;
}
}