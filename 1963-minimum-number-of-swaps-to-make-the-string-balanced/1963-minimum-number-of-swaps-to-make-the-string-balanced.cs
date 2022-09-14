public class Solution {
    public int MinSwaps(string s) {
        //https://www.youtube.com/watch?v=3YDBT9ZrfaU
        int n = s.Length;
        int extraClose = 0;
        int maxExtraClose = 0;
        
        for(int i = 0; i<n; i++){
            if(s[i] == ']'){
                extraClose++;
            }else{
                extraClose--;
            }
            maxExtraClose = Math.Max(maxExtraClose, extraClose);
        }
        
        return (maxExtraClose+1)/2;
    }
}

/*
    TC = O(n)
    SC = O(1)
*/