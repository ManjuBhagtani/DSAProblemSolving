public class Solution {
    
    public string reverse(string s, int l, int r){
        StringBuilder rev = new StringBuilder("");
        for(int i = r; i>=l; i--){
            rev.Append(s[i]);
        }
        return rev.ToString();
    }
    public string ReverseWords(string s) {
        int n = s.Length;
        StringBuilder ans = new StringBuilder("");
        int left = 0;
        for(int i = 0; i<n; i++){
            if(s[i] == ' '){
                ans.Append(reverse(s, left, i-1));
                if(i != n-1){
                    ans.Append(" ");
                }
                left = i+1;
            }
        }
        ans.Append(reverse(s, left, n-1));
        
        return ans.ToString();
        
        /*
            TC = O(n)
            SC = O(n)
        */
    }
}