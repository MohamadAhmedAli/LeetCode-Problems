public class Solution {
    public int NumSplits(string s) {
    Dictionary<char,int> dict = new Dictionary<char,int>();
    Dictionary<char,int> dict2 = new Dictionary<char,int>();
    int s1=1, s2=1;
    int res = 0;
    foreach (var ch in s)
    {
        if (dict.ContainsKey(ch))
            dict[ch]++;
        else 
            dict[ch] = 1;
    }
    foreach (var ch in s)
    {
        if (dict2.ContainsKey(ch))
            dict2[ch]++;
        else
            dict2[ch] = 1;

        dict[ch]--;
        if (dict[ch]== 0)
            dict.Remove(ch);

        if (dict.Count() == dict2.Count())
            res++;
    }

    return res;
}
}