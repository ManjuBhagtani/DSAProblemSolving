public class Solution {
    public int MaxDepth(string s) {
        Stack<char> stack = new Stack<char>();
        
        int maxStackSize = 0;
        int count = 0;
        
        foreach(char c in s){
            if(c == '('){
                stack.Push(c);
                count++;
                if(count > maxStackSize){
                    maxStackSize = count;
                }
            }else{
                if(c == ')'){
                    stack.Pop();
                    count--;
                }
            }
        }
        
        return maxStackSize;
    }
}