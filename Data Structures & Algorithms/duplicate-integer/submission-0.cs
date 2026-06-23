public class Solution {
    public bool hasDuplicate(int[] nums) {
        var seen = new HashSet<int>();

        foreach(var item in nums){
            if(!seen.Add(item)){
                return true;
            }
        }

        return false;
    }
}