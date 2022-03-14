public class Solution {
    public int Trap(int[] height) {
        int ans = 0;
        int n = height.Length;
        
        int[] leftMax = new int[n];
        int[] rightMax = new int[n];
        
        leftMax[0] = height[0];
        rightMax[n-1] = height[n-1];
        
        for(int i = 1; i<n; i++){ //O(n)
            leftMax[i] = Math.Max(height[i], leftMax[i-1]);
        }
        for(int i = n-2; i>=0; i--){ //O(n)
            rightMax[i] = Math.Max(height[i], rightMax[i+1]);
        }
        
        for(int i = 0; i<n; i++){ //O(n)
            ans += Math.Min(leftMax[i], rightMax[i]) - height[i];
        }
        
        return ans;
        
        /*
            TC = O(n)
            SC = O(n) for leftMax and rightMax arrays
        */
    }
}