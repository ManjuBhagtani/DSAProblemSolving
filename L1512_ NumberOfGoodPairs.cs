/*

Given an array of integers nums, return the number of good pairs.

A pair (i, j) is called good if nums[i] == nums[j] and i < j.

Example 1:

Input: nums = [1,2,3,1,1,3]
Output: 4
Explanation: There are 4 good pairs (0,3), (0,4), (3,4), (2,5) 0-indexed.


Example 2:

Input: nums = [1,1,1,1]
Output: 6
Explanation: Each pair in the array are good.


Example 3:

Input: nums = [1,2,3]
Output: 0
 

Constraints:

1 <= nums.length <= 100
1 <= nums[i] <= 100

*/

public class Solution {
    
    public int NumIdenticalPairs(int[] nums) {
        int count = 0;
        
        //Hashtable to maintain the count of each element until the current index
        //For each new element, we check if it already exists in the map
        //If it exists, we add to count map[element] (count of number of times 
        //element is already present until the current index)
        Dictionary<int, int> map = new Dictionary<int, int>(nums.Length);
        foreach(int element in nums){
            if(map.ContainsKey(element)){
                count += map[element]++;
            }else{
                map.Add(element, 1);
            }
        }      
        
        return count;
    }
}

/*
	TC = O(N) + O(1) (for Dictionary ContainsKey operation) + O(1) (for Dictionary Add operation) = O(N)
	SC = O(N)
*/