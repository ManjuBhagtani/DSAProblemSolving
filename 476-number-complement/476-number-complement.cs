public class Solution {
    public int FindComplement(int num) {
        int ans = 0;
        int i = 0;
        
        while(num > 0){
            if((num&1) == 0){
                ans |= (1<<i);
            }
            num = num>>1;
            i++;
        }
        
        return ans;
        
        /*
            TC = O(log n)
            SC = O(1)
        */
    }
}
