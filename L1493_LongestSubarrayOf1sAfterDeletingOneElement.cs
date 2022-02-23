/*

Given a binary array nums, you should delete one element from it.

Return the size of the longest non-empty subarray containing only 1's in the resulting array. Return 0 if there is no such subarray.

Example 1:

Input: nums = [1,1,0,1]
Output: 3
Explanation: After deleting the number in position 2, [1,1,1] contains 3 numbers with value of 1's.


Example 2:

Input: nums = [0,1,1,1,0,1,1,0,1]
Output: 5
Explanation: After deleting the number in position 4, [0,1,1,1,1,1,0,1] longest subarray with value of 1's is [1,1,1,1,1].


Example 3:

Input: nums = [1,1,1]
Output: 2
Explanation: You must delete one element.
 

Constraints:

1 <= nums.length <= 10^5
nums[i] is either 0 or 1.

*/

//Approach 1
public class Solution {
    public int LongestSubarray(int[] nums) {
        int ans = 0;
        
        int n = nums.Length;
        
        int onesTowardsLeft = 0;
        int onesTowardsRight = 0;
        
        bool zeroFound = false;
        
        for(int i = 0; i<n; i++){
            if(nums[i] == 0){
                zeroFound = true;
                int j = i-1;
                while(j >= 0){
                    if(nums[j] == 1){
                        onesTowardsLeft++;
                    }else{
                        break;
                    }
                    j--;
                }
                
                j = i+1;
                while(j<n){
                    if(nums[j] == 1){
                        onesTowardsRight++;
                    }else{
                        break;
                    }
                    j++;
                }
                ans = Math.Max(ans, onesTowardsLeft+onesTowardsRight);
                
                onesTowardsLeft = 0;
                onesTowardsRight = 0;
            }
        }
        
        if(!zeroFound){
            return n-1;
        }
        
        return ans;
    }
}

/*
	TC = O(N)
	SC = O(1)
*/

//Approach 2
public class Solution2 {
    public int LongestSubarray(int[] nums) {
        int ans = 0;
        int n  = nums.Length;
        
        int countOfZerosTillNow = 0;
        
        int left = 0;
        int right = 0;
        
        while(right < n){
            if(nums[right] == 0){
                countOfZerosTillNow++;
            }
            
            if(countOfZerosTillNow > 1){
                if(nums[left] == 0){
                    countOfZerosTillNow--;
                }
                left++;
            }
            
            ans = Math.Max(ans, right-left);
            right++;
        }
        
        return ans;
    }
}

/*
	TC = O(N)
	SC = O(1)
*/
