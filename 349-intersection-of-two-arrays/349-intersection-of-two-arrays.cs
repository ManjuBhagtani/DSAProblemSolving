public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        Array.Sort(nums1);
        Array.Sort(nums2);
        int n = nums1.Length;
        int m = nums2.Length;
        int minLength = Math.Min(n, m);
        bool flag = true;
        if(n > m){
            flag = false;
        }
        List<int> ans = new List<int>();
        for(int i = 0; i<minLength; i++){
            int index = -1;
            int element = -1;
            if(flag){
                if(ans.Count > 0 && ans[ans.Count-1] == nums1[i]){
                    continue;
                }
                index = Array.BinarySearch(nums2, nums1[i]);
                element = nums1[i];
            }else{
                if(ans.Count > 0 && ans[ans.Count-1] == nums2[i]){
                    continue;
                }
                index = Array.BinarySearch(nums1, nums2[i]);
                element = nums2[i];
            }
            if(index >= 0){
                ans.Add(element);
            }
        }
        
        return ans.ToArray();
        
        /*
            TC = O(nlogn + mlogm + min(n,m)log(max(n,m)))
            SC = sorting algo space + O(min(n,m))
        */
    }
}