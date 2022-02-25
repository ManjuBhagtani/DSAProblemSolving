/*

Given an integer array nums and an integer k, return the number of pairs (i, j) where i < j such that |nums[i] - nums[j]| == k.

The value of |x| is defined as:

x if x >= 0.
-x if x < 0.
 

Example 1:

Input: nums = [1,2,2,1], k = 1
Output: 4


Example 2:

Input: nums = [1,3], k = 3
Output: 0
Explanation: There are no pairs with an absolute difference of 3.


Example 3:

Input: nums = [3,2,1,5,4], k = 2
Output: 3


Constraints:

1 <= nums.length <= 200
1 <= nums[i] <= 100
1 <= k <= 99

*/

public class Solution {
    public int CountKDifference(int[] nums, int k) {
        Dictionary<int, int> freq = new Dictionary<int, int>();
        
        int ans = 0;
        
        for(int i = 0; i<nums.Length; i++){
            if(freq.ContainsKey(nums[i])){
                freq[nums[i]]++;
            }else{
                freq.Add(nums[i],1);
            }
            if(freq.ContainsKey(nums[i] - k)){
                ans += freq[nums[i]-k];
            }
            if(freq.ContainsKey(nums[i]+k)){
                ans += freq[nums[i]+k];
            }
            
        }
        
        return ans;
    }
}

/*
	TC = O(N)
	SC = O(N)
*/

//Same approach implemented differently
public class Solution2 {
    public int CountKDifference(int[] nums, int k) {
        Dictionary<int, int> freq = new Dictionary<int, int>();
        
        int ans = 0;
        
        for(int i = 0; i<nums.Length; i++){
            if(freq.ContainsKey(nums[i])){
                freq[nums[i]]++;
            }else{
                freq.Add(nums[i],1);
            }           
        }
        
        for(int i = 0; i<nums.Length; i++){
            if(freq.ContainsKey(nums[i] - k)){
                ans += freq[nums[i]-k];
            }         
        }
        
        return ans;
    }
}

/*
	TC = O(N)
	SC = O(N)
*/