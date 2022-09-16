public class Solution {
    
    public int[] findNSL(int[] arr, int n){
        int[] NSL = new int[n];
        
        Stack<int> stack = new Stack<int>();
        
        for(int i = 0; i<n; i++){

            while(stack.Count > 0 && arr[stack.Peek()] > arr[i]){
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
    
    public int[] findNSR(int[] arr, int n){
        int[] NSR = new int[n];
        
        Stack<int> stack = new Stack<int>();
        
        for(int i = n-1; i >= 0; i--){

            while(stack.Count > 0 && arr[stack.Peek()] >= arr[i]){
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
    public int SumSubarrayMins(int[] arr) {
        int n = arr.Length;
        
        int[] NSL = findNSL(arr, n);
        int[] NSR = findNSR(arr, n);
        
        long sum = 0;
        int mod = 1000000000+7;
        
        for(int i = 0; i<n; i++){
            int p1 = NSL[i];
            int p2 = NSR[i];
            
            int startPoints = i-p1;
            int endPoints = p2-i;
            //sum += (startPoints * endPoints * (long)arr[i]);
            //sum %= mod;
            sum = (sum%mod + (((startPoints%mod) * (endPoints%mod))%mod * ((long)arr[i]%mod))%mod)%mod;
        }
        
        return (int)sum;
    }
}

/*
    TC = O(n)
    SC = O(n)
*/