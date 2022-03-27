public class Solution {
    public int NumSteps(string s) {
        StringBuilder sb = new StringBuilder(s);
        
        int steps = 0;
        
        while(sb.ToString() != "1"){
            int n = sb.Length;
            if(sb[n-1] == '1'){ //odd number
                for(int i = n-1; i>=0; i--){
                    if(sb[i] == '1'){
                        sb[i] = '0';
                    }else{
                        sb[i] = '1';
                        break;
                    }
                }
                if(sb[0] != '1'){
                    sb.Insert(0, '1');
                }
            }else{ //even no.
                sb.Remove(n-1, 1);
            }
            steps++;
        }
        
        return steps;
        
        
    }
}