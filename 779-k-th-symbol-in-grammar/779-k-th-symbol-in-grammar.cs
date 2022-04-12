public class Solution {
    
    public int kthGrammar(int n, int k){
        if(n == 1){
            return 0;
        }
        int prev = kthGrammar(n-1, k/2);    
        if(prev == 0){
            if(k%2 == 0){
                return 0;
            }
            return 1;
        }else{
            if(k%2 == 0){
                return 1;
            }
            return 0;
        }
    }
    
    public int KthGrammar(int n, int k) {
        return kthGrammar(n, k-1);
    }
    
    /*
        TC = O(n) 
        SC = O(n) - recursion stack
    */
}