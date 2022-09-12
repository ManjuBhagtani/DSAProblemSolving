public class Solution {
    public void reverse(StringBuilder sb){
        int s = 0;
        int e = sb.Length-1;
        
        while(s < e){
            char c = sb[s];
            sb[s] = sb[e];
            sb[e] = c;
            s++;
            e--;
        }
    }
    
    public string ReverseParentheses(string s) {
        Stack<char> stack = new Stack<char>();
        
        int strLength = s.Length;
        
        StringBuilder temp = new StringBuilder();
        
        for(int i = 0; i<strLength; i++){
            if(s[i] != ')'){
                stack.Push(s[i]);
            }else{
                while(stack.Peek() != '('){
                    temp.Append(stack.Pop());
                }
                stack.Pop();
                int tempLength = temp.Length;
                for(int j = 0; j<tempLength; j++){
                    stack.Push(temp[j]);
                }
                temp = new StringBuilder("");
            }
        }
        
        while(stack.Count > 0){
            temp.Append(stack.Pop());
        }
        
        reverse(temp);
        return temp.ToString();
    }
}
