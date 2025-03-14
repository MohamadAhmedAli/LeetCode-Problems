public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs)  {
    string str2=\\,st;
    Dictionary<string,List<string>> dict = new Dictionary<string,List<string>>();
    foreach (string str in strs)
    {
        str2 = \\;
        st = string.Concat(str.OrderBy(x=>x));
        
        if (!dict.ContainsKey(st))
            dict.Add(st, new List<string>() { str });
        else
            dict[st].Add(str);
        

    }
    IList<IList<string>> res = [];
    foreach (var item in dict.Keys)
    {
        res.Add(dict[item]);
    }

    return res;
}

}