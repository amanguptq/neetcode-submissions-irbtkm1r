public class Solution {
    public bool hasDuplicate(int[] nums) {
        List<int> count= new List<int>();

        foreach(var i in nums){
            if(count.Contains(i))
            {
                return true;
            }
            else
            {
                count.Add(i);
            }
        }
        return false;
    }
}