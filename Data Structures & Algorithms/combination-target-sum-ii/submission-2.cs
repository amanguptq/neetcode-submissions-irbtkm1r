public class Solution {
    public List<List<int>> CombinationSum2(int[] candidates, int target) {
        Array.Sort(candidates);
        List<List<int>> res = new List<List<int>>();
        Sums(candidates, target, 0, res, new List<int>());
        return res;
        
    }

    private void Sums(int[] list, int target, int start, List<List<int>> res, List<int> cur)
    {
        if(target == 0)
        {
            res.Add(new List<int>(cur));
            return;
        }

        if(target<0) return ;

        for(int i = start; i<list.Length; i++)
        {
            if (i > start && list[i] == list[i - 1]) continue;

        // 🔥 Strong pruning
                 if (list[i] > target) break;
                cur.Add(list[i]);
                Sums(list, target-list[i], i+1, res, cur);
                cur.RemoveAt(cur.Count - 1);

        }
    }
}
