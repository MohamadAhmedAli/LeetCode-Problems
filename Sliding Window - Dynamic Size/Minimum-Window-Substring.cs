public class Solution {
    public string MinWindow(string s, string t)  {
    if (t.Length > s.Length)
        return "";
    int left = 0;
    int right = 0;
    int min = int.MaxValue;
   
    int result_start = 0;

    Dictionary<char, int> dict1 = new Dictionary<char, int>();
    Dictionary<char, int> dict2 = new Dictionary<char, int>();

    foreach(var c in t)
    {
        if (!dict2.ContainsKey(c))
            dict2[c] = 0;
        dict2[c]++;
    }

    int t_length = dict2.Count;
    while (right < s.Length)
    {
        if (!dict1.ContainsKey(s[right]))
            dict1[s[right]] = 0;
        dict1[s[right]]++;

        if (dict2.ContainsKey(s[right]) && dict2[s[right]] == dict1[s[right]])
            t_length--;

        while(t_length == 0)
        {
            if (right - left + 1 < min)
            {
                min = right - left + 1;
                result_start = left;
            }
                

                dict1[s[left]]--;
            

            if (dict2.ContainsKey(s[left]) && dict2[s[left]] > dict1[s[left]])
                t_length++;
            left++;
        }
        right++;
    }
    if (min == int.MaxValue) return "";
    return s.Substring(result_start,min) ;
}
}