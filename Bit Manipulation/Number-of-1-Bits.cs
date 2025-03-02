public class Solution {
    public int HammingWeight(int n) { int res = 0;
    while (n > 0)
    {
        if (n % 2 != 0)
        {
            res++;
            n = (int)Math.Floor((decimal)(n / 2));
        } 
        else
        {
            n = (int)Math.Floor((decimal)(n / 2));
        }
    }
    return res;
}
}