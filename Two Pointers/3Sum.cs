public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums)  {
    int num;
    int front = 0, back = nums.Length - 1;
    IList<IList<int>> list = [];
    Array.Sort(nums);
    for (int i = 0; i < nums.Length; i++)
    {
        if (i != 0 && nums[i] == nums[i - 1])
            continue;
        num = nums[i] * -1;
        front = i+1; back = nums.Length - 1;
        while(back > front)
        {
            if (num == (nums[front] + nums[back]))
            {
                list.Add([nums[i], nums[front], nums[back]]);
                front++;
                back--;
                while (back > front  && nums[front] == nums[front - 1])
                    front++;
                while (back > front && nums[back] == nums[back + 1])
                    back--;

            }

            else if (num > (nums[front] + nums[back]))
                front++;
            else
                back--;
        }

    }
    return list;
}
}