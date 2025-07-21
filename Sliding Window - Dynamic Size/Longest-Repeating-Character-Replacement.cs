public class Solution {
    public int CharacterReplacement(string s, int k) {
    Dictionary<char,int> dict = new Dictionary<char,int>();

    int left = 0;
    int max = 1;
    int count = 0;
    int comparewith = 0;
   
    dict.Add(s[0], 1);

    for(int right = 1; right < s.Length; right++)
  {
        if(dict.ContainsKey(s[right]))
            dict[s[right]]++;
        else
            dict[s[right]] = 1;

        count = dict.Values.Sum();
        comparewith = dict.Values.Max();
        while (count - comparewith > k)
        {
            if (dict[s[left]] > 1)
                dict[s[left]]--;
            else
                dict.Remove(s[left]);


            left++;
            count--;
        }
        if(count > max)
            max = count;

    }
    return max;
}
}