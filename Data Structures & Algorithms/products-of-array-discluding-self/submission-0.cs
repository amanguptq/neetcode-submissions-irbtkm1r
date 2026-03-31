public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int product=1;
        int zeroCount = 0;
        foreach(var i in nums)
        {
            if(i!=0){
            product*=i;
              } else {
                zeroCount++;
            }
        }

        if (zeroCount > 1) {
            return new int[nums.Length];
        }

         int[] res = new int[nums.Length];
        for(int i=0; i<res.Length; i++){
       if (zeroCount > 0) {
                res[i] = (nums[i] == 0) ? product : 0;
            } else {
                res[i] = product / nums[i];
            }
        }

        return res;


        
    }
}
