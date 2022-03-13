public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
        foreach(char c in s){
            if(c == '(' || c == '[' || c == '{'){
                stack.Push(c);
            }else{
                if(stack.Count > 0){
                    char top = stack.Pop();
                    if(c == ')'){
                        if(top != '('){
                            return false;
                        }
                    }else if(c == ']'){
                        if(top != '['){
                            return false;
                        }
                    }else{
                        if(top != '{'){
                            return false;
                        }
                    }
                }else{
                    return false;
                }
            }
        }
        if(stack.Count > 0){
            return false;
        }
        return true;
    }
}