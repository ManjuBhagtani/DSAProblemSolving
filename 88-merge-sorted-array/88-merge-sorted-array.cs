public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int l1 = m+n;
        int k = m-1;
        for(int i = l1-1; i>=n; i--){ //O(m)
            nums1[i] = nums1[k--];
        }
        
        int p1 = l1-m;
        int p2 = 0;
        int p3 = 0;
        
        while(p1 < l1 && p2 < n){
            if(nums1[p1] <= nums2[p2]){
                nums1[p3] = nums1[p1];
                p1++;
            }else{
                nums1[p3] = nums2[p2];
                p2++;
            }
            p3++;
        }
        while(p1 < l1){
            nums1[p3] = nums1[p1];
            p1++; p3++;
        }
        while(p2 < n){
            nums1[p3] = nums2[p2];
            p2++; p3++;
        }
        
        /*
            TC = O(m+n)
            SC = O(1)
        */
    }
}
