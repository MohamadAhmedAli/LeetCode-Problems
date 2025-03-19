public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
    int front = 0, back = numbers.Length-1;
    for (int i = 0;i<numbers.Length;i++)
    {
        if ((numbers[front] + numbers[back]) == target)
            return [front + 1, back + 1];

        else if ((numbers[front] + numbers[back]) > target)
            back--;
        else
            front++;
    }
    return [0,0];
}
}