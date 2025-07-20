public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(string.IsNullOrEmpty(s)) return 0;
        if(string.IsNullOrWhiteSpace(s)) return 1;
    int left = 0;
    int max = 1;
    HashSet<char> chars = new HashSet<char>();
    chars.Add(s[0]);
    for (int i = 1; i< s.Length;i++)
    {
        while (chars.Contains(s[i]))
        {
            chars.Remove(s[left]);
            left++;
        }
            chars.Add(s[i]);

        if(chars.Count> max)
            max = chars.Count;
    }

    return max;
}
}