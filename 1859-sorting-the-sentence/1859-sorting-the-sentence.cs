public class compare: IComparer<string>{
    public int Compare(string a, string b){
        int aLength = a.Length;
        int bLength = b.Length;
        if(a[aLength-1] < b[bLength-1]){
            return -1;
        }
        return 1;
    }
}
public class Solution {
    
    public string SortSentence(string s) {
        string[] words = s.Split(' ');
        compare cmp = new compare();
        Array.Sort(words, cmp);
        
        StringBuilder ans = new StringBuilder("");
        
        for(int i = 0; i<words.Length; i++){
            for(int j = 0; j<words[i].Length-1; j++){
                ans.Append(words[i][j]);
            }
            if(i != words.Length-1){
                ans.Append(' ');
            }
        }
        
        return ans.ToString();
        
        /*
            n = words.Length
            m = Length of each word
            s = Length of entire string = n*m
            TC = O(nlogn) + O(n*m) = O(n*m) = O(n*m) = O(s)
            SC = O(2s) = O(s)
            
        */
    }
}