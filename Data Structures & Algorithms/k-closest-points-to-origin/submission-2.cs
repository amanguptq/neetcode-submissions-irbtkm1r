public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        var pq = new PriorityQueue<int[], int>();

    foreach (var p in points) {
        int dist = p[0] * p[0] + p[1] * p[1];

        pq.Enqueue(p, -dist);

        if (pq.Count > k) {
            pq.Dequeue();
        }
    }

    int[][] res = new int[k][];
    for (int i = 0; i < k; i++) {
        res[i] = pq.Dequeue();
    }

    return res;
        
        
    }
}
