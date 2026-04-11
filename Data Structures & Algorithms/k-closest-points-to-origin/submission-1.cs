public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        PriorityQueue<int[], double> dis = new PriorityQueue<int[], double>();

        foreach(var i in points)
        {
            var c = Math.Sqrt((Math.Abs(Math.Pow(i[0], 2)) + (Math.Abs(Math.Pow(i[1], 2)))));
            //Console.WriteLine(-c);
            dis.Enqueue(i,-c);
            if(dis.Count>k)
            {
                dis.Dequeue();
            }
        }
        int[][] res = new int[k][];
        for(int i=0;i<k;i++)
        {
            res[i] = dis.Dequeue();
        } 
        return res;
        
        
    }
}
