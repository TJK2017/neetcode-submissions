public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var count = new Dictionary<int, int>();

        foreach(var num in nums){
           count[num] = count.GetValueOrDefault(num) + 1;
        }

        var buckets = new List<int>[nums.Length + 1];
        foreach(var (num, freq) in count){
            buckets[freq] ??= new List<int>();
            buckets[freq].Add(num);
        }

        var result = new List<int>();
        for (int i = buckets.Length - 1; i >= 0 && result.Count < k; i--){

            if(buckets[i] != null){
                result.AddRange(buckets[i]);
            }
        }

        return result.ToArray();
    }
}
