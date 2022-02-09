/*

Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].

The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.

You must write an algorithm that runs in O(n) time and without using the division operation.

 
Example 1:

Input: nums = [1,2,3,4]
Output: [24,12,8,6]


Example 2:

Input: nums = [-1,1,0,-3,3]
Output: [0,0,9,0,0]
 

Constraints:

2 <= nums.length <= 10^5
-30 <= nums[i] <= 30
The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.
 

*/

public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int[] left = new int[n];
        int[] right = new int[n];
        
        left[0] = nums[0];
        right[n-1] = nums[n-1];
        for(int i = 1; i<n; i++){
            left[i] = nums[i]*left[i-1];
            right[n-i-1] = nums[n-i-1]*right[n-i];
        }
        int[] ans = new int[n];
        for(int i = 0; i<n; i++){
            if(i>0 && i<n-1){
                ans[i] = left[i-1] * right[i+1];
            }else if(i == 0){
                ans[i] = right[i+1];
            }else{
                ans[i] = left[i-1];
            }
        }
        return ans;
    }
}

/*
	TC = O(N)
	SC = O(N)
*/