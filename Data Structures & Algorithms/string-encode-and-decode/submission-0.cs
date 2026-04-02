public class Solution {

    public string Encode(IList<string> strs) {
        string res="";
        var size=strs.Count;
        res=string.Join(" ",strs);
        //var prefix= size.ToString()+'#';
        //res= prefix+res;
        Console.WriteLine(res);
        return res;   
    }

    public List<string> Decode(string s) {
       // List<string> res=new List<string>();
       string[] res=s.Split(" ");
       foreach(var c in res){
        Console.WriteLine(c);}
return res.ToList<string>();
   }
}


