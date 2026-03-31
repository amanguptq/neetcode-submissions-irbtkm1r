public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        var num=new List<int>(nums);
        var res=new List<int>();

        for(int i=0;i<nums.Length;i++)
        { 
            var j=target-num[i];
            if(num.Contains(j) && num.IndexOf(j) != i)
            {
             res.Add(Math.Min(i, num.IndexOf(j)));
             res.Add(Math.Max(i, num.IndexOf(j)));
             break;
            }

        }

        return res.ToArray<int>();

    }
}