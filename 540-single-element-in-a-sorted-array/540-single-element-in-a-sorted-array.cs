public class Solution {
    public int binarySearch(int[] A, int low, int high, int n){
        while(low <= high){
            if(low == high){
                return A[low];
            }
            int mid = low + (high-low)/2;
            if(mid == 0){
                if(1<n && A[0] != A[1]){
                    return A[0];
                }
            }
            if((mid-1 >=0 && A[mid-1] != A[mid]) && (mid+1 <n && A[mid]!= A[mid+1])){
                return A[mid];
            }
            int firstOccurrence = -1;
            if(mid-1 >= 0 && A[mid-1] == A[mid]){
                firstOccurrence = mid-1;
            }else{
                firstOccurrence = mid;
            }
            if(firstOccurrence%2 == 0){
                low = mid+1;
            }else{
                high = mid-1;
            }
        }
        return A[low];
    }
    public int SingleNonDuplicate(int[] nums) {
        int n = nums.Length;
        return binarySearch(nums, 0, n-1, n);
    }
    
    /*
        TC = O(nlogn)
        SC = O(1)
    */
}