public class Solution {
    public IList<int> FindAnagrams(string s, string p) {
    IList<int> list = new List<int>();
    

    if (s.Length < p.Length)
        return list;
    
    int k = p.Length;
    int start = 0, end = k;
    int[] arr = new int[26];
    int[] arr2 = new int[26];

    for(int i = 0; i<k;i++)
    {
        arr[p[i] - 'a']++;
        arr2[s[i] - 'a']++;
    }

    if(Enumerable.SequenceEqual(arr,arr2))
        list.Add(start);

   while(end < s.Length)
    {
        arr2[s[end] - 'a']++;
        arr2[s[start] - 'a']--;

        if (Enumerable.SequenceEqual(arr, arr2))
            list.Add(start + 1);

        start++;
        end++;

    }

    return list;
}
}