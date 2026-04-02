public class Solution {
    public int Search(int[] nums, int target) {
        int l=0, r=nums.Length-1;
        int res=-1;

        while(l<=r)
        {
            int mid=l + (r - l) / 2;
            int n=nums[mid];

            if(n==target)
            {
                res=mid;
            }
            else if(target>n)
            {
               l=mid+1; 
            }
            else{
                r=mid-1;
            }
    
        
    }
    return res;
}
}
