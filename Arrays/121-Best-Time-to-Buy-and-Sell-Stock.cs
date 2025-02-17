public class Solution {
    public int MaxProfit(int[] prices) {
    int min = 10000;
    int max = 0, diff = 0;
    for(int i = 0; i < prices.Length; i++)
    {
        if (prices[i] < min)
        {
            min = prices[i];
        }
        
        diff = prices[i]-min;
       if(diff > max)
            max = diff;
    }
    return max;
}
}