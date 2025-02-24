public class Solution {
    public bool IsSubsequence(string s, string t) {
    int res = 0,i = 0;
    
    if (s.Length == 0) 
        return true;
    if(s.Length > t.Length)
        return false;

    for (int j = 0; j < t.Length; j++)
    {
        if (s[i] == t[j])
        {
            i++; 
            res++;
        }
        if (i == s.Length)
            break;
    }
    return res == s.Length;
}
}