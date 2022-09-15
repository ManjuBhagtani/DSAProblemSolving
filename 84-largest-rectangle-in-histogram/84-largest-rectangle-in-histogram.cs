public class Solution {
    
    public int[] findNSLIndex(int[] heights, int n){
        int[] NSL = new int[n];
        
        Stack<int> stack = new Stack<int>();
        
        for(int i = 0; i<n; i++){
            while(stack.Count > 0 && heights[stack.Peek()] >= heights[i]){
                stack.Pop();
            }
            if(stack.Count > 0){
                NSL[i] = stack.Peek();
            }else{
                NSL[i] = -1;
            }
            stack.Push(i);
        }
        
        return NSL;
    }
    
    public int[] findNSRIndex(int[] heights, int n){
        int[] NSR = new int[n];
        
        Stack<int> stack = new Stack<int>();
        
        for(int i = n-1; i>=0; i--){
            while(stack.Count > 0 && heights[stack.Peek()] >= heights[i]){
                stack.Pop();
            }
            if(stack.Count > 0){
                NSR[i] = stack.Peek();
            }else{
                NSR[i] = n;
            }
            stack.Push(i);
        }
        
        return NSR;
    }
    
    public int LargestRectangleArea(int[] heights) {
        int n = heights.Length;
        
        int[] NSL = findNSLIndex(heights, n);
        int[] NSR = findNSRIndex(heights, n);
        
        int ans = int.MinValue;
        
        for(int i = 0; i<n; i++){
            int p1 = NSL[i];
            int p2 = NSR[i];
            int area = heights[i] * (p2-p1-1);
            
            ans = Math.Max(area, ans);
        }
        
        return ans;
    }
}

/*
    TC = O(n)
    SC = O(n)
*/