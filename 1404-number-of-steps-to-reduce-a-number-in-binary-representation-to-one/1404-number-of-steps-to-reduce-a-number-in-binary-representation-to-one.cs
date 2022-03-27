public class Solution {
    public int NumSteps(string s) {
              
        int steps = 0;
        
        int n = s.Length;
        
        int carry = 0;
        
        for(int i = n-1; i>=1; i--){
            int rightmostBit = s[i]-'0';
            
            if(rightmostBit+carry == 1){ //odd
                carry = 1;
                steps += 2;
            }else{
                steps++;
            }
        }
        
        return steps+carry;
        
        /*
            TC = O(n)
            SC = O(1)
        */
    }
}