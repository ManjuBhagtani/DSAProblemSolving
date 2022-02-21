/*

Given an array nums of size n, return the majority element.

The majority element is the element that appears more than ⌊n / 2⌋ times. You may assume that the majority element always exists in the array.

Example 1:

Input: nums = [3,2,3]
Output: 3


Example 2:

Input: nums = [2,2,1,1,1,2,2]
Output: 2
 

Constraints:

n == nums.length
1 <= n <= 5 * 10^4
-2^31 <= nums[i] <= 2^31 - 1

*/

public class Solution {
    public int MajorityElement(int[] nums) {
        int n = nums.Length;
        
        int count = 1;
        int majorityElement = nums[0];
        
        for(int i = 1; i<n; i++){
            if(count == 0){
                majorityElement = nums[i];
                count++;
            }
            else{
                if(nums[i] == majorityElement){
                    count++;
                }else
                    count--;
            }
        }
    
        //check if value in majorityElement is actually a majority element
    
        int reqdFreq = n/2;
    
        int countOfSuspectedMajorityEle = 0;
    
        for(int i = 0; i<n; i++){
            if(nums[i] == majorityElement){
                countOfSuspectedMajorityEle++;
                if(countOfSuspectedMajorityEle > reqdFreq){
                    return majorityElement;
                }
            }
        }
        return 0;
        
    }
}

/*
	TC = O(N)
	SC = O(1)
*/