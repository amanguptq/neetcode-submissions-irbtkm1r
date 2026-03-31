public class TimeMap {
    Dictionary<string, List<Tuple<string, int>>> m;

    public TimeMap() {
        m = new Dictionary<string, List<Tuple<string, int>>>();
    }
    
    public void Set(string key, string value, int timestamp) {
        
        if(!(m.ContainsKey(key)))
        {
            m[key] = new List<Tuple<string, int>>();
        }
        m[key].Add(Tuple.Create(value, timestamp));
    }
    
    public string Get(string key, int timestamp) {
        if(!(m.ContainsKey(key)))
        {
            return "";
        }

        string result = "";
        var values = m[key];
        int l = 0, r = values.Count-1;
        while(l<=r)
        {
            int m = l + (r-l) / 2;
            if(timestamp>=values[m].Item2)
            {
                result = values[m].Item1;
                l  = m + 1;
            }
            else{
                r = m -1;
            }
        }

        return result;
        
    }
}
