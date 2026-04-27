public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        List<List<int>> res = new List<List<int>>();
        backtrack(nums,0, new List<int>(), res);
        return res;
    }

    void backtrack(int[] nums, int start, List<int> path, List<List<int>> res) {
            res.Add(new List<int>(path)); 


        for (int i = start; i < nums.Length; i++) {
            path.Add(nums[i]);
            backtrack(nums,  i+1, path, res);
            path.RemoveAt(path.Count - 1);
        }
    }
}
