public class Solution {
    public int[] CountBits(int n) {
    int pow = 1;
    int num = 0;
    int[] res = new int[n + 1];
    if (n == 0)
        return [0];
   else if (n == 1)
        return [0, 1];
    else
    {
        res[0] = 0;
        res[1] = 1;
        for (int i = 2; i <= n; i++)
        {
            if(i == Math.Pow(2, pow + 1))
            {
                pow++;
                num = 0;
            }
            if (i >= Math.Pow(2, pow) && i < Math.Pow(2, pow + 1))
            {
                res[i] = res[num++]+1;
            }
            
        }
    }
    
    return res;
}
}