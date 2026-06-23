public class Solution {
    public bool IsAnagram(string s, string t) {

        if(s.Length != t.Length){
            return false;
        }

      var counts = new Dictionary<char, int>();

      foreach(char c in s){
            counts[c] = counts.GetValueOrDefault(c,0) + 1;
      }

      foreach(char c in t){
        if(!counts.ContainsKey(c))
            return false;

            counts[c]--;

        if(counts[c]==0){
           counts.Remove(c);
        } 
      }   

      return counts.Count == 0;
    }
}
