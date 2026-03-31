public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int[] res = new int[temperatures.Length];
        Stack<int[]> st = new Stack<int[]>();

        for(int i=0; i<temperatures.Length; i++)
        {
            int t = temperatures[i];
            while(st.Count>0 && st.Peek()[0]<t)
            {
                int[] outElement = st.Pop();
                int days = i - outElement[1];
                res[outElement[1]] = days;
            }
            st.Push(new int[]{t,i});
        }
        return res;
        
    }
}
