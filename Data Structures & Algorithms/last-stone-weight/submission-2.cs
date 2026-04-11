public class Solution {
    public int LastStoneWeight(int[] stones) {
        PriorityQueue<int, int> st = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
        foreach(int i in stones){
            st.Enqueue(i,i);
        }
    
        while(st.Count>1)
        {
            var x = st.Dequeue();
            var y = st.Dequeue();

            if(x>y)
            {
                st.Enqueue(x-y,x-y);
            }
        }

        int res = st.Count>0? st.Peek(): 0;
        return res;
    }
}
