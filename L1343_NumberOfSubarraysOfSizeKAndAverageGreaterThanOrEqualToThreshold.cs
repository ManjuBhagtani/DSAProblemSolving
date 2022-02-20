/*
Given an array of integers arr and two integers k and threshold, return the number of sub-arrays of size k and average greater than or equal to threshold.

Example 1:

Input: arr = [2,2,2,2,5,5,5,8], k = 3, threshold = 4
Output: 3
Explanation: Sub-arrays [2,5,5],[5,5,5] and [5,5,8] have averages 4, 5 and 6 respectively. All other sub-arrays of size 3 have averages less than 4 (the threshold).


Example 2:

Input: arr = [11,13,17,23,29,31,7,5,2,3], k = 3, threshold = 5
Output: 6
Explanation: The first 6 sub-arrays of size 3 have averages greater than 5. Note that averages are not integers.
 

Constraints:

1 <= arr.length <= 10^5
1 <= arr[i] <= 10^4
1 <= k <= arr.length
0 <= threshold <= 10^4

*/

public class Solution {
    public int NumOfSubarrays(int[] arr, int k, int threshold) {
        int count = 0;
        
        int sum = 0;
        
        // sum/k >= threshold should hold true. Threfore
        // sum >= threshold*k should hold true. 
        int minLimit = threshold * k;
        
        //process the first window of size k
        for(int i = 0; i<k; i++){
            sum += arr[i];
        }
        if(sum >= minLimit){
            count++;
        }
        
        //process subsequent windows of size k
        for(int i = k; i<arr.Length; i++){
            int addIndex = i;
            int removeIndex = i-k;
            
            sum -= arr[removeIndex];
            sum += arr[addIndex];
            
            if(sum >= minLimit){
                count++;
            }
        }
        return count;
    }
}

/*
	Iterations = k for first array + N-k for subsequent array = k+N-k = N
	TC = O(N)
	SC = O(1)
*/