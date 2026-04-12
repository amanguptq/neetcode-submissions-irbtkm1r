public class Solution {
    public int FindKthLargest(int[] nums, int k) {
      PriorityQueue<int, int> order=new PriorityQueue<int, int>();
      foreach(int i in nums){
      order.Enqueue(i,i);
      if(order.Count>k)
      order.Dequeue();
    }

    return order.Peek();
    }
}

