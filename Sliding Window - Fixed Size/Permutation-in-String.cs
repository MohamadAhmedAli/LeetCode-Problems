public class Solution {
    public bool CheckInclusion(string s1, string s2) {
   if(s1.Length > s2.Length) 
        return false;

   int[] arr = new int[26];
   int[] arr2 = new int[26];


    for(int i = 0; i<s1.Length;i++)
    {
        arr[s1[i] - 'a']++;
        arr2[s2[i] - 'a']++;
    }

    if(Enumerable.SequenceEqual(arr,arr2))
        return true;

    int start = 0;
    int end = s1.Length;

    while(end <  s2.Length)
    {
        arr2[s2[end] - 'a']++;
        arr2[s2[start] - 'a']--;

        if (Enumerable.SequenceEqual(arr, arr2))
            return true;

        start++;
        end++;
    }

    return false;
}
}