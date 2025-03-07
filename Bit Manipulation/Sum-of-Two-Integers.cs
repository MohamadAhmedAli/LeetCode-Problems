public class Solution {
    public int GetSum(int a, int b) {
        int sum,carry;
        while(b != 0)
        {
            sum = a^b;
            carry = a&b;
            a = sum;
            b = carry<<1;
        }
        return a;
    }
}