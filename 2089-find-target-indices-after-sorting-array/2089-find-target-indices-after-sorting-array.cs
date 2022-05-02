public class Solution {
    public IList<int> TargetIndices(int[] nums, int target) {
        Array.Sort(nums);
        int n = nums.Length;
        int low = 0;
        int high = n-1;
        int firstOccurrence = -1;
        int lastOccurrence = -1;
        while(low <= high){
            int mid = low + (high-low)/2;
            if(nums[mid] == target){
                firstOccurrence = mid;
                high = mid-1;
            }else if(nums[mid] < target){
                low = mid+1;
            }else{
                high = mid-1;
            }
        }
        if(firstOccurrence != -1){
            lastOccurrence = firstOccurrence;
            low = lastOccurrence+1;
            high = n-1;
            while(low <= high){
                int mid = low + (high-low)/2;
                if(nums[mid] == target){
                    lastOccurrence = mid;
                    low = mid+1;
                }else{
                    high = mid-1;
                }
            }
        }
        List<int> ans = new List<int>();
        if(firstOccurrence > -1){
            for(int i = firstOccurrence; i<=lastOccurrence; i++){
                ans.Add(i);
            }
        }
        
        return ans;
        
        /*
            TC = O(nlogn)
            SC = O(1)
        */
    }
}