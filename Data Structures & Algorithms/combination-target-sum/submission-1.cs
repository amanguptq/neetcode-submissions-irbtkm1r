public class Solution {
        public List<List<int>> CombinationSum(int[] nums, int target) {
                List<List<int>> res = new List<List<int>>();
                        permute(nums, res, target, new List<int>(), 0);
                                return res;
                                    }

                                        void permute(int[] nums, List<List<int>> r, int target, List<int> sums, int start) {
                                                int sum = 0;
                                                        foreach (int i in sums) {
                                                                    sum += i;
                                                                            }

                                                                                    if (sum == target) {
                                                                                                r.Add(new List<int>(sums)); // FIX 1
                                                                                                            return;
                                                                                                                    }

                                                                                                                            if (sum > target) {
                                                                                                                                        return;
                                                                                                                                                }

                                                                                                                                                        for (int i = start; i < nums.Length; i++) {
                                                                                                                                                                    sums.Add(nums[i]);
                                                                                                                                                                                permute(nums, r, target, sums, i); // allow reuse
                                                                                                                                                                                            sums.RemoveAt(sums.Count - 1); // FIX 2
                                                                                                                                                                                                    }
                                                                                                                                                                                                        }
                                                                                                                                                                                                        }
