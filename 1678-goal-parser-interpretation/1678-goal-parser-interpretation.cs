public class Solution {
    public string Interpret(string command) {
        int n = command.Length;
        
        StringBuilder ans = new StringBuilder("");
        
        for(int i = 0; i<n; i++){
            if(command[i] == 'G'){
                ans.Append('G');
            }else{
                if(command[i+1] == ')'){
                    ans.Append('o');
                    i++;
                }else{
                    ans.Append("al");
                    i += 3;
                }
            }
        }
        
        return ans.ToString();
        
        /*
            TC = O(n);
            SC = O(n)
        */
    }
}