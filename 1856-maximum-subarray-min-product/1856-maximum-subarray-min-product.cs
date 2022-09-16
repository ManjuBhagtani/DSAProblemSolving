public class Solution {
    
    public int[] findNSL(int[] nums, int n){
        int[] NSL = new int[n];
        
        Stack<int> stack = new Stack<int>();
        
        for(int i = 0; i<n; i++){
            while(stack.Count > 0 && nums[stack.Peek()] >= nums[i]){
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
    
    public int[] findNSR(int[] nums, int n){
        int[] NSR = new int[n];
        
        Stack<int> stack = new Stack<int>();
        
        for(int i = n-1; i>=0; i--){
            while(stack.Count > 0 && nums[stack.Peek()] >= nums[i]){
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
    
    public int MaxSumMinProduct(int[] nums) {
        int n = nums.Length;
        
        int[] NSL = findNSL(nums, n);
        int[] NSR = findNSR(nums, n);
        
        long[] prefix = new long[n];
        prefix[0] = (long)nums[0];
        for(int i = 1; i<n; i++){
            prefix[i] = (long)nums[i] + prefix[i-1];
            //Console.Write("pf[i]: " + prefix[i]);
        }
        
        long maxMinProduct = 0;
        int mod = 1000000000+7;
        
        for(int i = 0; i<n; i++){
            int p1 = NSL[i];
            int p2 = NSR[i];
            
            //Console.WriteLine(p1 + " " + p2);
            //int subarraySizeWithNumsOfIAsMin = p2-p1-1;
            long minProduct = 0;
            if(p1 != -1){
                minProduct = (prefix[p2-1] - prefix[p1]) * nums[i];
            }else{
                minProduct = prefix[p2-1] * nums[i];
            }
            
            maxMinProduct = Math.Max(maxMinProduct, minProduct);
        }
        
        return (int)(maxMinProduct%mod);
    }
}

/*
    TC = O(n)
    SC = O(n)
*/