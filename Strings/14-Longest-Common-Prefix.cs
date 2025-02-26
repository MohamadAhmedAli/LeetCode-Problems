public class Solution {
    public string LongestCommonPrefix(string[] strs) {
    string  res = "";
    char ch;
    int min;
    int[] arr = new int[strs.Length];
    for(int i = 0;i < strs.Length;i++)
    {
        arr[i] = strs[i].Length;
    }

    Array.Sort(arr);
    min = arr[0];
    for (int i = 0; i < arr[0]; i++)
    {
        ch = strs[0][i];
        for (int j = 0; j < strs.Length; j++)
        {
            if (strs[j][i] != ch)
                return res;
        }
        res += ch;
    }

        return res;
}
}