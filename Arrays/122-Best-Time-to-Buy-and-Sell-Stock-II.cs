public class Solution {
    public int MaxProfit(int[] prices)  {
     int res = 0, diff = 0;
     for (int i = 0; i < prices.Length-1; i++)
     {
         diff = prices[i + 1] - prices[i];
         if (diff > 0)
             res += diff;
     }
     return res;
 }
}