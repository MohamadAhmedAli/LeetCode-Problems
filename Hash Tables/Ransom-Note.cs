public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
    Dictionary<char,int>  dict = new Dictionary<char,int>();

    foreach (var c in magazine)
    {
         if(! dict.ContainsKey(c))
                dict.Add(c, 1);
         else
            dict[c]++;

    }
    foreach (var c in ransomNote)
    {
        if (dict.ContainsKey(c) && dict[c]>0)
            dict[c]--;
        else
            return false;
    }


        return true;
}
}