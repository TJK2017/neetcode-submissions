public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var groups = new Dictionary<string, List<String>>();

        foreach(var s in strs){
            var key = string.Concat(s.OrderBy(c => c));

            if(!groups.TryGetValue(key, out var group))
            {
                group = new List<string>();
                groups[key] = group;
            }

            group.Add(s);
        }

        return groups.Values.ToList();
    }
}
