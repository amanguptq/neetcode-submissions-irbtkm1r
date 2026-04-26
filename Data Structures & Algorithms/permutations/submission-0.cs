public class Solution {
    public List<List<int>> Permute(int[] nums) {
        List<List<int>> res = new List<List<int>>();
        permute(nums,0, res);
        return res;
    }

    void permute(int[] nums, int startindex, List<List<int>> r)
    {
        if(startindex == nums.Length)
        {
            r.Add(nums.ToList());
            return;
        }
        HashSet<int> done= new HashSet<int>();

        for(int i=startindex;i<nums.Length; i++)
        {
            if(!(done.Contains(nums[i])))
            {
                done.Add(nums[i]);
                var temp = nums[i];
                nums[i] = nums[startindex];
                nums[startindex] = temp;
                permute(nums, startindex+1, r);
                var temp2 = nums[i];
                nums[i] = nums[startindex];
                nums[startindex] = temp2;
            }

        }
    }
}
