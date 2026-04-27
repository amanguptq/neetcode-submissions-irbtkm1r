public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {
        List<List<int>> res = new List<List<int>>();
        backtrack(nums, target, 0, new List<int>(), res);
        return res;
    }

    void backtrack(int[] nums, int target, int start, List<int> path, List<List<int>> res) {
        if (target == 0) {
            res.Add(new List<int>(path));
            return;
        }

        if (target < 0) return;

        for (int i = start; i < nums.Length; i++) {
            path.Add(nums[i]);
            backtrack(nums, target - nums[i], i, path, res);
            path.RemoveAt(path.Count - 1);
        }
    }
}