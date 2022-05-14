public class Solution {
    public int BalancedStringSplit(string s) {
        int n = s.Length;
        
        int balStrings = 0;
        
        int L = 0;
        int R = 0;
        
        for(int i = 0; i<n; i++){
            if(s[i] == 'L'){
                L++;
            }else{
                R++;
            }    
            if(L == R){
                balStrings++;
                L = 0;
                R = 0;
            }
        }
        
        return balStrings;
        
        /*
            TC = O(N)
            SC = O(N)
        */
    }
}