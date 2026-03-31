public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
    int[][] pair = new int[position.Length][];

    for(int i=0; i<position.Length; i++)
    {
        pair[i] = new int[]{position[i], speed[i]};
    }
    Array.Sort(pair, (a,b)=>b[0].CompareTo(a[0]));
    Stack<double> ttr = new Stack<double>();

    foreach(var p in pair)
    {
        ttr.Push((double)(target-p[0])/(p[1]));

        if(ttr.Count>=2 && ttr.Peek()<= ttr.ElementAt(1))
        {
            ttr.Pop();
        }
    }

    return ttr.Count;
        
    }
}
