public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int n = temperatures.Length;
        
        int[] answer = new int[n];
        
        Stack<int> stack = new Stack<int>();
        
        //find the nearest greater element on right
        for(int i = n-1; i >= 0; i--){
            while(stack.Count > 0 && temperatures[stack.Peek()] <= temperatures[i]){
                stack.Pop();
            }
            if(stack.Count > 0){
                answer[i] = stack.Peek()-i;
            }else{
                answer[i] = 0;
            }
            stack.Push(i);
        }
        
        return answer;
    }
}

/*
    TC = O(n)
    SC = O(n)
*/