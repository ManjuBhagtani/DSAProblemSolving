public class Solution {
    public int MinAddToMakeValid(string s) {
        int n = s.Length;
        
        Stack<char> stack = new Stack<char>();
        
        int moves = 0;
        
        for(int i = 0; i<n; i++){
            if(s[i] == '('){
                stack.Push('(');
            }else{
                if(stack.Count > 0){
                    stack.Pop();
                }else{
                    moves++;
                }
            }
        }
        moves += stack.Count;
        
        return moves;
    }
}

/*
    TC = O(n)
    SC = O(n)
*/