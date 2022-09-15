public class Solution {
    
    public void findNSLIndex(int[] NSL, int[] row, int n){
        Stack<int> stack = new Stack<int>();
        
        for(int i = 0; i<n; i++){
            while(stack.Count > 0 && row[stack.Peek()] >= row[i]){
                stack.Pop();
            }
            if(stack.Count > 0){
                NSL[i] = stack.Peek();
            }else{
                NSL[i] = -1;
            }
            stack.Push(i);
        }
    }
    
    public void findNSRIndex(int[] NSR, int[] row, int n){
        Stack<int> stack = new Stack<int>();
        
        for(int i = n-1; i>=0; i--){
            while(stack.Count > 0 && row[stack.Peek()] >= row[i]){
                stack.Pop();
            }
            if(stack.Count > 0){
                NSR[i] = stack.Peek();
            }else{
                NSR[i] = n;
            }
            stack.Push(i);
        }
    }
    
    public int MaximalRectangle(char[][] matrix) {
        int n = matrix.Length;
        int m = matrix[0].Length;
        
        int[] row = new int[m];
        
        int maxArea = int.MinValue;
        
        for(int i = 0; i<n; i++){
            for(int j = 0; j<m; j++){
                if(matrix[i][j] == '1'){
                    row[j] += 1;
                }else{
                    row[j] = 0;
                }
                Console.Write(row[j] + " ");
            }
            Console.WriteLine();
            int[] NSL = new int[m];
            findNSLIndex(NSL, row, m);
            
            int[] NSR = new int[m];
            findNSRIndex(NSR, row, m);
                   
            for(int j = 0; j<m; j++){
                int p1 = NSL[j];
                int p2 = NSR[j];
                int area = row[j] * (p2-p1-1);
                maxArea = Math.Max(maxArea, area);
            }
        }
        
        return maxArea;
    }
}

/*
    TC = O(n*m)
    SC = O(m)
*/