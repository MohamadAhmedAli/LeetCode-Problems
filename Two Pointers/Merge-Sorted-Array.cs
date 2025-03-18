public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n)   {
    int[] res = new int[nums1.Length];
    if (m == 0)
    {
        Array.Copy(nums2, nums1, nums2.Length);
        return;
    }
    for (int i = nums1.Length-1; i >=0 ; i--)
    {
        if(n ==0 && m !=0)
        {
            res[i] = nums1[m-1];
            m--;
        }
        else if (n != 0 && m == 0)
        {
            res[i] = nums2[n-1];
            n--;
        }
        else
        {
            if (nums1[m - 1] < nums2[n - 1])
            {
                res[i] = nums2[n - 1];
                n--;
            }
            else
            {
                res[i] = nums1[m - 1];
                nums1[m - 1] = 0;
                m--;

            }
        }
        
    }
    Array.Copy(res, nums1, res.Length);

}
}
