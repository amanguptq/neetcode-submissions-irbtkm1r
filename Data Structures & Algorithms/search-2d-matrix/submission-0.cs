public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        

        int l1 =0, l2 = 0, r1 = matrix.GetLength(0) -1, r2=matrix[0].Length-1;
        int length = r2=matrix[0].Length-1;
        int m = 0;
        while(l1<=r1)
        {
            m = l1 + (r1-l1) /2;
            if(matrix[m][0]  > target)
            {
                r1 = m-1;
            }
            else if(matrix[m][r2] < target)
            {
                l1 = m+1;
            }
            else
            {
                break;
            }
        }

        if(!(l1<=r1))
        {
            return false;
        }

        while(l2<=r2)
        {
            int mid = l2 + (r2-l2) /2;
            if(matrix[m][mid]>target)
            {
                r2 = mid -1;
            }
            else if (matrix[m][mid]<target)
            {
                l2 = mid+1;
            }
            else
            {
                return true;
            }
        }
        return false;
    }
}
