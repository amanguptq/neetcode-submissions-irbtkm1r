public class MedianFinder {
    List<int> pq;

    public MedianFinder() {
        pq = new List<int>();
        
    }
    
    public void AddNum(int num) {
        pq.Add(num);
        
    }
    
    public double FindMedian() {

        PriorityQueue<int, int> c = new PriorityQueue<int, int>();
        foreach(int i in pq)
        {
            c.Enqueue(i,i);
        }
        int t = pq.Count;
        Console.WriteLine(t);
        double res;
        
    if (t % 2 == 1) {
        for (int i = 0; i < t / 2; i++) {
            c.Dequeue();
        }
        return c.Peek();
    }
    else {
        for (int i = 0; i < t / 2 - 1; i++) {
            c.Dequeue();
        }
            res = (double)(c.Dequeue() + c.Dequeue())/2;
        }

    return res;
        
    }
}
