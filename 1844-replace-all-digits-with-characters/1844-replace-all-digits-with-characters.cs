public class Solution {
    public char shift(char c, char num){
        char ans = (char)(c + (num-'0'));
        if(ans > 'z'){
            ans = 'z';
        }
        return ans;
    }
    public string ReplaceDigits(string s) {
        int n = s.Length;
        
        StringBuilder ans = new StringBuilder("");
        
        for(int i = 0; i<n; i++){
            ans.Append(s[i]); i++;
            if(i < n)
                ans.Append(shift(s[i-1], s[i]));
        }
                       
        return ans.ToString();
        
        /*
            TC  = O(n)
            SC  = O(n)
        */
    }
}