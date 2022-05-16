public class Solution {
    public string reverse(string s, int l, int r){
        StringBuilder sb = new StringBuilder("");
        
        for(int i = r; i>=l; i--){
            sb.Append(s[i]);
        }
        
        return sb.ToString();
    }
    public string ReversePrefix(string word, char ch) {
        int n = word.Length;
        
        int i = 0;
        while(i < n && word[i] != ch){
            i++;
        }
        if(i<n && word[i] == ch){
            return reverse(word, 0, i) + word.Substring(i+1);
        }
        
        return word;
        
        /*
            TC = O(n)
            SC = O(n)
        */
    }
}