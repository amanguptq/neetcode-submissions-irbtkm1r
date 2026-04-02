public class Solution {

    public string Encode(IList<string> strs) {
        string res="";
        var size=strs.Count;
        res=string.Join(" ",strs);
        var prefix= size.ToString()+'#';
        res= prefix+res;
        Console.WriteLine(res);
        return res;   
    }

    public List<string> Decode(string s) {
        int size=s[0];
        string[] res=new string[size];
        if(size>0){
        s=s.Remove(0,2);
       // List<string> res=new List<string>();
        res=s.Split(" ");}
return res.ToList<string>();
   }
}


