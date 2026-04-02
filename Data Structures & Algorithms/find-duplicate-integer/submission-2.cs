public class Solution {
    public int FindDuplicate(int[] nums) {
        foreach(var n in nums)
        {
            var idx = Math.Abs(n) - 1;
            if(nums[idx]<0)
            {
                return n;
            }
            nums[idx]*=-1;
        }
        return -1;
        
    }
}
