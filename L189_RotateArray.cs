/*

Given an array, rotate the array to the right by k steps, where k is non-negative.

 

Example 1:

Input: nums = [1,2,3,4,5,6,7], k = 3
Output: [5,6,7,1,2,3,4]
Explanation:
rotate 1 steps to the right: [7,1,2,3,4,5,6]
rotate 2 steps to the right: [6,7,1,2,3,4,5]
rotate 3 steps to the right: [5,6,7,1,2,3,4]
Example 2:

Input: nums = [-1,-100,3,99], k = 2
Output: [3,99,-1,-100]
Explanation: 
rotate 1 steps to the right: [99,-1,-100,3]
rotate 2 steps to the right: [3,99,-1,-100]
 

Constraints:

1 <= nums.length <= 10^5
-2^31 <= nums[i] <= 2^31 - 1
0 <= k <= 10^5

*/

public class Solution {
    
    public int[] reverse(int[] nums, int start, int end){
        while(start < end){
            int temp = nums[start];
            nums[start] = nums[end];
            nums[end] = temp;
            start++;
            end--;
        }
        return nums;
    }
    
    public void Rotate(int[] nums, int k) {
        if(k == 0){
            return;
        }
        int n = nums.Length;
        k = k % n;
        nums = reverse(nums, 0, n-1);
        nums = reverse(nums, 0, k-1);
        nums = reverse(nums, k, n-1);
    }
}

/*
	Iterations = n + k + (n-1-k+1) = n+k+n-k = 2n
	TC = O(n)
	SC = O(1)
*/