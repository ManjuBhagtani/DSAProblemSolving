public class Solution {
    int start = 0;
    int end = 0;
    int n = 0;
    
    public void expand(int i, int j, string s){
        while(i >= 0 && j < n && s[i] == s[j]){
            if(end-start < j-i){
                start = i;
                end = j;
            }
            i--;
            j++;
        }
    }
    public string LongestPalindrome(string s) {
        n = s.Length;
        for(int i = 0; i<n; i++){
            expand(i, i, s);
            expand(i, i+1, s);
        }
        
        return s.Substring(start, end-start+1);
        
        /*
            TC = O(n^2)
            SC = O(1)
        */
    }
}