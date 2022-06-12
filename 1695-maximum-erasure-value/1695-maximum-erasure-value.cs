public class Solution {
    public int MaximumUniqueSubarray(int[] nums) {
        int n = nums.Length;
        int[] prefixSum = new int[n];
        prefixSum[0] = nums[0];
        
        //stores the last seen position of an element in nums
        Dictionary<int, int> posMap = new Dictionary<int, int>();
        posMap.Add(nums[0], 0);
        
        int maxSum = 0;
        
        int left = -1;
  
        for(int i = 1; i<n; i++){
            if(posMap.ContainsKey(nums[i])){
                if(left > posMap[nums[i]]){
                    posMap[nums[i]] = i;
                }else{
                    maxSum = Math.Max(prefixSum[i-1] - (left > -1 ? prefixSum[left-1]: 0), maxSum);
                    left = posMap[nums[i]]+1;
                    posMap[nums[i]] = i;
                }
            }else{
                posMap.Add(nums[i], i);
            }
            prefixSum[i] = prefixSum[i-1] + nums[i];
        }
        maxSum = Math.Max(prefixSum[n-1] - (left > -1 ? prefixSum[left-1]: 0), maxSum);
        
        return maxSum;
        
        /*
            TC = O(n)
            SC = O(n) for prefixSum + O(n) for dictionary 
               = O(n)
        */
    }
}

//left = 6, maxSum = 8
//[5,2,1,2,5,2,1,2,5]  pf[5, 7, 8, 10, 15, 17, 18, 20]
//<5, 8> i = 0
//<2, 7> i = 1
//<1, 6> i = 2
//       i = 3
