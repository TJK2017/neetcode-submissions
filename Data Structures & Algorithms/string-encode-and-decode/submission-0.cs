public class Solution {

    public string Encode(IList<string> strs) {
        var sb = new StringBuilder();
        foreach(var s in strs){
            sb.Append(s.Length);
            sb.Append('#');
            sb.Append(s);
        }
        return sb.ToString();
    }

    public List<string> Decode(string s) {
var result = new List<string>();
    int i = 0;

    while (i < s.Length)
    {
        // find the # to get the length prefix
        int j = i;
        while (s[j] != '#') j++;

        int length = int.Parse(s.Substring(i, j - i));

        // jump past # and read exactly 'length' chars
        result.Add(s.Substring(j + 1, length));
        i = j + 1 + length;
    }

    return result;
   }
}
