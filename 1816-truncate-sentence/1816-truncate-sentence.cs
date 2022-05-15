public class Solution {
    public string TruncateSentence(string s, int k) {
        int n = s.Length;
        StringBuilder ans = new StringBuilder("");
        int spaceCount = 0;
        for(int i = 0; i<n; i++){
            if(s[i] == ' '){
                spaceCount++;
                if(spaceCount == k){
                    break;
                }
            }
            ans.Append(s[i]);
            
        }
        
        return ans.ToString();
        
        /*
            TC = O(n)
            SC = O(n)
        */
    }
}