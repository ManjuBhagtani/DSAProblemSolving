public class Solution {
    public int MaxDepth(string s) {
        Stack<char> stack = new Stack<char>();
        
        int maxStackSize = 0;
        
        foreach(char c in s){
            if(c == '('){
                stack.Push(c);
                if(stack.Count > maxStackSize){
                    maxStackSize = stack.Count;
                }
            }else{
                if(c == ')'){
                    stack.Pop();
                }
            }
        }
        
        return maxStackSize;
    }
}