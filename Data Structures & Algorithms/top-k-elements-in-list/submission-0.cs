public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {

        var o=new Dictionary<int, int>();
        var res= new List<int>();

        foreach(var i in nums)
        {
            if(o.ContainsKey(i))
                o[i]++; 
            else
             o[i] = 1;
        }
        // res  = o.OrderByDescending(x => x.Value)
        //              .Take(k)
        //              .Select(x => x.Key).ToList<int>();
        
        // // foreach(var val in  o.OrderByDescending(x => x.Value)
        // //              .Take(k)
        // //              .Select(x => x.Key))
        // // {
        // //     res.Add(val);
        // // }

        return o.OrderByDescending(x => x.Value)
                     .Take(k)
                     .Select(x => x.Key).ToArray<int>();

    }
}
