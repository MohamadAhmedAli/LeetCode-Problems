public class Solution {
    public int MaxNumberOfBalloons(string text)  {
     Dictionary<char,int> dict = new Dictionary<char,int>();
     int min =0;
     foreach (char c in text)
     {
         if(dict.ContainsKey(c))
             dict[c] +=1;
         else
             dict[c] =1;
     }
     if(dict.ContainsKey('b')&& dict.ContainsKey('a') && dict.ContainsKey('l') && dict.ContainsKey('o') && dict.ContainsKey('n') )
     {
        min = Math.Min(dict['b'], dict['a']);
        min = Math.Min(min, dict['l']/2);
        min = Math.Min(min, dict['o']/2);
        min = Math.Min(min, dict['n']);

     }
    
    
     return min;
 }
}