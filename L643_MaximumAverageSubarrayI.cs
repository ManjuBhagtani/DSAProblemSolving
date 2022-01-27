/*

You are given an integer array nums consisting of n elements, and an integer k.

Find a contiguous subarray whose length is equal to k that has the maximum average value and return this value. Any answer with a calculation error less than 10-5 will be accepted.

Example 1:

Input: nums = [1,12,-5,-6,50,3], k = 4
Output: 12.75000
Explanation: Maximum average is (12 - 5 - 6 + 50) / 4 = 51 / 4 = 12.75


Example 2:

Input: nums = [5], k = 1
Output: 5.00000
 

Constraints:

n == nums.length
1 <= k <= n <= 105
-104 <= nums[i] <= 104

*/

public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        double sum = 0;
        
        //Get the sum of first subarray of length k
        for(int i = 0; i<k; i++){
            sum += nums[i];
        }
        
        //Let sum of first subarray of length k be the maxSubarraySum
        double maxSubarraySum = sum;

        //Next subarray will start at 1 and end at k
        int start = 1;
        int end = k;
        
        //For each subsequent subarray, it's 
        //sum = previous subarray sum - first element of previous subarray + last element of current subarray
        //Compare this sum with maxSubarraySum we have got so far
        for( ; start <= nums.Length-k; start++, end++){
            sum = sum - nums[start-1] + nums[end];
            maxSubarraySum = Math.Max(maxSubarraySum, sum);
        }

        return maxSubarraySum/k;    
    }
}

/*
    TC = O(N)
    SC = O(1)
*/