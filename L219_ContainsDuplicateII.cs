/*

Given an integer array nums and an integer k, return true if there are two distinct indices i and j in the array such that nums[i] == nums[j] and abs(i - j) <= k.

Example 1:

Input: nums = [1,2,3,1], k = 3
Output: true


Example 2:

Input: nums = [1,0,1,1], k = 1
Output: true


Example 3:

Input: nums = [1,2,3,1,2,3], k = 2
Output: false
 

Constraints:

1 <= nums.length <= 10^5
-109 <= nums[i] <= 10^9
0 <= k <= 10^5

*/

//Approach 1 - Using Hashmap

public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        
        //key = element in nums, value = latest index of element
        Dictionary<int, int> map = new Dictionary<int, int>(); 
        
        for(int i = 0; i<nums.Length; i++){
            if(map.ContainsKey(nums[i])){
                if(i-map[nums[i]] <= k){
                    return true;
                }else{
                    map[nums[i]] = i;
                }
            }else{
                map.Add(nums[i], i);
            }
        }
        
        return false;
    }
}

/*
	TC = O(N)
	SC = O(N)
*/

//Approach 2 - Using Hashset

public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        
        HashSet<int> s = new HashSet<int>();
        
        int n = nums.Length;
        
        for(int i = 0; i<=k && i<n; i++){ //process first window of size k
            if(s.Contains(nums[i])){
                return true;
            }else{
               s.Add(nums[i]); 
            }
        }
        
        for(int i = k+1; i<n; i++){ //process remaining windows
            int removeIndex = i-k-1;
            int addIndex = i;
            s.Remove(nums[removeIndex]);
            if(s.Contains(nums[addIndex])){
                return true;
            }
            s.Add(nums[addIndex]);
        }
        
        return false;
    }
}

/*
	TC = O(N)
	SC = O(N)
*/