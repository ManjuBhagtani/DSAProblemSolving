/*

You are given a 2D integer array ranges and two integers left and right. Each ranges[i] = [starti, endi] represents an inclusive interval between starti and endi.

Return true if each integer in the inclusive range [left, right] is covered by at least one interval in ranges. Return false otherwise.

An integer x is covered by an interval ranges[i] = [starti, endi] if starti <= x <= endi.

Example 1:

Input: ranges = [[1,2],[3,4],[5,6]], left = 2, right = 5
Output: true
Explanation: Every integer between 2 and 5 is covered:
- 2 is covered by the first range.
- 3 and 4 are covered by the second range.
- 5 is covered by the third range.


Example 2:

Input: ranges = [[1,10],[10,20]], left = 21, right = 21
Output: false
Explanation: 21 is not covered by any range.
 

Constraints:

1 <= ranges.length <= 50
1 <= starti <= endi <= 50
1 <= left <= right <= 50

*/

public class Solution {
    public bool IsCovered(int[][] ranges, int left, int right) {
        //keeps track of whether all elements in the range left to right have been seen i.e. covered by the ranges
        //range can go from 1 to 50
        int[] seen = new int[52];
        
        //mark the start of a range as seen and end+1 as not seen
        //the indices in seen array range from 0 to 51
        //so if a range is ex. 1 to 50, then end+1 = 50+1 = 51 - won't go out of the bounds
        foreach(int[] range in ranges){
            seen[range[0]]++;
            seen[range[1]+1]--;
        }
        
        for(int i = 1; i<=right; i++){
            seen[i] += seen[i-1];
        }
        
        for(int i = left; i<=right; i++){
            if(seen[i] <= 0){
                return false;
            }
        }
        return true;
    }
}

/*

	TC = O(n+k), where k = right-left+1
	SC = O(52) = O(1)
*/